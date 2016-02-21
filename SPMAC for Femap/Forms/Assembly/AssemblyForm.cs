using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using femap;
using Telerik.WinControls;
using SPMAC_for_Femap.Classes;
using System.Threading.Tasks;
using SPMAC_for_Femap.Classes.DB;
using Telerik.WinControls.UI;

namespace SPMAC_for_Femap.Forms
{
    public partial class AssemblyForm : Telerik.WinControls.UI.RadForm
    {
        private readonly model FemapModel;
        private string Path = "";

        public AssemblyForm(model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
            Status.CancellationTokenSourse = new CancellationTokenSource();
            timer1.Start();
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            DBServerContext context = new DBServerContext();
            comboDetailSets.DataSource = context.DETAILS.Select(s => s.Name).ToList();
        }

        private void CheckFiles(string Path, RadLabel label, RadCheckBox checkBox)
        {
            if (!File.Exists(Path))
            {
                label.BackColor = Color.Brown;
                label.LabelElement.ForeColor = Color.White;
                checkBox.Enabled = false;
            }
            else if (!checkBox.Checked) { label.BackColor = Color.OrangeRed; label.LabelElement.ForeColor = Color.White; checkBox.Enabled = true; }
            else { label.BackColor = Color.PaleGreen; label.LabelElement.ForeColor = Color.Black; checkBox.Enabled = true; }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            StatusImage.Image = Status.ImageState;
            progressBar1.Value1 = Status.ProgressValue;
            StatusLabel.Text = Status.CurrentStatusString;

            Path = Status.CurrentDirectory + @"\FEMAP\DETAILS SET " + (comboDetailSets.SelectedIndex + 1);
            CheckFiles(Path + @"\ROD\Rod.stp", L1, RodCheck);
            CheckFiles(Path + @"\COVER\CoverRod.stp", L2, RodCoverCheck);
            CheckFiles(Path + @"\PISTON\Piston.stp", L3, PistonCheck);
            CheckFiles(Path + @"\FINGER\Finger.stp", L4, FingerCheck);
            CheckFiles(Path + @"\CRANKSHAFT\Crankshaft.stp", L5, CrankshaftCheck);
            CheckFiles(Path + @"\SLEEVE\SleeveCylinder.stp", L6, CylinderCheck);
        }

        private async void CreateAssyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() => new Assembly(FemapModel).CreateAssembly_Async(
                    Status.CancellationTokenSourse.Token, Path, RodCheck.Checked, RodCoverCheck.Checked, PistonCheck.Checked,
                    FingerCheck.Checked, CrankshaftCheck.Checked, CylinderCheck.Checked));
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
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Status.CurrState != Status.CurrentState.ASSEMBLY)
                Status.CurrState = Status.CurrentState.READY;
            Close();
        }

        private void ParamConnectingRodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Status.CurrState != Status.CurrentState.ASSEMBLY)
                Status.CurrState = Status.CurrentState.READY;
        }

        private void CancelTask()
        {
            ICancelModelling cancel = new MakeDetails(FemapModel);
            cancel.CancelTask();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            CancelTask();
            Status.CancellationTokenSourse = new CancellationTokenSource();
        }
    }
}
