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
using SPMAC_for_Femap.Classes;
using SPMAC_for_Femap.Classes.DB;
using Telerik.WinControls.UI;

namespace SPMAC_for_Femap.Forms.Analysis
{
    public partial class FEAForm : RadForm
    {
        private readonly model FemapModel;
        private int MaterialID;
        private int CountMaterials;
        private object MaterialsIDs;
        private object MaterialsTitles;

        private int PropertyID;
        private int CountOfProperties;
        private object PropertyIDs;
        private object PropertyTitles;

        public FEAForm(model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
            newPropertyRadioButton.IsChecked = true;
            propertyComboBox.Enabled = false;

            Matl materials = FemapModel.feMatl;
            materials.GetTitleList(1, FemapModel.feMatl.CountSet(),
                out CountMaterials, out MaterialsIDs, out MaterialsTitles);

            List<ListData> materialList = new List<ListData>();
            if (CountMaterials > 0)
            {
                for (int i = 0; i < ((string[])MaterialsTitles).Length; i++)
                    materialList.Add(new ListData(((string[])MaterialsTitles)[i]));
                MaterialComboBox.DataSource = materialList;
                UpdateCombo(CountMaterials, (string[])MaterialsTitles, (int[])MaterialsIDs);
            }

            Prop properties = FemapModel.feProp;
            properties.GetTitleList(1, FemapModel.feProp.CountSet(),
                out CountOfProperties, out PropertyIDs, out PropertyTitles);

            List<ListData> propertyList = new List<ListData>();
            if (CountOfProperties > 0)
            {
                for (int i = 0; i < ((string[])PropertyTitles).Length; i++)
                    propertyList.Add(new ListData(((string[])PropertyTitles)[i]));
                propertyComboBox.DataSource = propertyList;
                UpdateCombo(CountOfProperties, (string[])PropertyTitles, (int[])PropertyIDs);
                listOfPropertyRadioButton.IsChecked = true;
                TitleBox.Enabled = false;
                propertyComboBox.Enabled = true;
            }
        }

        [DataObject(true)]
        private class ListData
        {
            public string Name { get; set; }
            public ListData(string Name) { this.Name = Name; }
        }

        private void UpdateCombo(int Count, string[] Names, int[] IDs)
        {
            for (int i = 0; i < Count; i++)
                if (MaterialComboBox.Text == Names[i])
                    MaterialID = IDs[i];
        }

        private void UpdateComboProp(int Count, string[] Names, int[] IDs)
        {
            for (int i = 0; i < Count; i++)
                if (propertyComboBox.Text == Names[i])
                    PropertyID = IDs[i];
        }

        private void CreateFEA_Click(object sender, EventArgs e)
        {
            ObjectProperties properties = new ObjectProperties(FemapModel);
            MeshingObject mesh = new MeshingObject(FemapModel);
            SyncGUI ui = new SyncGUI(FemapModel);
            try
            {
                if (CountMaterials > 0)
                {
                    UpdateCombo(CountMaterials, (string[])MaterialsTitles, (int[])MaterialsIDs);
                    if (newPropertyRadioButton.IsChecked)
                    {
                        properties.SetManualProperty(TitleBox.Text, MaterialID);
                        if (mesh.SetMesh(properties.GetPropID(), ui.DParse(FEAValue)) == zReturnCode.FE_OK)
                            SQLControl(TitleBox.Text, ui.DParse(FEAValue), properties.GetPropID());
                    }
                    else if (CountOfProperties > 0)
                    {
                        UpdateComboProp(CountOfProperties, (string[])PropertyTitles, (int[])PropertyIDs);
                        properties.SetPropertyFromList(PropertyID);
                        if (mesh.SetMesh(properties.GetPropID(), ui.DParse(FEAValue)) == zReturnCode.FE_OK)
                            SQLControl(propertyComboBox.Text, ui.DParse(FEAValue), properties.GetPropID());
                    }
                }
                Close();
            }
            catch (Exception) { }
        }

        private async void SQLControl(string Title, double MeshSize, int PropertyId)
        {
            DBController db = new DBController();
            await Task.Run(() => db.AddMeshAsync(Title, MeshSize, PropertyId));
        }

        private void FEAForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnalysisForm form = new AnalysisForm(FemapModel);
            form.Show();
        }

        private void newPropertyRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            TitleBox.Enabled = true;
            propertyComboBox.Enabled = false;
        }

        private void listOfPropertyRadioButton_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            TitleBox.Enabled = false;
            propertyComboBox.Enabled = true;
        }
    }
}
