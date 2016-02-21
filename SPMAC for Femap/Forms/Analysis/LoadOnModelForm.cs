using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using femap;
using Telerik.WinControls.UI;
using SPMAC_for_Femap.Classes;
using SPMAC_for_Femap.Classes.DB;

namespace SPMAC_for_Femap.Forms.Analysis
{
    public partial class LoadOnModelForm : RadForm
    {
        private readonly model FemapModel;
        private zLoadType loadType;

        public LoadOnModelForm(model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
            List<ItemsLoadTypes> List = new List<ItemsLoadTypes>();
            List.Add(new ItemsLoadTypes("Давление (Нормаль)"));
            List.Add(new ItemsLoadTypes("Сила (Вектор)"));
            TypeComboBox.DataSource = List;
            UpdateCombo();
        }

        [DataObject(true)]
        private class ItemsLoadTypes
        {
            public string TypeName { get; set; }

            public ItemsLoadTypes(string TypeName)
            {
                this.TypeName = TypeName;
            }
        }

        private void UpdateCombo()
        {
            if (TypeComboBox.Text == "Давление (Нормаль)")
            {
                loadType = zLoadType.FLT_SEPRESSURE;
                ValueBox.Visible = true; ValueLabel.Visible = true;
                XBox.Visible = false; YBox.Visible = false; ZBox.Visible = false;
                ValueXLabel.Visible = false; ValueYLabel.Visible = false; ValueZLabel.Visible = false;
            }
            else if (TypeComboBox.Text == "Сила (Вектор)")
            {
                loadType = zLoadType.FLT_SNFORCE;
                ValueBox.Visible = false; ValueLabel.Visible = false;
                XBox.Visible = true; YBox.Visible = true; ZBox.Visible = true;
                ValueXLabel.Visible = true; ValueYLabel.Visible = true; ValueZLabel.Visible = true;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            UpdateCombo();
            LoadOnModel load = new LoadOnModel(FemapModel);
            SyncGUI ui = new SyncGUI(FemapModel);
            try
            {
                load.Set_Load(TitleBox.Text, ui.DParse(ValueBox),
                    loadType, TypeComboBox.Text == "Давление (Нормаль)" ? ui.DParse(ValueBox) : ui.DParse(XBox),
                    ui.DParse(YBox), ui.DParse(ZBox));
                SQLControl(TitleBox.Text, load.SurfaseList(), ui.DParse(ValueBox), loadType, ui.DParse(XBox), ui.DParse(YBox), ui.DParse(ZBox));
                Close();
            }
            catch (Exception) { }
        }

        private async void SQLControl(string Title, List<double> SurfaceId, double Value, zLoadType LoadType, double X, double Y, double Z)
        {
            DBController db = new DBController();
            await Task.Run(() => db.AddLoadAsync(Title, SurfaceId, Value, LoadType, X, Y, Z));
        }

        private void LoadOnModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnalysisForm form = new AnalysisForm(FemapModel);
            form.Show();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCombo();
        }
    }
}
