using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using femap;
using SPMAC_for_Femap.Classes;
using SPMAC_for_Femap.Classes.Analysis;
using SPMAC_for_Femap.Classes.DB;
using SPMAC_for_Femap.Classes.DB.Model;
using SPMAC_for_Femap.Forms.Analysis;
using Telerik.WinControls.UI;

namespace SPMAC_for_Femap
{
    public partial class AnalysisForm : RadForm
    {
        private readonly model FemapModel;

        public AnalysisForm(model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
            timer1.Start();
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            StatusImage.Image = Status.ImageState;
            StatusLabel.Text = Status.CurrentStatusString;
        }

        private void MaterialButton_Click(object sender, EventArgs e)
        {
            new MaterialPropertyForm(FemapModel).Show();
            Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            new LoadOnModelForm(FemapModel).Show();
            Close();
        }

        private void ConstraintButton_Click(object sender, EventArgs e)
        {
            new ConstraintForm(FemapModel).Show();
            Close();
        }

        private void FEAButton_Click(object sender, EventArgs e)
        {
            new FEAForm(FemapModel).Show();
            Close();
        }

        private void AnalysisButton_Click(object sender, EventArgs e)
        {
            new AnalysisProperty(FemapModel).SetProperty();
            Status.CurrState = Status.CurrentState.ANALYSIS;
            DBController db = new DBController();
            Task.Run(() => SQLControl("Анализ: " + (db.Context().ANALYSIS.Count() + 1),
                   db.Context().CREATEDETAILS.CountAsync().Result - 1));
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            new SyncGUI(FemapModel).ViewAnalysis();
        }

        private async Task SQLControl(string Title, int DBDetailId)
        {
            bool isOutputSet = false;
            DBController db = new DBController();
            while (!isOutputSet)
            {
                if (FemapModel.Info_Count[zDataType.FT_OUT_CASE] > 0)
                {
                    Status.CurrState = Status.CurrentState.WAIT;
                    new OutputResults(FemapModel).AddResultsToDb();
                    await Task.Run(() => db.AddAnalysisAsync(Title, DBDetailId));
                    new SyncGUI(FemapModel).ViewAnalysis();
                    isOutputSet = true;
                }
                Thread.Sleep(350);
            }
            Status.CurrState = Status.CurrentState.READY;
        }
    }
}
