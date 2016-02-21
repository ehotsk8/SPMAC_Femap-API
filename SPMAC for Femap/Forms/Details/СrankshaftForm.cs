using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using femap;
using SPMAC_for_Femap.Classes;
using SPMAC_for_Femap.Classes.DB;
using Telerik.WinControls.UI;

namespace SPMAC_for_Femap.Forms
{
    public partial class СrankshaftForm : RadForm
    {
        private readonly model FemapModel;
        private int xPos, yPos;
        private int countError;
        private SyncGUI ui;
        private DBServerContext db;

        public СrankshaftForm(femap.model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
            Status.CancellationTokenSourse = new CancellationTokenSource();
            timer1.Start();
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            ui = new SyncGUI(FemapModel);
            ui.SyncSizes(groupBox1);
            db = new DBServerContext();
            Task.Run(() => FindDetail());
        }

        private async Task FindDetail()
        {
            int currentId = db.DETAILS.Select(s => s.DetailsSetId).ToListAsync().Result[db.DETAILS.Select(s => s.DetailsSetId).CountAsync().Result - 1];
            foreach (var detail in db.CREATEDETAILS.Where(w => w.DetailsSet.DetailsSetId == currentId).Select(s => s.DetailsList))
                if (detail == "Коленчатый вал") CreateBtn.Enabled = false;            
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            StatusImage.Image = Status.ImageState;
            progressBar1.Value1 = Status.ProgressValue;
            StatusLabel.Text = Status.CurrentStatusString;
        }

        private async void CreateBtn_Click_Async(object sender, EventArgs e)
        {
            Status.CurrentDetailsSetDirectory = Status.CurrentDirectory + "/FEMAP/DETAILS SET " + db.DETAILS.Count();
            Directory.CreateDirectory(Status.CurrentDetailsSetDirectory);
            Directory.CreateDirectory(Status.CurrentDetailsSetDirectory + "/CRANKSHAFT");
            CreateBtn.Enabled = false;
            ui.Create_Async(groupBox1, "Коленчатый вал");
        }

        private void ResetSizes_Click(object sender, EventArgs e)
        {
            CreateBtn.Enabled = true;
            new DBController().AddDetailsSet();
            SerializeXML.Clear();
            ui.SyncSizes(groupBox1);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Capture)
            {
                xPos = (e.X - xPos);
                yPos = (e.Y - yPos);
                if (xPos > 0 && xPos < pictureBox1.Width && yPos > 0 && yPos < pictureBox1.Height)
                {
                    panel1.HorizontalScroll.Value = xPos;
                    panel1.VerticalScroll.Value = yPos;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Size = pictureBox1.Image.Size;
            xPos = e.X; yPos = e.Y;
            if (xPos > 0 && xPos < pictureBox1.Width && yPos > 0 && yPos < pictureBox1.Height)
            {
                panel1.HorizontalScroll.Value = xPos;
                panel1.VerticalScroll.Value = yPos;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.HorizontalScroll.Visible = false;
            panel1.VerticalScroll.Visible = false;
            panel1.SetAutoScrollMargin(0, 0);
            pictureBox1.Size = new Size(620, 391);
            xPos = e.X; yPos = e.Y;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Status.CurrState != Status.CurrentState.CREATING)
                Status.CurrState = Status.CurrentState.READY;
            Close();
        }

        private void ParamConnectingRodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Status.CurrState != Status.CurrentState.CREATING)
                Status.CurrState = Status.CurrentState.READY;
        }

        public void CancelTask()
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
