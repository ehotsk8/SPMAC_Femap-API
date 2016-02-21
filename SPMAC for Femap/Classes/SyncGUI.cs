using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using femap;
using Telerik.WinControls.UI;
using System.Drawing;
using SPMAC_for_Femap.Classes.DB;

namespace SPMAC_for_Femap.Classes
{
    class SyncGUI
    {
        private readonly model FemapModel;
        private int countError;

        public SyncGUI(model FemapModel)
        {
            this.FemapModel = FemapModel;
        }

        public void View()
        {
            femap.View view = FemapModel.feView;
            view.Initialize();
            view.Draw[zViewOptions.FVI_CURVE] = false;
            view.Draw[zViewOptions.FVI_POINT] = false;
            view.Draw[zViewOptions.FVI_FILLED_EDGES] = false;
            view.WindowBackColor = zColor.FCL_GRAY150;
            view.WindowBackColor2 = zColor.FCL_GRAY230;
            view.rotation[0] = -50;
            view.rotation[2] = 45;
            view.ColorMode[zViewOptions.FVI_SHADING] = 2;
            view.Put(1);
            view.Regenerate();
        }

        public void ViewAnalysis()
        {
            femap.View view = FemapModel.feView;
            view.Initialize();
            view.Draw[zViewOptions.FVI_CURVE] = false;
            view.Draw[zViewOptions.FVI_POINT] = false;
            view.Draw[zViewOptions.FVI_FILLED_EDGES] = false;
            view.Draw[zViewOptions.FVI_SURFACE] = false;
            view.Draw[zViewOptions.FVI_NODE] = false;
            view.Draw[zViewOptions.FVI_FILLED_EDGES] = true;
            view.WindowBackColor = zColor.FCL_GRAY150;
            view.WindowBackColor2 = zColor.FCL_GRAY230;
            view.rotation[0] = -50;
            view.rotation[2] = 45;
            view.ColorMode[zViewOptions.FVI_SHADING] = 2;
            view.ColorMode[zViewOptions.FVI_FILLED_EDGES] = 3;
            view.Deformed = zDeformedFormat.FDF_DEFORMED;
            view.Contour = zContourFormat.FCF_CONTOUR;
            view.DeformData = 1;
            view.ContourData = 60031;
            view.OutputSet = 1;
            view.Put(1);
            view.Regenerate();
        }

        public void SyncSizes(RadGroupBox groupBox1)
        {
            try
            {
                SerializeXML serialize = new SerializeXML(Status.CurrentDetailsSetDirectory + @"\SIZES.xml");
                List<SIZE> list = serialize.DeSerializer();
                if (list.Count > 0)
                    for (int i = 0; i < groupBox1.Controls.Count; i++)
                        if (groupBox1.Controls[i] is RadTextBox)
                            foreach (var a in list)
                                if (groupBox1.Controls[i].Name == a.Id)
                                {
                                    groupBox1.Controls[i].Text = a.Value.ToString();
                                    groupBox1.Controls[i].Enabled = false;
                                    ((RadTextBox)groupBox1.Controls[i]).TextBoxElement.Border.ForeColor = Color.DarkSlateGray;
                                }
                groupBox1.FooterText = "Размеры загружены";
                groupBox1.GroupBoxElement.Footer.ForeColor = Color.DarkGreen;
            }
            catch (Exception)
            {
                Status.CurrState = Status.CurrentState.WARNING;
                groupBox1.FooterText = "Нет файла с размерами";
                groupBox1.GroupBoxElement.Footer.ForeColor = Color.DarkGoldenrod;
                foreach (var tb in groupBox1.Controls)
                    if (tb is RadTextBox)
                    {
                        ((RadTextBox)tb).Enabled = true;
                        ((RadTextBox)tb).TextBoxElement.Border.ForeColor = Color.DarkGoldenrod;
                    }
            }
        }

        public double DParse(RadTextBox textBox)
        {
            try
            {
                textBox.TextBoxElement.Border.ForeColor = textBox.TextBoxElement.Border.ForeColor == Color.Red ? Color.Lime : Color.Lime;
                if (Status.CurrState == Status.CurrentState.CREATING)
                    Status.CurrState = Status.CurrentState.CREATING;
                else if (countError == 0)
                    Status.CurrState = Status.CurrentState.READY;
                return Double.Parse(textBox.Text.Replace(".", ","));
            }
            catch (FormatException e)
            {
                countError++;
                Status.CurrState = Status.CurrentState.ERROR;
                Status.CurrentStatusString = "Ошибка: " + e.Message;
                textBox.TextBoxElement.Border.ForeColor = Color.Red;
                return 0;
            }
        }

        private async void SQLControl(string ModelName)
        {
            DBController db = new DBController();
            await Task.Run(() => db.AddSizesAsync(db.Context().DETAILS.Select(x => x.DetailsSetId).ToList()[db.Context().DETAILS.CountAsync().Result - 1], ModelName));
        }

        public async void Create_Async(RadGroupBox groupBox1, string DeatailType)
        {
            countError = 0;
            Sizes.Clear();
            SerializeXML serialize = new SerializeXML(Status.CurrentDetailsSetDirectory + @"\SIZES.xml");
            foreach (var tb in groupBox1.Controls)
                if (tb is RadTextBox)
                {
                    Sizes.Add((tb as RadTextBox).Name, DParse(tb as RadTextBox));
                    if (SerializeXML.Check(SerializeXML.Values(), (tb as RadTextBox).Name))
                        SerializeXML.Add((tb as RadTextBox).Name, DParse(tb as RadTextBox));
                }
            serialize.Serialize(SerializeXML.Values());

            if (Status.CurrState == Status.CurrentState.READY && Status.CurrState != Status.CurrentState.ERROR)
            {
                try
                {
                    switch (DeatailType)
                    {
                        case "Поршень":
                            await Task.Run(() => new MakeDetails(FemapModel).CreatePistonAsync(Status.CancellationTokenSourse.Token));
                            break;
                        case "Шатун":
                            await Task.Run(() => new MakeDetails(FemapModel).CreateConnectingRodAsync(Status.CancellationTokenSourse.Token));
                            break;
                        case "Крышка шатуна":
                            await Task.Run(() => new MakeDetails(FemapModel).CreateCoverRodAsync(Status.CancellationTokenSourse.Token));
                            break;
                        case "Поршневой палец":
                            await Task.Run(() => new MakeDetails(FemapModel).CreatePistonFingerAsync(Status.CancellationTokenSourse.Token));
                            break;
                        case "Коленчатый вал":
                            await Task.Run(() => new MakeDetails(FemapModel).CreateCrankshaftAsync(Status.CancellationTokenSourse.Token));
                            break;
                        case "Гильза цилиндра":
                            await Task.Run(() => new MakeDetails(FemapModel).CreateSleeveAsync(Status.CancellationTokenSourse.Token));
                            break;
                    }
                    SQLControl(DeatailType);
                }
                catch (OperationCanceledException)
                {
                    Status.CurrState = Status.CurrentState.WARNING;
                    if (MessageBox.Show("Построение было отменено пользователем.\nСохранить изменения?", "Внимание",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Status.CurrState = Status.CurrentState.SAVING;
                        FemapModel.feFileSave(false);
                    }
                    else
                    {
                        Status.CurrState = Status.CurrentState.READY;
                        FemapModel.feFileClose(false);
                        FemapModel.feFileNew();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed.");
                }
                await Task.Delay(500);
                SyncSizes(groupBox1);
                Status.CurrState = Status.CurrentState.READY;
            }
            else if (Status.CurrentStatusString == "Построение детали")
            {
                MessageBox.Show("Подождите.. Идет построение детали");
                Status.CurrState = Status.CurrentState.CREATING;
            }
        }
    }
}
