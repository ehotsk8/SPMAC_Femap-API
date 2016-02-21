using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using femap;
using SPMAC_for_Femap.Classes;
using SPMAC_for_Femap.Classes.DB;
using Telerik.WinControls.UI;

namespace SPMAC_for_Femap.Forms.Analysis
{
    public partial class ConstraintForm : RadForm
    {
        private readonly model FemapModel;

        public ConstraintForm(model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
        }

        private void ConstraintButton_Click(object sender, EventArgs e)
        {
            ConstraintsOnModel constraint = new ConstraintsOnModel(FemapModel);
            SyncGUI ui = new SyncGUI(FemapModel);
            try
            {
                constraint.SetConstraints(TitleBox.Text, TX.Checked, TY.Checked, TZ.Checked, RX.Checked, RY.Checked, RZ.Checked);
                SQLControl(TitleBox.Text, constraint.SurfaseList(), TX.Checked, TY.Checked, TZ.Checked, RX.Checked, RY.Checked, RZ.Checked);
                Close();
            }
            catch (Exception) { }
        }

        private async void SQLControl(string Title, List<double> SurfaceId, bool tX, bool tY, bool tZ, bool rX, bool rY, bool rZ)
        {
            DBController db = new DBController();
            await Task.Run(() => db.AddContraintAsync(Title, SurfaceId, tX, tY, tZ, rX, rY, rZ));
        }

        private void ConstraintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnalysisForm form = new AnalysisForm(FemapModel);
            form.Show();
        }
    }
}
