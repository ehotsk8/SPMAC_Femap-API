namespace SPMAC_for_Femap.Forms.Analysis
{
    partial class MaterialPropertyForm
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
            this.CreateMaterial = new Telerik.WinControls.UI.RadButton();
            this.EBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.NuBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.GBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TitleLabel = new Telerik.WinControls.UI.RadLabel();
            this.TitleBox = new Telerik.WinControls.UI.RadTextBox();
            this.Auto = new Telerik.WinControls.UI.RadRadioButton();
            this.Manual = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.materialLibraryComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.StatusImage = new Telerik.WinControls.UI.RadImageButtonElement();
            this.StatusLabel = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.CreateMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Auto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialLibraryComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialLibraryComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialLibraryComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateMaterial
            // 
            this.CreateMaterial.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.CreateMaterial.Location = new System.Drawing.Point(12, 278);
            this.CreateMaterial.Name = "CreateMaterial";
            this.CreateMaterial.Size = new System.Drawing.Size(268, 41);
            this.CreateMaterial.TabIndex = 0;
            this.CreateMaterial.Text = "Создать материал";
            this.CreateMaterial.ThemeName = "Office2013Dark";
            this.CreateMaterial.Click += new System.EventHandler(this.CreateMaterial_Click);
            // 
            // EBox
            // 
            this.EBox.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.EBox.Location = new System.Drawing.Point(149, 81);
            this.EBox.Name = "EBox";
            this.EBox.Size = new System.Drawing.Size(100, 23);
            this.EBox.TabIndex = 1;
            this.EBox.Text = "200000";
            this.EBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EBox.ThemeName = "Office2013Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radLabel1.Location = new System.Drawing.Point(8, 83);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(102, 21);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Модуль Юнга, E";
            this.radLabel1.ThemeName = "Office2013Dark";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.NuBox);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.GBox);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.TitleLabel);
            this.radGroupBox1.Controls.Add(this.EBox);
            this.radGroupBox1.Controls.Add(this.TitleBox);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radGroupBox1.HeaderText = "Параметры жесткости";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 68);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(268, 191);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Параметры жесткости";
            this.radGroupBox1.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.RadGroupBoxElement)(this.radGroupBox1.GetChildAt(0))).HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "Параметры жесткости";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NuBox
            // 
            this.NuBox.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.NuBox.Location = new System.Drawing.Point(149, 139);
            this.NuBox.Name = "NuBox";
            this.NuBox.Size = new System.Drawing.Size(100, 23);
            this.NuBox.TabIndex = 3;
            this.NuBox.Text = "0.3";
            this.NuBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NuBox.ThemeName = "Office2013Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radLabel3.Location = new System.Drawing.Point(8, 141);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(132, 21);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Коэф-т Пуассона, Nu";
            this.radLabel3.ThemeName = "Office2013Dark";
            // 
            // GBox
            // 
            this.GBox.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.GBox.Location = new System.Drawing.Point(149, 110);
            this.GBox.Name = "GBox";
            this.GBox.Size = new System.Drawing.Size(100, 23);
            this.GBox.TabIndex = 3;
            this.GBox.Text = "0";
            this.GBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GBox.ThemeName = "Office2013Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radLabel2.Location = new System.Drawing.Point(8, 112);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(111, 21);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Модуль сдвига, G";
            this.radLabel2.ThemeName = "Office2013Dark";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.TitleLabel.Location = new System.Drawing.Point(8, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(135, 21);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Название материала:";
            this.TitleLabel.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.TitleLabel.GetChildAt(0))).Text = "Название материала:";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TitleLabel.GetChildAt(0).GetChildAt(1))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TitleLabel.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TitleLabel.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.TitleBox.Location = new System.Drawing.Point(149, 34);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(100, 23);
            this.TitleBox.TabIndex = 2;
            this.TitleBox.Text = "Material";
            this.TitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleBox.ThemeName = "Office2013Dark";
            // 
            // Auto
            // 
            this.Auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Auto.Location = new System.Drawing.Point(72, 8);
            this.Auto.Name = "Auto";
            this.Auto.Size = new System.Drawing.Size(50, 19);
            this.Auto.TabIndex = 4;
            this.Auto.Text = "Авто";
            this.Auto.ThemeName = "Office2013Dark";
            this.Auto.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.Auto.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Auto_ToggleStateChanged);
            // 
            // Manual
            // 
            this.Manual.Location = new System.Drawing.Point(146, 8);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(65, 19);
            this.Manual.TabIndex = 5;
            this.Manual.TabStop = false;
            this.Manual.Text = "Ручной";
            this.Manual.ThemeName = "Office2013Dark";
            this.Manual.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Manual_ToggleStateChanged);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radLabel5.Location = new System.Drawing.Point(12, 6);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(50, 21);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "Режим:";
            this.radLabel5.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel5.GetChildAt(0))).Text = "Режим:";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel5.GetChildAt(0).GetChildAt(1))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel5.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel5.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radLabel4.Location = new System.Drawing.Point(12, 35);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(128, 21);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "Готовые материалы:";
            this.radLabel4.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel4.GetChildAt(0))).Text = "Готовые материалы:";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel4.GetChildAt(0).GetChildAt(1))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel4.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel4.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            // 
            // materialLibraryComboBox
            // 
            // 
            // materialLibraryComboBox.NestedRadGridView
            // 
            this.materialLibraryComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.materialLibraryComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialLibraryComboBox.EditorControl.EnableHotTracking = false;
            this.materialLibraryComboBox.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.materialLibraryComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLibraryComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLibraryComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.materialLibraryComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.AllowColumnReorder = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.AllowDragToGroup = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.EnableSorting = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.ShowColumnHeaders = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.materialLibraryComboBox.EditorControl.MasterTemplate.ShowRowHeaderColumn = false;
            this.materialLibraryComboBox.EditorControl.Name = "NestedRadGridView";
            this.materialLibraryComboBox.EditorControl.ReadOnly = true;
            this.materialLibraryComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLibraryComboBox.EditorControl.ShowGroupPanel = false;
            this.materialLibraryComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.materialLibraryComboBox.EditorControl.TabIndex = 0;
            this.materialLibraryComboBox.Location = new System.Drawing.Point(146, 36);
            this.materialLibraryComboBox.Name = "materialLibraryComboBox";
            this.materialLibraryComboBox.Size = new System.Drawing.Size(134, 20);
            this.materialLibraryComboBox.TabIndex = 51;
            this.materialLibraryComboBox.TabStop = false;
            this.materialLibraryComboBox.ThemeName = "Office2013Dark";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StatusImage,
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 362);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(295, 33);
            this.statusStrip.TabIndex = 52;
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
            // MaterialPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 395);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.materialLibraryComboBox);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.Auto);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.CreateMaterial);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "MaterialPropertyForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Материал";
            this.ThemeName = "Office2013Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaterialPropertyForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CreateMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Auto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialLibraryComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialLibraryComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialLibraryComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton CreateMaterial;
        private Telerik.WinControls.UI.RadTextBox EBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox NuBox;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox GBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TitleBox;
        private Telerik.WinControls.UI.RadLabel TitleLabel;
        private Telerik.WinControls.UI.RadRadioButton Auto;
        private Telerik.WinControls.UI.RadRadioButton Manual;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadMultiColumnComboBox materialLibraryComboBox;
        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadImageButtonElement StatusImage;
        private Telerik.WinControls.UI.RadLabelElement StatusLabel;
    }
}