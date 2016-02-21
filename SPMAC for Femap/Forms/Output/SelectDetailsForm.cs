using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;
using SPMAC_for_Femap.Classes.DB;
using SPMAC_for_Femap.Classes.DB.Model;
using SPMAC_for_Femap.Properties;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SPMAC_for_Femap.Forms.Output
{
    public partial class SelectDetailsForm : RadForm
    {
        private readonly DBServerContext db = new DBServerContext();
        private readonly List<DetailList> detailsList = new List<DetailList>();

        public SelectDetailsForm()
        {
            InitializeComponent();
            comboDetailSet.DataSource = db.DETAILS.Select(s => s.Name).ToList();
            comboDetailSet_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private bool CompareBitmaps(Bitmap left, Bitmap right)
        {
            for (int col = 0; col < left.Width; col++)
            {
                for (int row = 0; row < left.Height; row++)
                {
                    if (!left.GetPixel(col, row).Equals(right.GetPixel(col, row)))
                        return false;
                }
            }
            return true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (CompareBitmaps(Resources.DETAIL, (Bitmap)selectList.SelectedItem.Image)) return;

            bool isFinded = false;
            if (detailsList.Count == 0)
                detailsList.Add(new DetailList
                {
                    ID = comboDetailSet.SelectedIndex + 1,
                    DetailName = selectList.SelectedItem.Text
                });
            else
                for (int i = 0; i < detailsList.Count; i++)
                    if (detailsList[i].DetailName == selectList.SelectedItem.Text &
                        detailsList[i].ID == (comboDetailSet.SelectedIndex + 1) & !isFinded)
                        isFinded = true;

            if (detailsList.Count > 0)
                for (var i = 0; i < detailsList.Count; i++)
                {
                    if (detailsList[i].DetailName == selectList.SelectedItem.Text &
                        detailsList[i].ID != (comboDetailSet.SelectedIndex + 1) & !isFinded)
                    {
                        detailsList.Add(new DetailList
                        {
                            ID = comboDetailSet.SelectedIndex + 1,
                            DetailName = selectList.SelectedItem.Text
                        });
                        break;
                    }
                }
            selectedGrid.DataSource = null;
            selectedGrid.DataSource = detailsList;
            selectedGrid.Columns[0].Width = 25;
            selectedGrid.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            selectedGrid.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
        }

        private void comboDetailSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectList.DataSource = null;
            selectList.DataSource = db.CREATEDETAILS.Where(w => w.DetailsSet.Name == comboDetailSet.Text).Select(s => s.DetailsList).ToArray();

            foreach (var item in selectList.Items)
            {
                db.ANALYSIS.Load();
                foreach (var detail in db.CREATEDETAILS
                    .Where(w => w.DetailsSet.Name == comboDetailSet.Text)
                    .Where(wh => wh.DetailsList == item.Text))
                    item.Image = detail.Analysis != null ? Resources.DETAILWITHANALYSIS : Resources.DETAIL;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            selectedGrid.Rows.Remove(selectedGrid.CurrentRow);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (detailsList.Count > 0)
            {
                new BestResultForm(detailsList).Show();
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public class DetailList
        {
            public int ID { get; set; }
            public string DetailName { get; set; }
        }
    }
}
