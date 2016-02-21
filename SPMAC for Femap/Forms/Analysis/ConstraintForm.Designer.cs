namespace SPMAC_for_Femap.Forms.Analysis
{
    partial class ConstraintForm
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
            this.ConstraintButton = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.RZ = new Telerik.WinControls.UI.RadCheckBox();
            this.TZ = new Telerik.WinControls.UI.RadCheckBox();
            this.RY = new Telerik.WinControls.UI.RadCheckBox();
            this.TY = new Telerik.WinControls.UI.RadCheckBox();
            this.RX = new Telerik.WinControls.UI.RadCheckBox();
            this.TX = new Telerik.WinControls.UI.RadCheckBox();
            this.TitleLabel = new Telerik.WinControls.UI.RadLabel();
            this.TitleBox = new Telerik.WinControls.UI.RadTextBox();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.StatusImage = new Telerik.WinControls.UI.RadImageButtonElement();
            this.StatusLabel = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.ConstraintButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ConstraintButton
            // 
            this.ConstraintButton.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.ConstraintButton.Location = new System.Drawing.Point(12, 229);
            this.ConstraintButton.Name = "ConstraintButton";
            this.ConstraintButton.Size = new System.Drawing.Size(276, 39);
            this.ConstraintButton.TabIndex = 0;
            this.ConstraintButton.Text = "Создать граничное условие";
            this.ConstraintButton.ThemeName = "Office2013Dark";
            this.ConstraintButton.Click += new System.EventHandler(this.ConstraintButton_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.RZ);
            this.radGroupBox1.Controls.Add(this.TZ);
            this.radGroupBox1.Controls.Add(this.RY);
            this.radGroupBox1.Controls.Add(this.TY);
            this.radGroupBox1.Controls.Add(this.RX);
            this.radGroupBox1.Controls.Add(this.TX);
            this.radGroupBox1.Controls.Add(this.TitleLabel);
            this.radGroupBox1.Controls.Add(this.TitleBox);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radGroupBox1.HeaderText = "Параметры";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(276, 200);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Параметры";
            this.radGroupBox1.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.RadGroupBoxElement)(this.radGroupBox1.GetChildAt(0))).HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Text = "Параметры";
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radLabel1.Location = new System.Drawing.Point(8, 74);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(81, 21);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Ограничить:";
            this.radLabel1.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).Text = "Ограничить:";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(1))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radLabel1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            // 
            // RZ
            // 
            this.RZ.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.RZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RZ.Location = new System.Drawing.Point(159, 156);
            this.RZ.Name = "RZ";
            this.RZ.Size = new System.Drawing.Size(105, 23);
            this.RZ.TabIndex = 8;
            this.RZ.Text = "Вращение Z";
            this.RZ.ThemeName = "Office2013Dark";
            this.RZ.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // TZ
            // 
            this.TZ.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.TZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TZ.Location = new System.Drawing.Point(8, 156);
            this.TZ.Name = "TZ";
            this.TZ.Size = new System.Drawing.Size(132, 23);
            this.TZ.TabIndex = 5;
            this.TZ.Text = "Перемещение Z";
            this.TZ.ThemeName = "Office2013Dark";
            this.TZ.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // RY
            // 
            this.RY.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.RY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RY.Location = new System.Drawing.Point(159, 127);
            this.RY.Name = "RY";
            this.RY.Size = new System.Drawing.Size(104, 23);
            this.RY.TabIndex = 7;
            this.RY.Text = "Вращение Y";
            this.RY.ThemeName = "Office2013Dark";
            this.RY.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // TY
            // 
            this.TY.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.TY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TY.Location = new System.Drawing.Point(8, 127);
            this.TY.Name = "TY";
            this.TY.Size = new System.Drawing.Size(131, 23);
            this.TY.TabIndex = 5;
            this.TY.Text = "Перемещение Y";
            this.TY.ThemeName = "Office2013Dark";
            this.TY.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // RX
            // 
            this.RX.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.RX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RX.Location = new System.Drawing.Point(159, 98);
            this.RX.Name = "RX";
            this.RX.Size = new System.Drawing.Size(105, 23);
            this.RX.TabIndex = 6;
            this.RX.Text = "Вращение X";
            this.RX.ThemeName = "Office2013Dark";
            this.RX.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // TX
            // 
            this.TX.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.TX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TX.Location = new System.Drawing.Point(8, 98);
            this.TX.Name = "TX";
            this.TX.Size = new System.Drawing.Size(132, 23);
            this.TX.TabIndex = 4;
            this.TX.Text = "Перемещение X";
            this.TX.ThemeName = "Office2013Dark";
            this.TX.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.TitleLabel.Location = new System.Drawing.Point(8, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(68, 21);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Название:";
            this.TitleLabel.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.TitleLabel.GetChildAt(0))).Text = "Название:";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TitleLabel.GetChildAt(0).GetChildAt(1))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TitleLabel.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TitleLabel.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.TitleBox.Location = new System.Drawing.Point(82, 35);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(181, 23);
            this.TitleBox.TabIndex = 2;
            this.TitleBox.Text = "Constraint";
            this.TitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TitleBox.ThemeName = "Office2013Dark";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StatusImage,
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 364);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(297, 33);
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
            // ConstraintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 397);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.ConstraintButton);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "ConstraintForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Граничные условия";
            this.ThemeName = "Office2013Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConstraintForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ConstraintButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton ConstraintButton;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel TitleLabel;
        private Telerik.WinControls.UI.RadTextBox TitleBox;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox RZ;
        private Telerik.WinControls.UI.RadCheckBox TZ;
        private Telerik.WinControls.UI.RadCheckBox RY;
        private Telerik.WinControls.UI.RadCheckBox TY;
        private Telerik.WinControls.UI.RadCheckBox RX;
        private Telerik.WinControls.UI.RadCheckBox TX;
        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadImageButtonElement StatusImage;
        private Telerik.WinControls.UI.RadLabelElement StatusLabel;
    }
}