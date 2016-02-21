namespace SPMAC_for_Femap.Forms.Output
{
    partial class SelectDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.StatusImage = new Telerik.WinControls.UI.RadImageButtonElement();
            this.StatusLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.addButton = new Telerik.WinControls.UI.RadButton();
            this.removeButton = new Telerik.WinControls.UI.RadButton();
            this.okButton = new Telerik.WinControls.UI.RadButton();
            this.cancelButton = new Telerik.WinControls.UI.RadButton();
            this.selectedGrid = new Telerik.WinControls.UI.RadGridView();
            this.comboDetailSet = new System.Windows.Forms.ComboBox();
            this.selectList = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGrid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StatusImage,
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 334);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(552, 33);
            this.statusStrip.TabIndex = 19;
            this.statusStrip.Text = "radStatusStrip1";
            this.statusStrip.ThemeName = "Office2013Dark";
            // 
            // StatusImage
            // 
            this.StatusImage.AccessibleDescription = "radImageButtonElement1";
            this.StatusImage.AccessibleName = "radImageButtonElement1";
            this.StatusImage.AutoSize = false;
            this.StatusImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.StatusImage.Bounds = new System.Drawing.Rectangle(0, 0, 25, 25);
            this.StatusImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StatusImage.Image = global::SPMAC_for_Femap.Properties.Resources.OK;
            this.StatusImage.ImageIndexClicked = 0;
            this.StatusImage.ImageIndexHovered = 0;
            this.StatusImage.Name = "StatusImage";
            this.StatusImage.ScaleTransform = new System.Drawing.SizeF(1F, 1F);
            this.statusStrip.SetSpring(this.StatusImage, false);
            this.StatusImage.Text = "radImageButtonElement1";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.StatusImage.GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.StatusImage.GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.StatusImage.GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.StatusImage.GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.StatusImage.GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.StatusImage.GetChildAt(0))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.StatusImage.GetChildAt(0))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.StatusImage.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AccessibleDescription = "Готово";
            this.StatusLabel.AccessibleName = "Готово";
            this.StatusLabel.Name = "StatusLabel";
            this.statusStrip.SetSpring(this.StatusLabel, false);
            this.StatusLabel.Text = "Готово";
            this.StatusLabel.TextWrap = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(259, 141);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(34, 34);
            this.addButton.TabIndex = 22;
            this.addButton.Text = ">";
            this.addButton.ThemeName = "Office2013Dark";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(259, 181);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(34, 34);
            this.removeButton.TabIndex = 23;
            this.removeButton.Text = "<";
            this.removeButton.ThemeName = "Office2013Dark";
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.okButton.Location = new System.Drawing.Point(12, 274);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(141, 34);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "ОК";
            this.okButton.ThemeName = "Office2013Dark";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelButton.Location = new System.Drawing.Point(159, 275);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 34);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.ThemeName = "Office2013Dark";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectedGrid
            // 
            this.selectedGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.selectedGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectedGrid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.selectedGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectedGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selectedGrid.Location = new System.Drawing.Point(299, 12);
            // 
            // selectedGrid
            // 
            this.selectedGrid.MasterTemplate.AllowColumnChooser = false;
            this.selectedGrid.MasterTemplate.AllowColumnReorder = false;
            this.selectedGrid.MasterTemplate.AllowDragToGroup = false;
            this.selectedGrid.MasterTemplate.AllowRowResize = false;
            this.selectedGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.selectedGrid.MasterTemplate.EnableGrouping = false;
            this.selectedGrid.MasterTemplate.EnableSorting = false;
            this.selectedGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.selectedGrid.Name = "selectedGrid";
            this.selectedGrid.ReadOnly = true;
            this.selectedGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectedGrid.ShowGroupPanel = false;
            this.selectedGrid.Size = new System.Drawing.Size(240, 296);
            this.selectedGrid.TabIndex = 27;
            this.selectedGrid.Text = "radGridView2";
            this.selectedGrid.ThemeName = "Office2013Dark";
            // 
            // comboDetailSet
            // 
            this.comboDetailSet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboDetailSet.FormattingEnabled = true;
            this.comboDetailSet.Location = new System.Drawing.Point(12, 12);
            this.comboDetailSet.Name = "comboDetailSet";
            this.comboDetailSet.Size = new System.Drawing.Size(241, 21);
            this.comboDetailSet.TabIndex = 28;
            this.comboDetailSet.SelectedIndexChanged += new System.EventHandler(this.comboDetailSet_SelectedIndexChanged);
            // 
            // selectList
            // 
            this.selectList.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.selectList.ItemHeight = 30;
            this.selectList.Location = new System.Drawing.Point(12, 39);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(241, 229);
            this.selectList.TabIndex = 29;
            this.selectList.Text = "radListControl1";
            this.selectList.ThemeName = "Office2013Dark";
            // 
            // SelectDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 367);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.comboDetailSet);
            this.Controls.Add(this.selectedGrid);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDetailsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите детали";
            this.ThemeName = "Office2013Dark";
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadImageButtonElement StatusImage;
        private Telerik.WinControls.UI.RadLabelElement StatusLabel;
        private Telerik.WinControls.UI.RadButton addButton;
        private Telerik.WinControls.UI.RadButton removeButton;
        private Telerik.WinControls.UI.RadButton okButton;
        private Telerik.WinControls.UI.RadButton cancelButton;
        private Telerik.WinControls.UI.RadGridView selectedGrid;
        private System.Windows.Forms.ComboBox comboDetailSet;
        private Telerik.WinControls.UI.RadListControl selectList;
    }
}
