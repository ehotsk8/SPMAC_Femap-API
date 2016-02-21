using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
    public partial class MaterialPropertyForm : RadForm
    {
        private readonly model FemapModel;
        private MaterialProperties prop;
        private List<Matl> materials = new List<Matl>();
        private List<ListData> titlesList = new List<ListData>();

        public MaterialPropertyForm(model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
            Check();
            prop = new MaterialProperties(FemapModel);
            materials = prop.GetMatLibrary();
            foreach (var title in materials.Select(s => s.title))
                titlesList.Add(new ListData(title));

            materialLibraryComboBox.DataSource = titlesList;
        }

        [DataObject(true)]
        private class ListData
        {
            public string Name { get; set; }
            public ListData(string Name) { this.Name = Name; }
        }

        private void Check()
        {
            if (Auto.IsChecked)
            {
                TitleBox.Enabled = false;
                TitleLabel.Enabled = false;
                radGroupBox1.Enabled = false;
                materialLibraryComboBox.Enabled = true;
            }
            else if (Manual.IsChecked)
            {
                TitleBox.Enabled = true;
                TitleLabel.Enabled = true;
                radGroupBox1.Enabled = true;
                materialLibraryComboBox.Enabled = false;
            }
        }

        private async void SQLControl(string Title, double E, double G, double Nu)
        {
            DBController db = new DBController();
            await Task.Run(() => db.AddMaterialAsync(Title, E, G, Nu));
        }

        private void CreateMaterial_Click(object sender, EventArgs e)
        {
            prop = new MaterialProperties(FemapModel);
            SyncGUI ui = new SyncGUI(FemapModel);
            try
            {
                if (Auto.IsChecked)
                {
                    materials.First(w => w.title == materialLibraryComboBox.Text).Put(FemapModel.feMatl.CountSet() + 1);
                    FemapModel.feView.Regenerate();
                    SQLControl(materialLibraryComboBox.Text,
                        materials.First(w => w.title == materialLibraryComboBox.Text).Ex,
                        materials.First(w => w.title == materialLibraryComboBox.Text).Gx,
                        materials.First(w => w.title == materialLibraryComboBox.Text).Nuxy);
                }
                else if (Manual.IsChecked)
                {
                    prop.SetManualMaterial(TitleBox.Text, ui.DParse(EBox), ui.DParse(GBox), ui.DParse(NuBox));
                    SQLControl(TitleBox.Text, ui.DParse(EBox), ui.DParse(GBox), ui.DParse(NuBox));
                }
                Close();
            }
            catch (Exception) { }
        }

        private void MaterialPropertyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnalysisForm form = new AnalysisForm(FemapModel);
            form.Show();
        }

        private void Auto_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            Check();
        }

        private void Manual_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            Check();
        }
    }
}
