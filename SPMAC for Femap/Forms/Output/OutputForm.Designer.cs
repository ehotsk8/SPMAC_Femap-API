namespace SPMAC_for_Femap.Forms.Output
{
    partial class OutputForm
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
            this.RADDOCK = new Telerik.WinControls.UI.Docking.RadDock();
            this.DocumentWindow = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.grid1 = new Telerik.WinControls.UI.RadGridView();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.ResultWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.treeView = new Telerik.WinControls.UI.RadTreeView();
            this.DetailtsTabWindow = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.DetailsWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radTreeView1 = new Telerik.WinControls.UI.RadTreeView();
            this.CONTAINER = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.progressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.StatusImage = new Telerik.WinControls.UI.RadLabelElement();
            this.StatusLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.Menu = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement3 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.AllDataBar = new Telerik.WinControls.UI.CommandBarButton();
            this.CompareBar = new Telerik.WinControls.UI.CommandBarButton();
            this.SaveCompareBar = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RADDOCK)).BeginInit();
            this.RADDOCK.SuspendLayout();
            this.DocumentWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            this.ResultWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailtsTabWindow)).BeginInit();
            this.DetailtsTabWindow.SuspendLayout();
            this.DetailsWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAINER)).BeginInit();
            this.CONTAINER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RADDOCK
            // 
            this.RADDOCK.ActiveWindow = this.DocumentWindow;
            this.RADDOCK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RADDOCK.CausesValidation = false;
            this.RADDOCK.Controls.Add(this.radSplitContainer1);
            this.RADDOCK.Controls.Add(this.CONTAINER);
            this.RADDOCK.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.RADDOCK.IsCleanUpTarget = true;
            this.RADDOCK.Location = new System.Drawing.Point(0, 57);
            this.RADDOCK.MainDocumentContainer = this.CONTAINER;
            this.RADDOCK.Name = "RADDOCK";
            this.RADDOCK.Padding = new System.Windows.Forms.Padding(0);
            this.RADDOCK.Size = new System.Drawing.Size(981, 444);
            this.RADDOCK.TabIndex = 1;
            this.RADDOCK.TabStop = false;
            this.RADDOCK.Text = "radDock1";
            this.RADDOCK.ThemeName = "Office2013Dark";
            // 
            // DocumentWindow
            // 
            this.DocumentWindow.CloseAction = Telerik.WinControls.UI.Docking.DockWindowCloseAction.Hide;
            this.DocumentWindow.Controls.Add(this.grid1);
            this.DocumentWindow.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.DocumentWindow.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.DocumentWindow.Location = new System.Drawing.Point(5, 36);
            this.DocumentWindow.Name = "DocumentWindow";
            this.DocumentWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.DocumentWindow.Size = new System.Drawing.Size(689, 403);
            this.DocumentWindow.Text = "Данные";
            this.DocumentWindow.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
            // 
            // grid1
            // 
            this.grid1.AutoSizeRows = true;
            this.grid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid1.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.grid1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grid1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            // 
            // grid1
            // 
            this.grid1.MasterTemplate.AllowAddNewRow = false;
            this.grid1.MasterTemplate.AllowColumnReorder = false;
            this.grid1.MasterTemplate.AllowDeleteRow = false;
            this.grid1.MasterTemplate.AllowEditRow = false;
            this.grid1.MasterTemplate.AllowRowResize = false;
            this.grid1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grid1.Size = new System.Drawing.Size(689, 403);
            this.grid1.TabIndex = 0;
            this.grid1.Text = "radGridView1";
            this.grid1.ThemeName = "Office2013Dark";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.CausesValidation = false;
            this.radSplitContainer1.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer1.Controls.Add(this.DetailtsTabWindow);
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radSplitContainer1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(278, 444);
            this.radSplitContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(278, 200);
            this.radSplitContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(78, 0);
            this.radSplitContainer1.TabIndex = 3;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "Office2013Dark";
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.AutoHidePosition = Telerik.WinControls.UI.Docking.AutoHidePosition.Left;
            this.toolTabStrip2.CanUpdateChildIndex = true;
            this.toolTabStrip2.Controls.Add(this.ResultWindow);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(278, 228);
            this.toolTabStrip2.SizeInfo.AbsoluteSize = new System.Drawing.Size(271, 200);
            this.toolTabStrip2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.01818182F);
            this.toolTabStrip2.SizeInfo.SplitterCorrection = new System.Drawing.Size(71, -2);
            this.toolTabStrip2.TabIndex = 1;
            this.toolTabStrip2.TabStop = false;
            this.toolTabStrip2.ThemeName = "Office2013Dark";
            this.toolTabStrip2.UseCompatibleTextRendering = false;
            // 
            // ResultWindow
            // 
            this.ResultWindow.Caption = null;
            this.ResultWindow.Controls.Add(this.treeView);
            this.ResultWindow.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.ResultWindow.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ResultWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ResultWindow.Location = new System.Drawing.Point(4, 28);
            this.ResultWindow.Name = "ResultWindow";
            this.ResultWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.ResultWindow.Size = new System.Drawing.Size(270, 196);
            this.ResultWindow.Text = "Состав";
            this.ResultWindow.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.treeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.treeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.treeView.FullRowSelect = false;
            this.treeView.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.treeView.ItemHeight = 25;
            this.treeView.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView.ShowLines = true;
            this.treeView.Size = new System.Drawing.Size(270, 196);
            this.treeView.SpacingBetweenNodes = -1;
            this.treeView.TabIndex = 0;
            this.treeView.Text = "radTreeView1";
            this.treeView.ThemeName = "Office2013Dark";
            this.treeView.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.treeView_SelectedNodeChanged);
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).ShowExpandCollapse = true;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).ItemHeight = 25;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).ShowLines = true;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).ShowRootLines = true;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).LineColor = System.Drawing.Color.Gray;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).TreeIndent = 20;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).NodeSpacing = -1;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.treeView.GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            // 
            // DetailtsTabWindow
            // 
            this.DetailtsTabWindow.CanUpdateChildIndex = true;
            this.DetailtsTabWindow.CausesValidation = false;
            this.DetailtsTabWindow.Controls.Add(this.DetailsWindow);
            this.DetailtsTabWindow.Location = new System.Drawing.Point(0, 232);
            this.DetailtsTabWindow.Name = "DetailtsTabWindow";
            // 
            // 
            // 
            this.DetailtsTabWindow.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.DetailtsTabWindow.SelectedIndex = 0;
            this.DetailtsTabWindow.Size = new System.Drawing.Size(278, 212);
            this.DetailtsTabWindow.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.01818182F);
            this.DetailtsTabWindow.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 2);
            this.DetailtsTabWindow.TabIndex = 2;
            this.DetailtsTabWindow.TabStop = false;
            this.DetailtsTabWindow.ThemeName = "Office2013Dark";
            // 
            // DetailsWindow
            // 
            this.DetailsWindow.Caption = null;
            this.DetailsWindow.Controls.Add(this.radTreeView1);
            this.DetailsWindow.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.DetailsWindow.Location = new System.Drawing.Point(4, 29);
            this.DetailsWindow.Name = "DetailsWindow";
            this.DetailsWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.DetailsWindow.Size = new System.Drawing.Size(270, 179);
            this.DetailsWindow.Text = "Анализ";
            this.DetailsWindow.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // radTreeView1
            // 
            this.radTreeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.radTreeView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radTreeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.radTreeView1.FullRowSelect = false;
            this.radTreeView1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.radTreeView1.ItemHeight = 30;
            this.radTreeView1.LineStyle = Telerik.WinControls.UI.TreeLineStyle.Solid;
            this.radTreeView1.Location = new System.Drawing.Point(0, 0);
            this.radTreeView1.Name = "radTreeView1";
            this.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radTreeView1.ShowLines = true;
            this.radTreeView1.Size = new System.Drawing.Size(270, 179);
            this.radTreeView1.SpacingBetweenNodes = -1;
            this.radTreeView1.TabIndex = 1;
            this.radTreeView1.Text = "radTreeView1";
            this.radTreeView1.ThemeName = "Office2013Dark";
            this.radTreeView1.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.radTreeView1_SelectedNodeChanged);
            // 
            // CONTAINER
            // 
            this.CONTAINER.CausesValidation = false;
            this.CONTAINER.Controls.Add(this.documentTabStrip1);
            this.CONTAINER.Name = "CONTAINER";
            this.CONTAINER.SizeInfo.AbsoluteSize = new System.Drawing.Size(689, 200);
            this.CONTAINER.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.CONTAINER.SizeInfo.SplitterCorrection = new System.Drawing.Size(-78, 0);
            this.CONTAINER.TabIndex = 2;
            this.CONTAINER.ThemeName = "Office2013Dark";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.CausesValidation = false;
            this.documentTabStrip1.Controls.Add(this.DocumentWindow);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(699, 444);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "Office2013Dark";
            // 
            // statusStrip
            // 
            this.statusStrip.Controls.Add(this.progressBar1);
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StatusImage,
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 510);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(981, 36);
            this.statusStrip.TabIndex = 19;
            this.statusStrip.Text = "radStatusStrip1";
            this.statusStrip.ThemeName = "Office2013Dark";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(623, 9);
            this.progressBar1.Name = "progressBar1";
            // 
            // 
            // 
            this.progressBar1.RootElement.ApplyShapeToControl = false;
            this.progressBar1.Size = new System.Drawing.Size(341, 18);
            this.progressBar1.Step = 1;
            this.progressBar1.StepWidth = 10;
            this.progressBar1.TabIndex = 20;
            this.progressBar1.ThemeName = "Office2013Dark";
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.progressBar1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(50)))));
            ((Telerik.WinControls.UI.UpperProgressIndicatorElement)(this.progressBar1.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // StatusImage
            // 
            this.StatusImage.Image = global::SPMAC_for_Femap.Properties.Resources.OK;
            this.StatusImage.Name = "StatusImage";
            this.statusStrip.SetSpring(this.StatusImage, false);
            this.StatusImage.Text = "";
            this.StatusImage.TextWrap = true;
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
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Menu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(981, 21);
            this.Menu.TabIndex = 20;
            this.Menu.Text = "radMenu1";
            this.Menu.ThemeName = "Office2013Dark";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "Файл";
            this.radMenuItem1.AccessibleName = "Файл";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Файл";
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 21);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement2});
            this.radCommandBar1.Size = new System.Drawing.Size(981, 33);
            this.radCommandBar1.TabIndex = 21;
            this.radCommandBar1.Text = "radCommandBar1";
            this.radCommandBar1.ThemeName = "Office2013Dark";
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement3});
            // 
            // commandBarStripElement3
            // 
            this.commandBarStripElement3.DisplayName = "commandBarStripElement3";
            this.commandBarStripElement3.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.AllDataBar,
            this.CompareBar,
            this.SaveCompareBar});
            this.commandBarStripElement3.Name = "commandBarStripElement3";
            // 
            // AllDataBar
            // 
            this.AllDataBar.AccessibleDescription = "commandBarButton3";
            this.AllDataBar.AccessibleName = "commandBarButton3";
            this.AllDataBar.DisplayName = "commandBarButton3";
            this.AllDataBar.Image = global::SPMAC_for_Femap.Properties.Resources.DATA;
            this.AllDataBar.Name = "AllDataBar";
            this.AllDataBar.Text = "commandBarButton3";
            this.AllDataBar.Click += new System.EventHandler(this.AllDataBar_Click);
            // 
            // CompareBar
            // 
            this.CompareBar.AccessibleDescription = "commandBarButton3";
            this.CompareBar.AccessibleName = "commandBarButton3";
            this.CompareBar.DisplayName = "commandBarButton3";
            this.CompareBar.Image = global::SPMAC_for_Femap.Properties.Resources.COMPAREANALYSIS;
            this.CompareBar.Name = "CompareBar";
            this.CompareBar.Text = "commandBarButton3";
            this.CompareBar.Click += new System.EventHandler(this.CompareBar_Click);
            // 
            // SaveCompareBar
            // 
            this.SaveCompareBar.AccessibleDescription = "commandBarButton3";
            this.SaveCompareBar.AccessibleName = "commandBarButton3";
            this.SaveCompareBar.DisplayName = "commandBarButton3";
            this.SaveCompareBar.Image = global::SPMAC_for_Femap.Properties.Resources.SAVE;
            this.SaveCompareBar.Name = "SaveCompareBar";
            this.SaveCompareBar.Text = "commandBarButton3";
            // 
            // commandBarButton2
            // 
            this.commandBarButton2.AccessibleDescription = "commandBarButton1";
            this.commandBarButton2.AccessibleName = "commandBarButton1";
            this.commandBarButton2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.DisplayName = "commandBarButton1";
            this.commandBarButton2.Image = global::SPMAC_for_Femap.Properties.Resources.REFRESH;
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "";
            this.commandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 546);
            this.Controls.Add(this.radCommandBar1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.RADDOCK);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "OutputForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Сводные данные";
            this.ThemeName = "Office2013Dark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.RADDOCK)).EndInit();
            this.RADDOCK.ResumeLayout(false);
            this.DocumentWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            this.ResultWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailtsTabWindow)).EndInit();
            this.DetailtsTabWindow.ResumeLayout(false);
            this.DetailsWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAINER)).EndInit();
            this.CONTAINER.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            this.statusStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grid1;
        private Telerik.WinControls.UI.Docking.RadDock RADDOCK;
        private Telerik.WinControls.UI.Docking.ToolWindow ResultWindow;
        private Telerik.WinControls.UI.Docking.DocumentContainer CONTAINER;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow DocumentWindow;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.Docking.ToolTabStrip DetailtsTabWindow;
        private Telerik.WinControls.UI.Docking.ToolWindow DetailsWindow;
        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadLabelElement StatusLabel;
        private Telerik.WinControls.UI.RadMenu Menu;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement3;
        private Telerik.WinControls.UI.CommandBarButton AllDataBar;
        private Telerik.WinControls.UI.CommandBarButton CompareBar;
        private Telerik.WinControls.UI.CommandBarButton SaveCompareBar;
        private Telerik.WinControls.UI.RadLabelElement StatusImage;
        private Telerik.WinControls.UI.RadTreeView treeView;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadProgressBar progressBar1;

    }
}