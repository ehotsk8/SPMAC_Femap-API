namespace SPMAC_for_Femap.Forms.Output
{
    partial class BestResultForm
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
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            this.statusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.StatusImage = new Telerik.WinControls.UI.RadLabelElement();
            this.StatusLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.chartResults = new Telerik.WinControls.UI.RadChartView();
            this.DOCK = new Telerik.WinControls.UI.Docking.RadDock();
            this.baseWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.commandBar = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.SizesCommand = new Telerik.WinControls.UI.CommandBarButton();
            this.MaterialCommand = new Telerik.WinControls.UI.CommandBarButton();
            this.LoadCommand = new Telerik.WinControls.UI.CommandBarButton();
            this.ConstraintCommand = new Telerik.WinControls.UI.CommandBarButton();
            this.PropertyCommand = new Telerik.WinControls.UI.CommandBarButton();
            this.ResultCommand = new Telerik.WinControls.UI.CommandBarButton();
            this.grid = new Telerik.WinControls.UI.RadGridView();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.toolTabStrip1 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.detailWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.idTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.dataSetTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.nameTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.toolTabStrip2 = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.WindowChart = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.NowTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.OutputInWORDButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCK)).BeginInit();
            this.DOCK.SuspendLayout();
            this.baseWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).BeginInit();
            this.toolTabStrip1.SuspendLayout();
            this.detailWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).BeginInit();
            this.toolTabStrip2.SuspendLayout();
            this.WindowChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NowTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.statusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.StatusImage,
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 487);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1087, 36);
            this.statusStrip.TabIndex = 20;
            this.statusStrip.Text = "radStatusStrip1";
            this.statusStrip.ThemeName = "Office2013Dark";
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
            // chartResults
            // 
            this.chartResults.AreaDesign = cartesianArea2;
            this.chartResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartResults.Location = new System.Drawing.Point(0, 0);
            this.chartResults.Name = "chartResults";
            this.chartResults.ShowGrid = false;
            this.chartResults.Size = new System.Drawing.Size(546, 279);
            this.chartResults.TabIndex = 21;
            this.chartResults.ThemeName = "Office2013Dark";
            // 
            // DOCK
            // 
            this.DOCK.ActiveWindow = this.baseWindow;
            this.DOCK.CausesValidation = false;
            this.DOCK.Controls.Add(this.documentContainer1);
            this.DOCK.Controls.Add(this.radSplitContainer1);
            this.DOCK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DOCK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DOCK.IsCleanUpTarget = true;
            this.DOCK.Location = new System.Drawing.Point(0, 0);
            this.DOCK.MainDocumentContainer = this.documentContainer1;
            this.DOCK.Name = "DOCK";
            this.DOCK.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.DOCK.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.DOCK.Size = new System.Drawing.Size(1087, 487);
            this.DOCK.TabIndex = 22;
            this.DOCK.TabStop = false;
            this.DOCK.Text = "DOCK";
            this.DOCK.ThemeName = "Office2013Dark";
            // 
            // baseWindow
            // 
            this.baseWindow.Caption = null;
            this.baseWindow.Controls.Add(this.commandBar);
            this.baseWindow.Controls.Add(this.grid);
            this.baseWindow.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.baseWindow.Location = new System.Drawing.Point(5, 34);
            this.baseWindow.Name = "baseWindow";
            this.baseWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.baseWindow.Size = new System.Drawing.Size(519, 448);
            this.baseWindow.Text = "Данные";
            // 
            // commandBar
            // 
            this.commandBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandBar.Location = new System.Drawing.Point(0, 0);
            this.commandBar.Name = "commandBar";
            this.commandBar.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.commandBar.Size = new System.Drawing.Size(519, 33);
            this.commandBar.TabIndex = 1;
            this.commandBar.Text = "radCommandBar1";
            this.commandBar.ThemeName = "Office2013Dark";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.SizesCommand,
            this.MaterialCommand,
            this.LoadCommand,
            this.ConstraintCommand,
            this.PropertyCommand,
            this.ResultCommand});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // SizesCommand
            // 
            this.SizesCommand.AccessibleDescription = "commandBarButton1";
            this.SizesCommand.AccessibleName = "commandBarButton1";
            this.SizesCommand.DisplayName = "commandBarButton1";
            this.SizesCommand.Image = global::SPMAC_for_Femap.Properties.Resources.COMPAREANALYSIS;
            this.SizesCommand.Name = "SizesCommand";
            this.SizesCommand.Text = "commandBarButton1";
            this.SizesCommand.Click += new System.EventHandler(this.SizesCommand_Click);
            // 
            // MaterialCommand
            // 
            this.MaterialCommand.AccessibleDescription = "commandBarButton1";
            this.MaterialCommand.AccessibleName = "commandBarButton1";
            this.MaterialCommand.DisplayName = "commandBarButton1";
            this.MaterialCommand.Image = global::SPMAC_for_Femap.Properties.Resources.MATERIAL;
            this.MaterialCommand.Name = "MaterialCommand";
            this.MaterialCommand.Text = "commandBarButton1";
            this.MaterialCommand.Click += new System.EventHandler(this.MaterialCommand_Click);
            // 
            // LoadCommand
            // 
            this.LoadCommand.AccessibleDescription = "commandBarButton1";
            this.LoadCommand.AccessibleName = "commandBarButton1";
            this.LoadCommand.DisplayName = "commandBarButton1";
            this.LoadCommand.Image = global::SPMAC_for_Femap.Properties.Resources.LOAD;
            this.LoadCommand.Name = "LoadCommand";
            this.LoadCommand.Text = "commandBarButton1";
            this.LoadCommand.Click += new System.EventHandler(this.LoadCommand_Click);
            // 
            // ConstraintCommand
            // 
            this.ConstraintCommand.AccessibleDescription = "commandBarButton1";
            this.ConstraintCommand.AccessibleName = "commandBarButton1";
            this.ConstraintCommand.DisplayName = "commandBarButton1";
            this.ConstraintCommand.Image = global::SPMAC_for_Femap.Properties.Resources.CONSTRAINT;
            this.ConstraintCommand.Name = "ConstraintCommand";
            this.ConstraintCommand.Text = "commandBarButton1";
            this.ConstraintCommand.Click += new System.EventHandler(this.ConstraintCommand_Click);
            // 
            // PropertyCommand
            // 
            this.PropertyCommand.AccessibleDescription = "commandBarButton1";
            this.PropertyCommand.AccessibleName = "commandBarButton1";
            this.PropertyCommand.DisplayName = "commandBarButton1";
            this.PropertyCommand.Image = global::SPMAC_for_Femap.Properties.Resources.PROPERTY;
            this.PropertyCommand.Name = "PropertyCommand";
            this.PropertyCommand.Text = "commandBarButton1";
            this.PropertyCommand.Click += new System.EventHandler(this.PropertyCommand_Click);
            // 
            // ResultCommand
            // 
            this.ResultCommand.AccessibleDescription = "commandBarButton1";
            this.ResultCommand.AccessibleName = "commandBarButton1";
            this.ResultCommand.DisplayName = "commandBarButton1";
            this.ResultCommand.Image = global::SPMAC_for_Femap.Properties.Resources.ANALYSIS;
            this.ResultCommand.Name = "ResultCommand";
            this.ResultCommand.Text = "commandBarButton1";
            this.ResultCommand.Click += new System.EventHandler(this.ResultCommand_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeRows = true;
            this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.grid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.grid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grid.Location = new System.Drawing.Point(3, 39);
            // 
            // grid
            // 
            this.grid.MasterTemplate.AllowColumnChooser = false;
            this.grid.MasterTemplate.AllowColumnReorder = false;
            this.grid.MasterTemplate.AllowDragToGroup = false;
            this.grid.MasterTemplate.AllowRowResize = false;
            this.grid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grid.MasterTemplate.EnableGrouping = false;
            this.grid.MasterTemplate.ShowRowHeaderColumn = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grid.ShowGroupPanel = false;
            this.grid.Size = new System.Drawing.Size(513, 410);
            this.grid.TabIndex = 0;
            this.grid.Text = "radGridView1";
            this.grid.ThemeName = "Office2013Dark";
            // 
            // documentContainer1
            // 
            this.documentContainer1.CausesValidation = false;
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(519, 200);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-354, 0);
            this.documentContainer1.ThemeName = "Office2013Dark";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.CausesValidation = false;
            this.documentTabStrip1.Controls.Add(this.baseWindow);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(529, 487);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "Office2013Dark";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.toolTabStrip1);
            this.radSplitContainer1.Controls.Add(this.toolTabStrip2);
            this.radSplitContainer1.IsCleanUpTarget = true;
            this.radSplitContainer1.Location = new System.Drawing.Point(533, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.radSplitContainer1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(554, 487);
            this.radSplitContainer1.SizeInfo.AbsoluteSize = new System.Drawing.Size(554, 200);
            this.radSplitContainer1.SizeInfo.SplitterCorrection = new System.Drawing.Size(354, 0);
            this.radSplitContainer1.TabIndex = 2;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "Office2013Dark";
            // 
            // toolTabStrip1
            // 
            this.toolTabStrip1.CanUpdateChildIndex = true;
            this.toolTabStrip1.Controls.Add(this.detailWindow);
            this.toolTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolTabStrip1.Name = "toolTabStrip1";
            // 
            // 
            // 
            this.toolTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip1.SelectedIndex = 0;
            this.toolTabStrip1.Size = new System.Drawing.Size(554, 173);
            this.toolTabStrip1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.142562F);
            this.toolTabStrip1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -64);
            this.toolTabStrip1.TabIndex = 2;
            this.toolTabStrip1.TabStop = false;
            this.toolTabStrip1.ThemeName = "Office2013Dark";
            // 
            // detailWindow
            // 
            this.detailWindow.Caption = null;
            this.detailWindow.Controls.Add(this.radGroupBox2);
            this.detailWindow.Controls.Add(this.radGroupBox1);
            this.detailWindow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.detailWindow.Location = new System.Drawing.Point(4, 27);
            this.detailWindow.Name = "detailWindow";
            this.detailWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.detailWindow.Size = new System.Drawing.Size(546, 142);
            this.detailWindow.Text = "Деталь";
            this.detailWindow.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.idTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.dataSetTextBox);
            this.radGroupBox1.Controls.Add(this.nameTextBox);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radGroupBox1.ForeColor = System.Drawing.Color.White;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radGroupBox1.HeaderText = " Информация";
            this.radGroupBox1.Location = new System.Drawing.Point(-4, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(315, 148);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = " Информация";
            this.radGroupBox1.ThemeName = "Office2013Dark";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.idTextBox.Location = new System.Drawing.Point(142, 64);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(153, 27);
            this.idTextBox.TabIndex = 5;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idTextBox.ThemeName = "Office2013Dark";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel3.Location = new System.Drawing.Point(7, 64);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(131, 25);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Идентификатор:";
            this.radLabel3.ThemeName = "Office2013Dark";
            // 
            // dataSetTextBox
            // 
            this.dataSetTextBox.Enabled = false;
            this.dataSetTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dataSetTextBox.Location = new System.Drawing.Point(142, 111);
            this.dataSetTextBox.Name = "dataSetTextBox";
            this.dataSetTextBox.ReadOnly = true;
            this.dataSetTextBox.Size = new System.Drawing.Size(153, 27);
            this.dataSetTextBox.TabIndex = 3;
            this.dataSetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataSetTextBox.ThemeName = "Office2013Dark";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(142, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(153, 27);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.ThemeName = "Office2013Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel2.Location = new System.Drawing.Point(7, 111);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(125, 25);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Набор деталей:";
            this.radLabel2.ThemeName = "Office2013Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(7, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Имя:";
            this.radLabel1.ThemeName = "Office2013Dark";
            // 
            // toolTabStrip2
            // 
            this.toolTabStrip2.CanUpdateChildIndex = true;
            this.toolTabStrip2.Controls.Add(this.WindowChart);
            this.toolTabStrip2.Location = new System.Drawing.Point(0, 177);
            this.toolTabStrip2.Name = "toolTabStrip2";
            // 
            // 
            // 
            this.toolTabStrip2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.toolTabStrip2.SelectedIndex = 0;
            this.toolTabStrip2.Size = new System.Drawing.Size(554, 310);
            this.toolTabStrip2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.142562F);
            this.toolTabStrip2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 64);
            this.toolTabStrip2.TabIndex = 3;
            this.toolTabStrip2.TabStop = false;
            this.toolTabStrip2.ThemeName = "Office2013Dark";
            // 
            // WindowChart
            // 
            this.WindowChart.Caption = null;
            this.WindowChart.Controls.Add(this.chartResults);
            this.WindowChart.Location = new System.Drawing.Point(4, 27);
            this.WindowChart.Name = "WindowChart";
            this.WindowChart.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.WindowChart.Size = new System.Drawing.Size(546, 279);
            this.WindowChart.Text = "График результатов";
            this.WindowChart.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.OutputInWORDButton);
            this.radGroupBox2.Controls.Add(this.NowTextBox);
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "Данные";
            this.radGroupBox2.Location = new System.Drawing.Point(310, 0);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(240, 143);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Данные";
            this.radGroupBox2.ThemeName = "Office2013Dark";
            // 
            // NowTextBox
            // 
            this.NowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NowTextBox.Enabled = false;
            this.NowTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NowTextBox.Location = new System.Drawing.Point(7, 35);
            this.NowTextBox.Name = "NowTextBox";
            this.NowTextBox.ReadOnly = true;
            this.NowTextBox.Size = new System.Drawing.Size(221, 27);
            this.NowTextBox.TabIndex = 3;
            this.NowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NowTextBox.ThemeName = "Office2013Dark";
            // 
            // OutputInWORDButton
            // 
            this.OutputInWORDButton.Location = new System.Drawing.Point(7, 77);
            this.OutputInWORDButton.Name = "OutputInWORDButton";
            this.OutputInWORDButton.Size = new System.Drawing.Size(221, 59);
            this.OutputInWORDButton.TabIndex = 4;
            this.OutputInWORDButton.Text = "Создание отчета";
            this.OutputInWORDButton.UseVisualStyleBackColor = true;
            this.OutputInWORDButton.Click += new System.EventHandler(this.OutputInWORDButton_Click);
            // 
            // BestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 523);
            this.Controls.Add(this.DOCK);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinimizeBox = false;
            this.Name = "BestResultForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Лучший результат";
            this.ThemeName = "Office2013Dark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.statusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCK)).EndInit();
            this.DOCK.ResumeLayout(false);
            this.baseWindow.ResumeLayout(false);
            this.baseWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip1)).EndInit();
            this.toolTabStrip1.ResumeLayout(false);
            this.detailWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip2)).EndInit();
            this.toolTabStrip2.ResumeLayout(false);
            this.WindowChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NowTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip statusStrip;
        private Telerik.WinControls.UI.RadLabelElement StatusImage;
        private Telerik.WinControls.UI.RadLabelElement StatusLabel;
        private Telerik.WinControls.UI.RadChartView chartResults;
        private Telerik.WinControls.UI.Docking.RadDock DOCK;
        private Telerik.WinControls.UI.Docking.ToolWindow WindowChart;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow baseWindow;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip1;
        private Telerik.WinControls.UI.Docking.ToolWindow detailWindow;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView grid;
        private Telerik.WinControls.UI.RadTextBox dataSetTextBox;
        private Telerik.WinControls.UI.RadTextBox nameTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox idTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadCommandBar commandBar;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton SizesCommand;
        private Telerik.WinControls.UI.CommandBarButton MaterialCommand;
        private Telerik.WinControls.UI.CommandBarButton LoadCommand;
        private Telerik.WinControls.UI.CommandBarButton ConstraintCommand;
        private Telerik.WinControls.UI.CommandBarButton ResultCommand;
        private Telerik.WinControls.UI.CommandBarButton PropertyCommand;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.Button OutputInWORDButton;
        private Telerik.WinControls.UI.RadTextBox NowTextBox;
    }
}
