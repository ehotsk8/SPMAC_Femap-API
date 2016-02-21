namespace SPMAC_for_Femap
{
    partial class AnalysisForm
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
            this.components = new System.ComponentModel.Container();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.AnalysisButton = new Telerik.WinControls.UI.RadButton();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.StatusImage = new Telerik.WinControls.UI.RadImageButtonElement();
            this.StatusLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MaterialButton = new Telerik.WinControls.UI.RadButton();
            this.LoadButton = new Telerik.WinControls.UI.RadButton();
            this.ConstraintButton = new Telerik.WinControls.UI.RadButton();
            this.FEAButton = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstraintButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FEAButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radButton1.Location = new System.Drawing.Point(165, 36);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(103, 51);
            this.radButton1.TabIndex = 19;
            this.radButton1.Text = "<html><p>Показать</p><p>результат</p></html>";
            this.radButton1.ThemeName = "Office2013Dark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // AnalysisButton
            // 
            this.AnalysisButton.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.AnalysisButton.Location = new System.Drawing.Point(5, 36);
            this.AnalysisButton.Name = "AnalysisButton";
            this.AnalysisButton.Size = new System.Drawing.Size(156, 51);
            this.AnalysisButton.TabIndex = 18;
            this.AnalysisButton.Text = "Анализ";
            this.AnalysisButton.ThemeName = "Office2013Dark";
            this.AnalysisButton.Click += new System.EventHandler(this.AnalysisButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StatusImage,
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 432);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(297, 33);
            this.statusStrip.TabIndex = 20;
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
            // MaterialButton
            // 
            this.MaterialButton.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.MaterialButton.Location = new System.Drawing.Point(6, 28);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(263, 32);
            this.MaterialButton.TabIndex = 14;
            this.MaterialButton.Text = "Материал";
            this.MaterialButton.ThemeName = "Office2013Dark";
            this.MaterialButton.Click += new System.EventHandler(this.MaterialButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.LoadButton.Location = new System.Drawing.Point(5, 66);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(263, 32);
            this.LoadButton.TabIndex = 15;
            this.LoadButton.Text = "Нагрузка";
            this.LoadButton.ThemeName = "Office2013Dark";
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ConstraintButton
            // 
            this.ConstraintButton.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.ConstraintButton.Location = new System.Drawing.Point(5, 104);
            this.ConstraintButton.Name = "ConstraintButton";
            this.ConstraintButton.Size = new System.Drawing.Size(263, 32);
            this.ConstraintButton.TabIndex = 16;
            this.ConstraintButton.Text = "Граничные условия";
            this.ConstraintButton.ThemeName = "Office2013Dark";
            this.ConstraintButton.Click += new System.EventHandler(this.ConstraintButton_Click);
            // 
            // FEAButton
            // 
            this.FEAButton.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.FEAButton.Location = new System.Drawing.Point(5, 142);
            this.FEAButton.Name = "FEAButton";
            this.FEAButton.Size = new System.Drawing.Size(263, 32);
            this.FEAButton.TabIndex = 17;
            this.FEAButton.Text = "Параметры конечных элементов";
            this.FEAButton.ThemeName = "Office2013Dark";
            this.FEAButton.Click += new System.EventHandler(this.FEAButton_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.FEAButton);
            this.radGroupBox1.Controls.Add(this.ConstraintButton);
            this.radGroupBox1.Controls.Add(this.LoadButton);
            this.radGroupBox1.Controls.Add(this.MaterialButton);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Функции";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(273, 198);
            this.radGroupBox1.TabIndex = 12;
            this.radGroupBox1.Text = "Функции";
            this.radGroupBox1.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.AnalysisButton);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "Анализ";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 216);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(273, 115);
            this.radGroupBox2.TabIndex = 21;
            this.radGroupBox2.Text = "Анализ";
            this.radGroupBox2.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox2.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox2.GetChildAt(0).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 465);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "AnalysisForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Анализ";
            this.ThemeName = "Office2013Dark";
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalysisButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConstraintButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FEAButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton AnalysisButton;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadImageButtonElement StatusImage;
        private Telerik.WinControls.UI.RadLabelElement StatusLabel;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadButton MaterialButton;
        private Telerik.WinControls.UI.RadButton LoadButton;
        private Telerik.WinControls.UI.RadButton ConstraintButton;
        private Telerik.WinControls.UI.RadButton FEAButton;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;

    }
}