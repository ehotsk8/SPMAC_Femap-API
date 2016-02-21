using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SPMAC_for_Femap.Classes;
using SPMAC_for_Femap.Properties;

namespace SPMAC_for_Femap
{
    public partial class ParamConnectingRodForm : Form
    {
        private readonly femap.model FemapModel;
        private int xPos = 0, yPos = 0;

        public ParamConnectingRodForm(femap.model FemapModel)
        {
            InitializeComponent();
            Status.boolStatus = -1;
            this.FemapModel = FemapModel;
            timer1.Start();
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = Status.progressValue;
            StatusLabel.Text = Status.createStatusStr;
            if (StatusLabel.Text == "Готово")
            {         
                StatusLabel.Image = Resources.OK;
            }
            if (StatusLabel.Text == "Построение детали")
            {
                StatusLabel.Image = Resources.WARNING;
            }
            if (Status.boolStatus != -1)
            {
                StatusLabel.Image = Resources.FALL;
            }
            StatusLabel.Text += " " + Status.boolStatus;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Sizes.d1 = Convert.ToDouble(d1.Text);
            Sizes.d2 = Convert.ToDouble(d2.Text);
            Sizes.h1 = Convert.ToDouble(h1.Text);
            Sizes.l1 = Convert.ToDouble(l1.Text);
            Sizes.l2 = Convert.ToDouble(l2.Text);
            Sizes.l3 = Convert.ToDouble(l3.Text);
            Sizes.b1 = Convert.ToDouble(b1.Text);
            Sizes.b2 = Convert.ToDouble(b2.Text);
            Sizes.h2 = Convert.ToDouble(h2.Text);
            Sizes.d3 = Convert.ToDouble(d3.Text);
            Sizes.b3 = Convert.ToDouble(b3.Text);
            Sizes.h3 = Convert.ToDouble(h3.Text);
            Sizes.r1 = Convert.ToDouble(r1.Text);
            Sizes.l4 = Convert.ToDouble(l4.Text);
            Sizes.r2 = Convert.ToDouble(r2.Text);
            Sizes.r3 = Convert.ToDouble(r3.Text);
            Sizes.l5 = Convert.ToDouble(l5.Text);
            Sizes.l6 = Convert.ToDouble(l6.Text);
            Sizes.r4 = Convert.ToDouble(r4.Text);
            Sizes.r5 = Convert.ToDouble(r5.Text);
            Sizes.b4 = Convert.ToDouble(b4.Text);
            Sizes.l7 = Convert.ToDouble(l7.Text);
            Sizes.l8 = Convert.ToDouble(l8.Text);
            Sizes.b5 = Convert.ToDouble(b5.Text);
            Sizes.l9 = Convert.ToDouble(l9.Text);
            Sizes.b6 = Convert.ToDouble(b6.Text);
            Sizes.b7 = Convert.ToDouble(b7.Text);
            Sizes.d4 = Convert.ToDouble(d4.Text);
            Sizes.r6 = Convert.ToDouble(r6.Text);
            Sizes.r7 = Convert.ToDouble(r7.Text);
            Sizes.r8 = Convert.ToDouble(r8.Text);
            Sizes.r9 = Convert.ToDouble(r9.Text);
            Sizes.r10 = Convert.ToDouble(r10.Text);
            Sizes.r11 = Convert.ToDouble(r11.Text);
            Sizes.r12 = Convert.ToDouble(r12.Text);
            Sizes.r13 = Convert.ToDouble(r13.Text);

            if (Status.createStatusStr == "Готово") { Task.Run((Action)new MakeDetails(FemapModel).Create_Connecting_Rod); Thread.Sleep(500); }
            else { MessageBox.Show("Подождите завершение фоновой операции.."); Status.createStatusStr = "Подождите.."; }
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
            pictureBox1.Size = new System.Drawing.Size(642, 432);
            xPos = e.X; yPos = e.Y;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateBtn_Click(sender, e);
        }
    }
}
