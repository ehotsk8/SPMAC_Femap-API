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
using SPMAC_for_Femap.Classes;
using SPMAC_for_Femap.Classes.DB;
using SPMAC_for_Femap.Classes.DB.Model;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SPMAC_for_Femap.Forms.Output
{
    public partial class BestResultForm : Telerik.WinControls.UI.RadForm
    {
        private List<SelectDetailsForm.DetailList> detailsList;
        private List<DBDetailsSet.DBDetail_Created> details = new List<DBDetailsSet.DBDetail_Created>();
        private List<DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaxMinStress> MaxMin = new List<DBDetailsSet.DBDetail_Created.DBAnalysis.DBMaxMinStress>();
        private DBDetailsSet.DBDetail_Created createdDetail;

        public BestResultForm(List<SelectDetailsForm.DetailList> detailsList)
        {
            InitializeComponent();
            this.detailsList = detailsList;
            createdDetail = FindBestResult();
            ChartControll();
            FillInfoGroup();
        }

        private void FillInfoGroup()
        {
            using (var db = new DBServerContext())
            {
                nameTextBox.Text = createdDetail.DetailsList;
                idTextBox.Text = createdDetail.Detail_CreatedId.ToString();
                dataSetTextBox.Text = db.CREATEDETAILS.First(f => f.Detail_CreatedId == createdDetail.Detail_CreatedId).DetailsSet.Name;
            }
        }

        private DBDetailsSet.DBDetail_Created FindBestResult()
        {
            using (var db = new DBServerContext())
            {
                foreach (var detail in detailsList)
                {
                    var findDetail = db.CREATEDETAILS.Where(f => f.DetailsList == detail.DetailName)
                         .First(w => w.DetailsSet.DetailsSetId == detail.ID);
                    var maxMin = db.MAXMINSTRESS.First(f => f.Analysis.AnalysisId == findDetail.Analysis.AnalysisId);
                    details.Add(findDetail);
                    MaxMin.Add(maxMin);
                }
                var minValue = MaxMin.Select(s => s.Max).Min();
                var BestResult = MaxMin.First(f => f.Max == minValue);
                return db.CREATEDETAILS.First(f => f.Analysis.AnalysisId == BestResult.Analysis.AnalysisId);
            }
        }

        private void ChartControll()
        {
            var seriesMaxStress = new BarSeries();
            var seriesMinStress = new BarSeries();

            using (var db = new DBServerContext())
            {
                var pointsMax = new List<DataPoint>();
                var pointsMin = new List<DataPoint>();

                foreach (var stress in detailsList)
                {
                    var detail = db.CREATEDETAILS.Where(f => f.DetailsList == stress.DetailName)
                         .First(w => w.DetailsSet.DetailsSetId == stress.ID);
                    var maxMin = db.MAXMINSTRESS.First(f => f.Analysis.AnalysisId == detail.Analysis.AnalysisId);

                    pointsMax.Add(new CategoricalDataPoint(Math.Round(maxMin.Max), String.Format("ID: {0}\n{1}",
                        detail.Detail_CreatedId, detail.DetailsList)));
                    pointsMin.Add(new CategoricalDataPoint(Math.Round(maxMin.Min), String.Format("ID: {0}\n{1}",
                        detail.Detail_CreatedId, detail.DetailsList)));
                }
                seriesMaxStress.DataPoints.AddRange(pointsMax);
                seriesMaxStress.ShowLabels = true;
                seriesMinStress.DataPoints.AddRange(pointsMin);
                seriesMinStress.ShowLabels = true;
            }
            chartResults.View.Series.Add(seriesMaxStress);
            chartResults.View.Series.Add(seriesMinStress);
        }

        private int DetailSetId()
        {
            using (var db = new DBServerContext())
            {
                return db.CREATEDETAILS.First(f => f.Detail_CreatedId == createdDetail.Detail_CreatedId).DetailsSet.DetailsSetId;
            }
        }

        private void TextAlignment()
        {
            grid.Columns[grid.Columns.Count - 1].IsVisible = false;
            foreach (var VARIABLE in grid.Columns)
                VARIABLE.TextAlignment = ContentAlignment.MiddleCenter;
        }

        private void SizesCommand_Click(object sender, EventArgs e)
        {
            using (var db = new DBServerContext())
            {
                grid.DataSource = null;
                var ID = DetailSetId();
                switch (createdDetail.DetailsList)
                {
                    case "Поршень":
                        grid.DataSource = db.PISTON.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        break;
                    case "Шатун":
                        grid.DataSource = db.ROD.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        break;
                    case "Крышка шатуна":
                        grid.DataSource = db.COVERROD.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        break;
                    case "Поршневой палец":
                        grid.DataSource = db.FINGER.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        break;
                    case "Коленчатый вал":
                        grid.DataSource = db.CRANKSHAFT.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        break;
                    case "Гильза цилиндра":
                        grid.DataSource = db.SLEEVECYLINDER.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        break;
                }
                grid.Columns[0].HeaderText = "Идентификатор";
                grid.Columns[1].HeaderText = "Размер";
                grid.Columns[2].HeaderText = "Значение";
                grid.Columns[3].IsVisible = false;
                TextAlignment();
                NowTextBox.Text = "РАЗМЕРЫ";
            }
        }

        private void MaterialCommand_Click(object sender, EventArgs e)
        {
            using (var db = new DBServerContext())
            {
                grid.DataSource = null;
                var analysisId = db.CREATEDETAILS.First(f => f.DetailsList == createdDetail.DetailsList).Analysis.AnalysisId;
                grid.DataSource = db.MATERIALS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                TextAlignment();
                NowTextBox.Text = "МАТЕРИАЛЫ";
            }
        }

        private void LoadCommand_Click(object sender, EventArgs e)
        {
            using (var db = new DBServerContext())
            {
                grid.DataSource = null;
                var analysisId = db.CREATEDETAILS.First(f => f.DetailsList == createdDetail.DetailsList).Analysis.AnalysisId;
                grid.DataSource = db.LOADS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                TextAlignment();
                NowTextBox.Text = "НАГРУЗКИ";
            }
        }

        private void ConstraintCommand_Click(object sender, EventArgs e)
        {
            using (var db = new DBServerContext())
            {
                grid.DataSource = null;
                var analysisId = db.CREATEDETAILS.First(f => f.DetailsList == createdDetail.DetailsList).Analysis.AnalysisId;
                grid.DataSource = db.CONTRAINTS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                TextAlignment();
                NowTextBox.Text = "ГРАНИЧНЫЕ УСЛОВИЯ";
            }
        }

        private void ResultCommand_Click(object sender, EventArgs e)
        {
            using (var db = new DBServerContext())
            {
                grid.DataSource = null;
                var analysisId = db.CREATEDETAILS.First(f => f.DetailsList == createdDetail.DetailsList).Analysis.AnalysisId;
                grid.DataSource = db.RESULTS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                TextAlignment();
                NowTextBox.Text = "РЕЗУЛЬТАТЫ";
            }
        }

        private void PropertyCommand_Click(object sender, EventArgs e)
        {
            using (var db = new DBServerContext())
            {
                grid.DataSource = null;
                var analysisId = db.CREATEDETAILS.First(f => f.DetailsList == createdDetail.DetailsList).Analysis.AnalysisId;
                grid.DataSource = db.PROPERTYANDMESHES.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                TextAlignment();
                NowTextBox.Text = "СВОЙСТВА КЭ";
            }
        }

        private void OutputInWORDButton_Click(object sender, EventArgs e)
        {
            using (var db = new DBServerContext())
            {
                var analysisId = db.CREATEDETAILS.First(f => f.DetailsList == createdDetail.DetailsList).Analysis.AnalysisId;

                var properties = db.PROPERTYANDMESHES.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                var results = db.RESULTS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                var constraints = db.CONTRAINTS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                var loads = db.LOADS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                var materials = db.MATERIALS.Where(w => w.Analysis.AnalysisId == analysisId).ToList();
                var maxMinStresses = db.MAXMINSTRESS.Where(f => f.Analysis.AnalysisId == analysisId).ToList();
                var maxMinTranslates = db.MAXMINTRANSLATE.Where(f => f.Analysis.AnalysisId == analysisId).ToList();

                var ID = DetailSetId();
                var pistons = new List<DBDetailsSet.DBPiston>(3);
                var rods = new List<DBDetailsSet.DBRod>(3);
                var coverRods = new List<DBDetailsSet.DBCoverRod>(3);
                var fingers = new List<DBDetailsSet.DBFinger>(3);
                var crankshafts = new List<DBDetailsSet.DBCrankshaft>(3);
                var cylinders = new List<DBDetailsSet.DBSleeveCylinder>(3);
                var output = new OutputDataToWord();
                switch (createdDetail.DetailsList)
                {
                    case "Поршень":
                        pistons = db.PISTON.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        Task.Run(() => output.CreateWordAsync(createdDetail.Detail_CreatedId, createdDetail.DetailsList,
                            DetailSetId(), pistons, materials, loads, constraints, maxMinStresses, maxMinTranslates, properties,
                            results));
                        break;
                    case "Шатун":
                        rods = db.ROD.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        Task.Run(() => output.CreateWordAsync(createdDetail.Detail_CreatedId, createdDetail.DetailsList,
                            DetailSetId(), rods, materials, loads, constraints, maxMinStresses, maxMinTranslates, properties,
                            results));
                        break;
                    case "Крышка шатуна":
                        coverRods = db.COVERROD.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        Task.Run(() => output.CreateWordAsync(createdDetail.Detail_CreatedId, createdDetail.DetailsList,
                            DetailSetId(), coverRods, materials, loads, constraints, maxMinStresses, maxMinTranslates, properties,
                            results));
                        break;
                    case "Поршневой палец":
                        fingers = db.FINGER.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        Task.Run(() => output.CreateWordAsync(createdDetail.Detail_CreatedId, createdDetail.DetailsList,
                            DetailSetId(), fingers, materials, loads, constraints, maxMinStresses, maxMinTranslates, properties,
                            results));
                        break;
                    case "Коленчатый вал":
                        crankshafts = db.CRANKSHAFT.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        Task.Run(() => output.CreateWordAsync(createdDetail.Detail_CreatedId, createdDetail.DetailsList,
                            DetailSetId(), crankshafts, materials, loads, constraints, maxMinStresses, maxMinTranslates, properties,
                            results));
                        break;
                    case "Гильза цилиндра":
                        cylinders = db.SLEEVECYLINDER.Where(w => w.DetailsSet.DetailsSetId == ID).ToList();
                        Task.Run(() => output.CreateWordAsync(createdDetail.Detail_CreatedId, createdDetail.DetailsList,
                            DetailSetId(), cylinders, materials, loads, constraints, maxMinStresses,
                            maxMinTranslates, properties,
                            results));
                        break;
                }
            }
        }
    }
}
