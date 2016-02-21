namespace SPMAC_for_Femap.Forms
{
    partial class AssemblyForm
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
            this.menuStrip1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.AssemblyMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.ExitMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.progressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.RodCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.CylinderCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.CrankshaftCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.FingerCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.PistonCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.RodCoverCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.CreateAssyBtn = new Telerik.WinControls.UI.RadButton();
            this.StopButton = new Telerik.WinControls.UI.RadButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.L6 = new Telerik.WinControls.UI.RadLabel();
            this.L5 = new Telerik.WinControls.UI.RadLabel();
            this.L2 = new Telerik.WinControls.UI.RadLabel();
            this.L3 = new Telerik.WinControls.UI.RadLabel();
            this.L4 = new Telerik.WinControls.UI.RadLabel();
            this.L1 = new Telerik.WinControls.UI.RadLabel();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.StatusLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.comboDetailSets = new System.Windows.Forms.ComboBox();
            this.StatusImage = new Telerik.WinControls.UI.RadImageButtonElement();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrankshaftCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PistonCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodCoverCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateAssyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.menuStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 23);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "radMenu1";
            this.menuStrip1.ThemeName = "Office2013Dark";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Файл";
            this.radMenuItem1.AccessibleName = "Файл";
            this.radMenuItem1.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.radMenuItem1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.AssemblyMenuItem,
            this.radMenuItem2,
            this.radMenuSeparatorItem1,
            this.ExitMenuItem});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Файл";
            // 
            // AssemblyMenuItem
            // 
            this.AssemblyMenuItem.AccessibleDescription = "Начать сборку";
            this.AssemblyMenuItem.AccessibleName = "Начать сборку";
            this.AssemblyMenuItem.Name = "AssemblyMenuItem";
            this.AssemblyMenuItem.Text = "Начать сборку";
            this.AssemblyMenuItem.Click += new System.EventHandler(this.CreateAssyBtn_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "CancelMenuItem";
            this.radMenuItem2.AccessibleName = "Остановить";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Остановить";
            this.radMenuItem2.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.AccessibleDescription = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.AccessibleName = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.AccessibleDescription = "Выход";
            this.ExitMenuItem.AccessibleName = "Выход";
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(394, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 18);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.progressBar1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(50)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.progressBar1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // RodCheck
            // 
            this.RodCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RodCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RodCheck.Location = new System.Drawing.Point(5, 31);
            this.RodCheck.Name = "RodCheck";
            this.RodCheck.Size = new System.Drawing.Size(70, 25);
            this.RodCheck.TabIndex = 48;
            this.RodCheck.Text = "Шатун";
            this.RodCheck.ThemeName = "Office2013Dark";
            this.RodCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.CylinderCheck);
            this.radGroupBox1.Controls.Add(this.CrankshaftCheck);
            this.radGroupBox1.Controls.Add(this.FingerCheck);
            this.radGroupBox1.Controls.Add(this.PistonCheck);
            this.radGroupBox1.Controls.Add(this.RodCoverCheck);
            this.radGroupBox1.Controls.Add(this.RodCheck);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.radGroupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Включить в сборку";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 113);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(200, 228);
            this.radGroupBox1.TabIndex = 49;
            this.radGroupBox1.Text = "Включить в сборку";
            this.radGroupBox1.ThemeName = "Office2013Dark";
            // 
            // CylinderCheck
            // 
            this.CylinderCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CylinderCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CylinderCheck.Location = new System.Drawing.Point(5, 186);
            this.CylinderCheck.Name = "CylinderCheck";
            this.CylinderCheck.Size = new System.Drawing.Size(90, 25);
            this.CylinderCheck.TabIndex = 53;
            this.CylinderCheck.Text = "Цилиндр";
            this.CylinderCheck.ThemeName = "Office2013Dark";
            this.CylinderCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // CrankshaftCheck
            // 
            this.CrankshaftCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CrankshaftCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CrankshaftCheck.Location = new System.Drawing.Point(5, 155);
            this.CrankshaftCheck.Name = "CrankshaftCheck";
            this.CrankshaftCheck.Size = new System.Drawing.Size(93, 25);
            this.CrankshaftCheck.TabIndex = 52;
            this.CrankshaftCheck.Text = "Коленвал";
            this.CrankshaftCheck.ThemeName = "Office2013Dark";
            this.CrankshaftCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // FingerCheck
            // 
            this.FingerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FingerCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FingerCheck.Location = new System.Drawing.Point(5, 124);
            this.FingerCheck.Name = "FingerCheck";
            this.FingerCheck.Size = new System.Drawing.Size(158, 25);
            this.FingerCheck.TabIndex = 51;
            this.FingerCheck.Text = "Поршневой палец";
            this.FingerCheck.ThemeName = "Office2013Dark";
            this.FingerCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // PistonCheck
            // 
            this.PistonCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PistonCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PistonCheck.Location = new System.Drawing.Point(5, 93);
            this.PistonCheck.Name = "PistonCheck";
            this.PistonCheck.Size = new System.Drawing.Size(92, 25);
            this.PistonCheck.TabIndex = 50;
            this.PistonCheck.Text = "Поршень";
            this.PistonCheck.ThemeName = "Office2013Dark";
            this.PistonCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // RodCoverCheck
            // 
            this.RodCoverCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RodCoverCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RodCoverCheck.Location = new System.Drawing.Point(5, 62);
            this.RodCoverCheck.Name = "RodCoverCheck";
            this.RodCoverCheck.Size = new System.Drawing.Size(137, 25);
            this.RodCoverCheck.TabIndex = 49;
            this.RodCoverCheck.Text = "Крышка шатуна";
            this.RodCoverCheck.ThemeName = "Office2013Dark";
            this.RodCoverCheck.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // CreateAssyBtn
            // 
            this.CreateAssyBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAssyBtn.Location = new System.Drawing.Point(12, 29);
            this.CreateAssyBtn.Name = "CreateAssyBtn";
            this.CreateAssyBtn.Size = new System.Drawing.Size(200, 51);
            this.CreateAssyBtn.TabIndex = 50;
            this.CreateAssyBtn.Text = "Начать сборку";
            this.CreateAssyBtn.ThemeName = "Office2013Dark";
            this.CreateAssyBtn.Click += new System.EventHandler(this.CreateAssyBtn_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.StopButton.Location = new System.Drawing.Point(12, 347);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(200, 27);
            this.StopButton.TabIndex = 51;
            this.StopButton.Text = "Остановить построение";
            this.StopButton.ThemeName = "VisualStudio2012Light";
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.L6);
            this.panel1.Controls.Add(this.L5);
            this.panel1.Controls.Add(this.L2);
            this.panel1.Controls.Add(this.L3);
            this.panel1.Controls.Add(this.L4);
            this.panel1.Controls.Add(this.L1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(218, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 345);
            this.panel1.TabIndex = 53;
            // 
            // L6
            // 
            this.L6.BorderVisible = true;
            this.L6.Cursor = System.Windows.Forms.Cursors.Default;
            this.L6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.L6.Location = new System.Drawing.Point(200, 45);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(114, 21);
            this.L6.TabIndex = 11;
            this.L6.Text = "Гильза цилиндра";
            this.L6.ThemeName = "Office2013Dark";
            // 
            // L5
            // 
            this.L5.BorderVisible = true;
            this.L5.Cursor = System.Windows.Forms.Cursors.Default;
            this.L5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.L5.Location = new System.Drawing.Point(53, 129);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(67, 21);
            this.L5.TabIndex = 10;
            this.L5.Text = "Коленвал";
            this.L5.ThemeName = "Office2013Dark";
            // 
            // L2
            // 
            this.L2.BorderVisible = true;
            this.L2.Cursor = System.Windows.Forms.Cursors.Default;
            this.L2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.L2.Location = new System.Drawing.Point(185, 271);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(106, 21);
            this.L2.TabIndex = 10;
            this.L2.Text = "Крышка шатуна";
            this.L2.ThemeName = "Office2013Dark";
            // 
            // L3
            // 
            this.L3.BorderVisible = true;
            this.L3.Cursor = System.Windows.Forms.Cursors.Default;
            this.L3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.L3.Location = new System.Drawing.Point(313, 200);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(66, 21);
            this.L3.TabIndex = 10;
            this.L3.Text = "Поршень";
            this.L3.ThemeName = "Office2013Dark";
            // 
            // L4
            // 
            this.L4.BorderVisible = true;
            this.L4.Cursor = System.Windows.Forms.Cursors.Default;
            this.L4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.L4.Location = new System.Drawing.Point(130, 70);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(124, 21);
            this.L4.TabIndex = 10;
            this.L4.Text = "Поршневой палец";
            this.L4.ThemeName = "Office2013Dark";
            // 
            // L1
            // 
            this.L1.BorderVisible = true;
            this.L1.Cursor = System.Windows.Forms.Cursors.Default;
            this.L1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.L1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.L1.Location = new System.Drawing.Point(244, 230);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(47, 21);
            this.L1.TabIndex = 9;
            this.L1.Text = "Шатун";
            this.L1.ThemeName = "Office2013Dark";
            // 
            // statusStrip
            // 
            this.statusStrip.Controls.Add(this.progressBar1);
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StatusImage,
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 390);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(674, 33);
            this.statusStrip.TabIndex = 54;
            this.statusStrip.Text = "radStatusStrip1";
            this.statusStrip.ThemeName = "Office2013Dark";
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
            // comboDetailSets
            // 
            this.comboDetailSets.FormattingEnabled = true;
            this.comboDetailSets.Location = new System.Drawing.Point(12, 86);
            this.comboDetailSets.Name = "comboDetailSets";
            this.comboDetailSets.Size = new System.Drawing.Size(200, 21);
            this.comboDetailSets.TabIndex = 55;
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::SPMAC_for_Femap.Properties.Resources.ASSY;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // radPanel1
            // 
            this.radPanel1.BackgroundImage = global::SPMAC_for_Femap.Properties.Resources.ASSY;
            this.radPanel1.Location = new System.Drawing.Point(266, 51);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(0, 0);
            this.radPanel1.TabIndex = 52;
            this.radPanel1.ThemeName = "Office2013Dark";
            // 
            // AssemblyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 423);
            this.Controls.Add(this.comboDetailSets);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.CreateAssyBtn);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AssemblyForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Сборка";
            this.ThemeName = "Office2013Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParamConnectingRodForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.menuStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CylinderCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrankshaftCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FingerCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PistonCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodCoverCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateAssyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            this.statusStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu menuStrip1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem AssemblyMenuItem;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem ExitMenuItem;
        private Telerik.WinControls.UI.RadProgressBar progressBar1;
        private Telerik.WinControls.UI.RadCheckBox RodCheck;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadCheckBox CrankshaftCheck;
        private Telerik.WinControls.UI.RadCheckBox FingerCheck;
        private Telerik.WinControls.UI.RadCheckBox PistonCheck;
        private Telerik.WinControls.UI.RadCheckBox RodCoverCheck;
        private Telerik.WinControls.UI.RadButton CreateAssyBtn;
        private Telerik.WinControls.UI.RadButton StopButton;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel L5;
        private Telerik.WinControls.UI.RadLabel L2;
        private Telerik.WinControls.UI.RadLabel L3;
        private Telerik.WinControls.UI.RadLabel L4;
        private Telerik.WinControls.UI.RadLabel L1;
        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadImageButtonElement StatusImage;
        private Telerik.WinControls.UI.RadLabelElement StatusLabel;
        private System.Windows.Forms.ComboBox comboDetailSets;
        private Telerik.WinControls.UI.RadCheckBox CylinderCheck;
        private Telerik.WinControls.UI.RadLabel L6;
    }
}
