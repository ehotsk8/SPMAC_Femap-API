using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using femap;
using SPMAC_for_Femap.Classes;
using SPMAC_for_Femap.Classes.DB;
using SPMAC_for_Femap.Forms;
using SPMAC_for_Femap.Properties;
using Telerik.WinControls.UI;
using SPMAC_for_Femap.Forms.Output;
using System.Threading.Tasks;
using SPMAC_for_Femap.Forms.Details;

namespace SPMAC_for_Femap
{
    public partial class MainForm : RadForm
    {
        private readonly model femapModel;
        private DBController DbContoller = new DBController();
        private int Degree = 0;
        public MainForm()
        {
            InitializeComponent();
        // Process.Start("D:Program Files/Femap1112/femap.exe");
        go:
            try
            {
                femapModel = (model)Marshal.GetActiveObject("femap.model");
                femapModel.feAppRegisterAddInPane(true, Handle.ToInt32(), statusStrip.Handle.ToInt32(), false, true, 1, 4);
            }
            catch { goto go; }
            Status.CurrentDirectory = Directory.GetCurrentDirectory();
            Status.CurrentDetailsSetDirectory = Status.CurrentDirectory + "/FEMAP/DETAILS SET " +
                                                DbContoller.Context().DETAILS.Count();
            Directory.CreateDirectory("FEMAP");
            Status.CurrState = Status.CurrentState.READY;
            timer1.Start();
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            new SyncGUI(femapModel).View();
            Task.Run(() => ConnectSQL());
        }

        private async Task ConnectSQL()
        {
            if (DbContoller.Context().DETAILS.CountAsync().Result == 0)
                await Task.Run(() => DbContoller.LogSQLServerAsync(1));
        }

        private void WaitImage()
        {
            if (Degree == 0)
                Status.ImageState = Resources.WAIT0;
            if (Degree == 45)
                Status.ImageState = Resources.WAIT45;
            if (Degree == 90)
                Status.ImageState = Resources.WAIT90;
            if (Degree == 135)
                Status.ImageState = Resources.WAIT135;
            if (Degree == 180)
                Status.ImageState = Resources.WAIT180;
            if (Degree == 225)
                Status.ImageState = Resources.WAIT225;
            if (Degree == 270)
                Status.ImageState = Resources.WAIT270;
            if (Degree == 315)
                Status.ImageState = Resources.WAIT315;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Degree > 315) Degree = 0;
            switch (Status.CurrState)
            {
                case Status.CurrentState.READY:
                    Status.CurrentStatusString = "Готово";
                    Status.ImageState = Resources.OK;
                    break;
                case Status.CurrentState.CREATING:
                    Status.CurrentStatusString = "Построение детали";
                    WaitImage();
                    break;
                case Status.CurrentState.WARNING:
                    Status.CurrentStatusString = "Внимание";
                    Status.ImageState = Resources.WARNING;
                    break;
                case Status.CurrentState.SAVING:
                    Status.CurrentStatusString = "Сохранение";
                    Status.ImageState = Resources.SAVE;
                    break;
                case Status.CurrentState.ERROR:
                    StatusLabel.Text = "Ошибка";
                    Status.ImageState = Resources.FALL;
                    break;
                case Status.CurrentState.ASSEMBLY:
                    Status.CurrentStatusString = "Создание сборки";
                    Status.ImageState = Resources.ASSEMBLY;
                    break;
                case Status.CurrentState.WAIT:
                    Status.CurrentStatusString = "Подождите.. идет запись в БД";
                    WaitImage();
                    break;
                case Status.CurrentState.ANALYSIS:
                    Status.CurrentStatusString = "Подождите.. идет КЭ Анализ";
                    WaitImage();
                    break;
            }
            if (Status.CurrState != Status.CurrentState.ERROR)
                StatusLabel.Text = Status.CurrentStatusString;
            StatusImage.Image = Status.ImageState;
            progressBar1.Value1 = Status.ProgressValue;
            Degree += 45;
        }

        private void RodButton_Click(object sender, EventArgs e)
        {
            new ParamConnectingRodForm(femapModel).Show();
        }

        private void PistonButton_Click(object sender, EventArgs e)
        {
            new ParamPistonForm(femapModel).Show();
        }

        private void FingerButton_Click(object sender, EventArgs e)
        {
            new PistonFingerForm(femapModel).Show();
        }

        private void AssemblyButton_Click(object sender, EventArgs e)
        {
            new AssemblyForm(femapModel).Show();
        }

        private void AnalysisButton_Click(object sender, EventArgs e)
        {
            new AnalysisForm(femapModel).Show();
        }

        private void RodCoverButton_Click(object sender, EventArgs e)
        {
            new RodCoverForm(femapModel).Show();
        }

        private void СrankshaftButton_Click(object sender, EventArgs e)
        {
            new СrankshaftForm(femapModel).Show();
        }

        private void СylinderButton_Click(object sender, EventArgs e)
        {
            new CylinderSleeveForm(femapModel).Show();
        }

        private void OutputDataButton_Click(object sender, EventArgs e)
        {
            new OutputForm().Show();
        }
    }
}