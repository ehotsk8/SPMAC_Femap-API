using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SPMAC_for_Femap.Classes.DB;
using SPMAC_for_Femap.Classes.DB.Model;
using SPMAC_for_Femap.Properties;
using Telerik.WinControls.UI;
using SPMAC_for_Femap.Classes;
using Telerik.WinControls;

namespace SPMAC_for_Femap.Forms.Output
{
    public partial class OutputForm : RadForm
    {
        private readonly DBServerContext db = new DBServerContext();
        private readonly ImageList list;
        private int Value, Value2;
        public OutputForm()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            list = new ImageList();
            list.Images.Add("0", Resources.ASSEMBLY);
            list.Images.Add("1", Resources.DETAIL);
            list.Images.Add("2", Resources.MATERIAL);
            list.Images.Add("3", Resources.MATERIALITEM);
            list.Images.Add("4", Resources.ANALYSIS);
            list.Images.Add("5", Resources.ANALYSISITEM);
            list.Images.Add("6", Resources.LOAD);
            list.Images.Add("7", Resources.LOADITEM);
            list.Images.Add("8", Resources.CONSTRAINT);
            list.Images.Add("9", Resources.CONSTRAINTITEM);
            list.Images.Add("10", Resources.PROPERTY);
            list.Images.Add("11", Resources.PROPERTYITEM);
            list.Images.Add("11", Resources.DETAILWITHANALYSIS);
            RefreshCommand_Click(this, EventArgs.Empty);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            StatusImage.Image = Status.ImageState;
            if (Status.CurrState == Status.CurrentState.ANALYSIS || Status.CurrState == Status.CurrentState.WAIT)
            {
                progressBar1.ProgressOrientation = ProgressOrientation.Top;
                progressBar1.Value1 = Value += 20;
            }
            else
            {
                progressBar1.ProgressOrientation = ProgressOrientation.Left;
                progressBar1.Value1 = Status.ProgressValue;
            }
            StatusLabel.Text = Status.CurrentStatusString;
            if (Value >= 100) Value = 0;
        }

        private void ChangeSelect(int id, string detailName)
        {
            if (id > 0)
            {
                grid1.DataSource = null;
                switch (detailName)
                {
                    case "Поршень":
                        grid1.DataSource = db.PISTON.Where(w => w.DetailsSet.DetailsSetId == id).ToList();
                        break;
                    case "Шатун":
                        grid1.DataSource = db.ROD.Where(w => w.DetailsSet.DetailsSetId == id).ToList();
                        break;
                    case "Крышка шатуна":
                        grid1.DataSource = db.COVERROD.Where(w => w.DetailsSet.DetailsSetId == id).ToList();
                        break;
                    case "Поршневой палец":
                        grid1.DataSource = db.FINGER.Where(w => w.DetailsSet.DetailsSetId == id).ToList();
                        break;
                    case "Коленчатый вал":
                        grid1.DataSource = db.CRANKSHAFT.Where(w => w.DetailsSet.DetailsSetId == id).ToList();
                        break;
                    case "Гильза цилиндра":
                        grid1.DataSource = db.SLEEVECYLINDER.Where(w => w.DetailsSet.DetailsSetId == id).ToList();
                        break;
                }
                grid1.Columns[0].HeaderText = "Идентификатор";
                grid1.Columns[1].HeaderText = "Размер";
                grid1.Columns[2].HeaderText = "Значение";
                grid1.Columns[3].IsVisible = false;
                foreach (var VARIABLE in grid1.Columns)
                    VARIABLE.TextAlignment = ContentAlignment.MiddleCenter;

                RefreshTree();

                if (db.CREATEDETAILS.First(f => f.DetailsList == detailName).Analysis != null)
                {
                    int analysisId = db.CREATEDETAILS.First(f => f.DetailsList == detailName).Analysis.AnalysisId;
                    foreach (var material in db.MATERIALS.Where(w => w.Analysis.AnalysisId == analysisId).Select(s => s.Title))
                        radTreeView1.Nodes[0].Nodes.Add(material);
                    foreach (var load in db.LOADS.Where(w => w.Analysis.AnalysisId == analysisId).Select(s => s.Title))
                        radTreeView1.Nodes[1].Nodes.Add(load);
                    foreach (var constraint in db.CONTRAINTS.Where(w => w.Analysis.AnalysisId == analysisId).Select(s => s.Title))
                        radTreeView1.Nodes[2].Nodes.Add(constraint);
                    foreach (var prop in db.PROPERTYANDMESHES.Where(w => w.Analysis.AnalysisId == analysisId).Select(s => s.Title))
                        radTreeView1.Nodes[3].Nodes.Add(prop);
                    radTreeView1.Nodes[4].Nodes.Add(db.RESULTS.First().Title);

                    foreach (RadTreeNode node in radTreeView1.Nodes[0].Nodes)
                        node.ImageIndex = 3;
                    foreach (RadTreeNode node in radTreeView1.Nodes[1].Nodes)
                        node.ImageIndex = 7;
                    foreach (RadTreeNode node in radTreeView1.Nodes[2].Nodes)
                        node.ImageIndex = 9;
                    foreach (RadTreeNode node in radTreeView1.Nodes[3].Nodes)
                        node.ImageIndex = 11;
                    foreach (RadTreeNode node in radTreeView1.Nodes[4].Nodes)
                        node.ImageIndex = 5;
                }
            }
        }

        private void AllDataBar_Click(object sender, EventArgs e)
        {
            treeView.ExpandAll();
        }

        private void treeView_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            string DetailName;
            ChangeSelect(GetId(out DetailName), DetailName);
        }

        private void RefreshCommand_Click(object sender, EventArgs e)
        {
            db.CREATEDETAILS.Load();
            treeView.ChildMember = @"DBDetailsSet\DetailCreated";
            treeView.DisplayMember = @"Name\DetailsList";
            treeView.DataSource = db.DETAILS.Select(s => s).ToArray();

            treeView.ImageList = list;
            foreach (RadTreeNode node in treeView.Nodes)
            {
                node.ImageIndex = 0;
                foreach (RadTreeNode node2 in node.Nodes)
                {
                    if (node2.DataBoundItem is DBDetailsSet.DBDetail_Created)
                    {
                        node2.ImageIndex = 1;
                        if (((DBDetailsSet.DBDetail_Created)node2.DataBoundItem).Analysis != null)
                            node2.ImageIndex = 12;
                    }
                }
            }
            RefreshTree();
        }

        private void RefreshTree()
        {
            radTreeView1.ImageList = list;
            radTreeView1.ImageList.ImageSize = new Size(25, 25);
            radTreeView1.Nodes.Clear();
            radTreeView1.Nodes.Add("Материалы");
            radTreeView1.Nodes[0].ImageIndex = 2;
            radTreeView1.Nodes.Add("Нагрузки");
            radTreeView1.Nodes[1].ImageIndex = 6;
            radTreeView1.Nodes.Add("Граничные условия");
            radTreeView1.Nodes[2].ImageIndex = 8;
            radTreeView1.Nodes.Add("Свойства");
            radTreeView1.Nodes[3].ImageIndex = 10;
            radTreeView1.Nodes.Add("Результаты");
            radTreeView1.Nodes[4].ImageIndex = 4;
        }

        private int GetId(out string DetailName)
        {
            int id = -1;
            DetailName = "";
            if (treeView.SelectedNode == null || !(treeView.SelectedNode.DataBoundItem is DBDetailsSet.DBDetail_Created))
                return id;
            id = ((DBDetailsSet.DBDetail_Created)treeView.SelectedNode.DataBoundItem).DetailsSet.DetailsSetId;
            DetailName = treeView.SelectedNode.Text;
            return id;
        }

        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            string DetailName;
            int id = GetId(out DetailName);
            if (id <= 0 || db.CREATEDETAILS.First(f => f.DetailsList == DetailName).Analysis == null) return;

            int analysisId = db.CREATEDETAILS.First(f => f.DetailsList == DetailName).Analysis.AnalysisId;
            if (analysisId < 0) return;
            if (radTreeView1.SelectedNode == null) return;

            var nodeText = radTreeView1.SelectedNode.Text;
            var material = db.MATERIALS.Where(f => f.Title == nodeText).Where(w => w.Analysis.AnalysisId == analysisId);
            var load = db.LOADS.Where(f => f.Title == nodeText).Where(w => w.Analysis.AnalysisId == analysisId);
            var constraint = db.CONTRAINTS.Where(f => f.Title == nodeText).Where(w => w.Analysis.AnalysisId == analysisId);
            var mesh = db.PROPERTYANDMESHES.Where(f => f.Title == nodeText).Where(w => w.Analysis.AnalysisId == analysisId);

            grid1.DataSource = null;
            if (material.Any()) grid1.DataSource = material.ToList();
            if (load.Any()) grid1.DataSource = load.ToList();
            if (constraint.Any()) grid1.DataSource = constraint.ToList();
            if (mesh.Any())
            {
                grid1.DataSource = mesh.ToList();
                grid1.Columns[2].IsVisible = false;
            }
            if (nodeText == "Результат")
            {
                grid1.DataSource = db.RESULTS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                grid1.Columns[0].IsVisible = false;
                grid1.Columns[1].IsVisible = false;
            }
            if (!grid1.Columns.Any()) return;

            grid1.Columns[grid1.Columns.Count - 1].IsVisible = false;
            foreach (var VARIABLE in grid1.Columns)
                VARIABLE.TextAlignment = ContentAlignment.MiddleCenter;
        }

        private void CompareBar_Click(object sender, EventArgs e)
        {
            new SelectDetailsForm().Show();
        }
    }
}
