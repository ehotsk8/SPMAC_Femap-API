﻿using System;
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

namespace SPMAC_for_Femap.Forms
{
    public partial class PistonFingerForm : Form
    {
        readonly femap.model FemapModel;

        public PistonFingerForm(femap.model FemapModel)
        {
            InitializeComponent();
            this.FemapModel = FemapModel;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            MakeDetails mcd = new MakeDetails(FemapModel);
            if (Status.createStatusStr == "Готово") { Task.Run((Action)mcd.Create_PistonFinger); Thread.Sleep(500); }
            else { MessageBox.Show("Подождите завершение фоновой операции.."); Status.createStatusStr = "Подождите.."; }
        }
    }
}
