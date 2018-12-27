namespace Quantization_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Run = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Plots = new System.Windows.Forms.TableLayoutPanel();
            this.topLeft_panel = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_Plot = new System.Windows.Forms.Panel();
            this.plot_plotView = new OxyPlot.WindowsForms.PlotView();
            this.tableLayoutPanel_Back = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton_View = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_PlotOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_SimOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DataOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton_Tools = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_DBSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton_Help = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer_Back = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.topRight_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.bottomRight_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.bottomMiddle_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.bottomLeft_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.plot_SplitContainer1 = new Quantization_Tool.Plot_SplitContainer();
            this.plot_ToolStripContainer_TopMiddle = new Plot_ToolStripContainer();
            this.tableLayoutPanel_Plots.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_Plot.SuspendLayout();
            this.tableLayoutPanel_Back.SuspendLayout();
            this.tableLayoutPanel_bottom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip_Main.SuspendLayout();
            this.toolStripContainer_Back.ContentPanel.SuspendLayout();
            this.toolStripContainer_Back.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topRight_Plot_SplitContainer)).BeginInit();
            this.topRight_Plot_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRight_Plot_SplitContainer)).BeginInit();
            this.bottomRight_Plot_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMiddle_Plot_SplitContainer)).BeginInit();
            this.bottomMiddle_Plot_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeft_Plot_SplitContainer)).BeginInit();
            this.bottomLeft_Plot_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plot_SplitContainer1)).BeginInit();
            this.plot_SplitContainer1.SuspendLayout();
            this.plot_ToolStripContainer_TopMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Run
            // 
            this.button_Run.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Run.Location = new System.Drawing.Point(1700, 11);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(153, 71);
            this.button_Run.TabIndex = 0;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // tableLayoutPanel_Plots
            // 
            this.tableLayoutPanel_Plots.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Plots.ColumnCount = 3;
            this.tableLayoutPanel_Plots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Plots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Plots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Plots.Controls.Add(this.plot_ToolStripContainer_TopMiddle, 1, 0);
            this.tableLayoutPanel_Plots.Controls.Add(this.topRight_Plot_SplitContainer, 2, 0);
            this.tableLayoutPanel_Plots.Controls.Add(this.bottomRight_Plot_SplitContainer, 2, 1);
            this.tableLayoutPanel_Plots.Controls.Add(this.topLeft_panel, 0, 0);
            this.tableLayoutPanel_Plots.Controls.Add(this.bottomMiddle_Plot_SplitContainer, 1, 1);
            this.tableLayoutPanel_Plots.Controls.Add(this.bottomLeft_Plot_SplitContainer, 0, 1);
            this.tableLayoutPanel_Plots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Plots.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Plots.Name = "tableLayoutPanel_Plots";
            this.tableLayoutPanel_Plots.RowCount = 2;
            this.tableLayoutPanel_Plots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Plots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Plots.Size = new System.Drawing.Size(3529, 1526);
            this.tableLayoutPanel_Plots.TabIndex = 7;
            // 
            // topLeft_panel
            // 
            this.topLeft_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLeft_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLeft_panel.Location = new System.Drawing.Point(4, 4);
            this.topLeft_panel.Name = "topLeft_panel";
            this.topLeft_panel.Size = new System.Drawing.Size(1169, 755);
            this.topLeft_panel.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel_Plots);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(3535, 1532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(3555, 1589);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_Plot);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(3535, 1532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_Plot
            // 
            this.panel_Plot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Plot.Controls.Add(this.plot_plotView);
            this.panel_Plot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Plot.Location = new System.Drawing.Point(3, 3);
            this.panel_Plot.Name = "panel_Plot";
            this.panel_Plot.Size = new System.Drawing.Size(3529, 1526);
            this.panel_Plot.TabIndex = 0;
            // 
            // plot_plotView
            // 
            this.plot_plotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot_plotView.Location = new System.Drawing.Point(0, 0);
            this.plot_plotView.Name = "plot_plotView";
            this.plot_plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot_plotView.Size = new System.Drawing.Size(3527, 1524);
            this.plot_plotView.TabIndex = 0;
            this.plot_plotView.Text = "plotView1";
            this.plot_plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot_plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot_plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tableLayoutPanel_Back
            // 
            this.tableLayoutPanel_Back.ColumnCount = 1;
            this.tableLayoutPanel_Back.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Back.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel_Back.Controls.Add(this.tableLayoutPanel_bottom, 0, 1);
            this.tableLayoutPanel_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Back.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Back.Name = "tableLayoutPanel_Back";
            this.tableLayoutPanel_Back.RowCount = 2;
            this.tableLayoutPanel_Back.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Back.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel_Back.Size = new System.Drawing.Size(3561, 1695);
            this.tableLayoutPanel_Back.TabIndex = 9;
            // 
            // tableLayoutPanel_bottom
            // 
            this.tableLayoutPanel_bottom.ColumnCount = 3;
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_bottom.Controls.Add(this.button_Run, 1, 0);
            this.tableLayoutPanel_bottom.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_bottom.Location = new System.Drawing.Point(3, 1598);
            this.tableLayoutPanel_bottom.Name = "tableLayoutPanel_bottom";
            this.tableLayoutPanel_bottom.RowCount = 1;
            this.tableLayoutPanel_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_bottom.Size = new System.Drawing.Size(3555, 94);
            this.tableLayoutPanel_bottom.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_X);
            this.flowLayoutPanel1.Controls.Add(this.label_Y);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1957, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(485, 88);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(3, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(48, 29);
            this.label_X.TabIndex = 0;
            this.label_X.Text = "X : ";
            // 
            // label_Y
            // 
            this.label_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(57, 0);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(59, 29);
            this.label_Y.TabIndex = 1;
            this.label_Y.Text = ", Y : ";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.MinimumSize = new System.Drawing.Size(200, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(200, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(1169, 765);
            // 
            // toolStrip_Main
            // 
            this.toolStrip_Main.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_Main.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton_File,
            this.toolStripSeparator2,
            this.toolStripDropDownButton_View,
            this.toolStripSeparator3,
            this.toolStripDropDownButton_Tools,
            this.toolStripSeparator4,
            this.toolStripDropDownButton_Help});
            this.toolStrip_Main.Location = new System.Drawing.Point(3, 25);
            this.toolStrip_Main.Name = "toolStrip_Main";
            this.toolStrip_Main.Size = new System.Drawing.Size(406, 44);
            this.toolStrip_Main.TabIndex = 1;
            // 
            // toolStripDropDownButton_File
            // 
            this.toolStripDropDownButton_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_NewFile,
            this.toolStripMenuItem_OpenFile,
            this.toolStripMenuItem_SaveFile,
            this.toolStripMenuItem_SaveAsFile,
            this.toolStripSeparator1,
            this.toolStripMenuItem5});
            this.toolStripDropDownButton_File.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_File.Image")));
            this.toolStripDropDownButton_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_File.Name = "toolStripDropDownButton_File";
            this.toolStripDropDownButton_File.Size = new System.Drawing.Size(81, 41);
            this.toolStripDropDownButton_File.Text = "File";
            // 
            // toolStripMenuItem_NewFile
            // 
            this.toolStripMenuItem_NewFile.Name = "toolStripMenuItem_NewFile";
            this.toolStripMenuItem_NewFile.Size = new System.Drawing.Size(362, 42);
            this.toolStripMenuItem_NewFile.Text = "New";
            // 
            // toolStripMenuItem_OpenFile
            // 
            this.toolStripMenuItem_OpenFile.Name = "toolStripMenuItem_OpenFile";
            this.toolStripMenuItem_OpenFile.Size = new System.Drawing.Size(362, 42);
            this.toolStripMenuItem_OpenFile.Text = "Open";
            // 
            // toolStripMenuItem_SaveFile
            // 
            this.toolStripMenuItem_SaveFile.Name = "toolStripMenuItem_SaveFile";
            this.toolStripMenuItem_SaveFile.Size = new System.Drawing.Size(362, 42);
            this.toolStripMenuItem_SaveFile.Text = "Save";
            // 
            // toolStripMenuItem_SaveAsFile
            // 
            this.toolStripMenuItem_SaveAsFile.Name = "toolStripMenuItem_SaveAsFile";
            this.toolStripMenuItem_SaveAsFile.Size = new System.Drawing.Size(362, 42);
            this.toolStripMenuItem_SaveAsFile.Text = "Save As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(359, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(362, 42);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripDropDownButton_View
            // 
            this.toolStripDropDownButton_View.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_PlotOptions,
            this.toolStripMenuItem_SimOptions,
            this.toolStripMenuItem_DataOptions});
            this.toolStripDropDownButton_View.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_View.Image")));
            this.toolStripDropDownButton_View.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_View.Name = "toolStripDropDownButton_View";
            this.toolStripDropDownButton_View.Size = new System.Drawing.Size(98, 41);
            this.toolStripDropDownButton_View.Text = "View";
            // 
            // toolStripMenuItem_PlotOptions
            // 
            this.toolStripMenuItem_PlotOptions.Name = "toolStripMenuItem_PlotOptions";
            this.toolStripMenuItem_PlotOptions.Size = new System.Drawing.Size(352, 42);
            this.toolStripMenuItem_PlotOptions.Text = "Plot Options";
            // 
            // toolStripMenuItem_SimOptions
            // 
            this.toolStripMenuItem_SimOptions.Name = "toolStripMenuItem_SimOptions";
            this.toolStripMenuItem_SimOptions.Size = new System.Drawing.Size(352, 42);
            this.toolStripMenuItem_SimOptions.Text = "Simulation Options";
            // 
            // toolStripMenuItem_DataOptions
            // 
            this.toolStripMenuItem_DataOptions.Name = "toolStripMenuItem_DataOptions";
            this.toolStripMenuItem_DataOptions.Size = new System.Drawing.Size(352, 42);
            this.toolStripMenuItem_DataOptions.Text = "Data Options";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripDropDownButton_Tools
            // 
            this.toolStripDropDownButton_Tools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_DBSetup});
            this.toolStripDropDownButton_Tools.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_Tools.Image")));
            this.toolStripDropDownButton_Tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Tools.Name = "toolStripDropDownButton_Tools";
            this.toolStripDropDownButton_Tools.Size = new System.Drawing.Size(101, 41);
            this.toolStripDropDownButton_Tools.Text = "Tools";
            // 
            // toolStripMenuItem_DBSetup
            // 
            this.toolStripMenuItem_DBSetup.Name = "toolStripMenuItem_DBSetup";
            this.toolStripMenuItem_DBSetup.Size = new System.Drawing.Size(310, 42);
            this.toolStripMenuItem_DBSetup.Text = "Database Setup";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripDropDownButton_Help
            // 
            this.toolStripDropDownButton_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_About});
            this.toolStripDropDownButton_Help.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_Help.Image")));
            this.toolStripDropDownButton_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Help.Name = "toolStripDropDownButton_Help";
            this.toolStripDropDownButton_Help.Size = new System.Drawing.Size(96, 41);
            this.toolStripDropDownButton_Help.Text = "Help";
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(197, 42);
            this.toolStripMenuItem_About.Text = "About";
            // 
            // toolStripContainer_Back
            // 
            this.toolStripContainer_Back.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer_Back.ContentPanel
            // 
            this.toolStripContainer_Back.ContentPanel.Controls.Add(this.tableLayoutPanel_Back);
            this.toolStripContainer_Back.ContentPanel.Controls.Add(this.plot_SplitContainer1);
            this.toolStripContainer_Back.ContentPanel.Size = new System.Drawing.Size(3561, 1695);
            this.toolStripContainer_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer_Back.LeftToolStripPanelVisible = false;
            this.toolStripContainer_Back.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer_Back.Name = "toolStripContainer_Back";
            this.toolStripContainer_Back.RightToolStripPanelVisible = false;
            this.toolStripContainer_Back.Size = new System.Drawing.Size(3561, 1764);
            this.toolStripContainer_Back.TabIndex = 0;
            this.toolStripContainer_Back.Text = "toolStripContainer1";
            // 
            // toolStripContainer_Back.TopToolStripPanel
            // 
            this.toolStripContainer_Back.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer_Back.TopToolStripPanel.Controls.Add(this.toolStrip_Main);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Location = new System.Drawing.Point(39, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // topRight_Plot_SplitContainer
            // 
            this.topRight_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topRight_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRight_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.topRight_Plot_SplitContainer.IsSplitterFixed = true;
            this.topRight_Plot_SplitContainer.Location = new System.Drawing.Point(2356, 4);
            this.topRight_Plot_SplitContainer.Name = "topRight_Plot_SplitContainer";
            this.topRight_Plot_SplitContainer.Panel1Collapsed = true;
            this.topRight_Plot_SplitContainer.Panel1MinSize = 100;
            this.topRight_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 755);
            this.topRight_Plot_SplitContainer.SplitterDistance = 100;
            this.topRight_Plot_SplitContainer.TabIndex = 11;
            // 
            // bottomRight_Plot_SplitContainer
            // 
            this.bottomRight_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomRight_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRight_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bottomRight_Plot_SplitContainer.IsSplitterFixed = true;
            this.bottomRight_Plot_SplitContainer.Location = new System.Drawing.Point(2356, 766);
            this.bottomRight_Plot_SplitContainer.Name = "bottomRight_Plot_SplitContainer";
            this.bottomRight_Plot_SplitContainer.Panel1Collapsed = true;
            this.bottomRight_Plot_SplitContainer.Panel1MinSize = 100;
            this.bottomRight_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 756);
            this.bottomRight_Plot_SplitContainer.SplitterDistance = 100;
            this.bottomRight_Plot_SplitContainer.TabIndex = 0;
            // 
            // bottomMiddle_Plot_SplitContainer
            // 
            this.bottomMiddle_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomMiddle_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomMiddle_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bottomMiddle_Plot_SplitContainer.IsSplitterFixed = true;
            this.bottomMiddle_Plot_SplitContainer.Location = new System.Drawing.Point(1180, 766);
            this.bottomMiddle_Plot_SplitContainer.Name = "bottomMiddle_Plot_SplitContainer";
            this.bottomMiddle_Plot_SplitContainer.Panel1Collapsed = true;
            this.bottomMiddle_Plot_SplitContainer.Panel1MinSize = 100;
            this.bottomMiddle_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 756);
            this.bottomMiddle_Plot_SplitContainer.SplitterDistance = 100;
            this.bottomMiddle_Plot_SplitContainer.TabIndex = 9;
            // 
            // bottomLeft_Plot_SplitContainer
            // 
            this.bottomLeft_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomLeft_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeft_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bottomLeft_Plot_SplitContainer.IsSplitterFixed = true;
            this.bottomLeft_Plot_SplitContainer.Location = new System.Drawing.Point(4, 766);
            this.bottomLeft_Plot_SplitContainer.Name = "bottomLeft_Plot_SplitContainer";
            this.bottomLeft_Plot_SplitContainer.Panel1Collapsed = true;
            this.bottomLeft_Plot_SplitContainer.Panel1MinSize = 100;
            this.bottomLeft_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 756);
            this.bottomLeft_Plot_SplitContainer.SplitterDistance = 100;
            this.bottomLeft_Plot_SplitContainer.TabIndex = 10;
            // 
            // plot_SplitContainer1
            // 
            this.plot_SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plot_SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot_SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.plot_SplitContainer1.IsSplitterFixed = true;
            this.plot_SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.plot_SplitContainer1.Name = "plot_SplitContainer1";
            this.plot_SplitContainer1.Panel1Collapsed = true;
            this.plot_SplitContainer1.Panel1MinSize = 100;
            this.plot_SplitContainer1.Size = new System.Drawing.Size(3561, 1695);
            this.plot_SplitContainer1.SplitterDistance = 100;
            this.plot_SplitContainer1.TabIndex = 0;
            // 
            // plot_ToolStripContainer_TopMiddle
            // 
            // 
            // plot_ToolStripContainer_TopMiddle.ContentPanel
            // 
            this.plot_ToolStripContainer_TopMiddle.ContentPanel.Size = new System.Drawing.Size(1169, 705);
            this.plot_ToolStripContainer_TopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot_ToolStripContainer_TopMiddle.Location = new System.Drawing.Point(1180, 4);
            this.plot_ToolStripContainer_TopMiddle.Name = "plot_ToolStripContainer_TopMiddle";
            this.plot_ToolStripContainer_TopMiddle.Size = new System.Drawing.Size(1169, 755);
            this.plot_ToolStripContainer_TopMiddle.TabIndex = 10;
            this.plot_ToolStripContainer_TopMiddle.Text = "plot_ToolStripContainer1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3561, 1764);
            this.Controls.Add(this.toolStripContainer_Back);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel_Plots.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_Plot.ResumeLayout(false);
            this.tableLayoutPanel_Back.ResumeLayout(false);
            this.tableLayoutPanel_bottom.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.toolStrip_Main.ResumeLayout(false);
            this.toolStrip_Main.PerformLayout();
            this.toolStripContainer_Back.ContentPanel.ResumeLayout(false);
            this.toolStripContainer_Back.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer_Back.TopToolStripPanel.PerformLayout();
            this.toolStripContainer_Back.ResumeLayout(false);
            this.toolStripContainer_Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topRight_Plot_SplitContainer)).EndInit();
            this.topRight_Plot_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomRight_Plot_SplitContainer)).EndInit();
            this.bottomRight_Plot_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomMiddle_Plot_SplitContainer)).EndInit();
            this.bottomMiddle_Plot_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeft_Plot_SplitContainer)).EndInit();
            this.bottomLeft_Plot_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plot_SplitContainer1)).EndInit();
            this.plot_SplitContainer1.ResumeLayout(false);
            this.plot_ToolStripContainer_TopMiddle.ResumeLayout(false);
            this.plot_ToolStripContainer_TopMiddle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Plots;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Back;
        private System.Windows.Forms.Panel topLeft_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_bottom;
        private System.Windows.Forms.Panel panel_Plot;
        private OxyPlot.WindowsForms.PlotView plot_plotView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private Plot_SplitContainer bottomMiddle_Plot_SplitContainer;
        private Plot_SplitContainer bottomRight_Plot_SplitContainer;
        private Plot_SplitContainer bottomLeft_Plot_SplitContainer;
        private Plot_SplitContainer topRight_Plot_SplitContainer;
        private System.Windows.Forms.ToolStrip toolStrip_Main;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SaveAsFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_View;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Tools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Help;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_PlotOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SimOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DataOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DBSetup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.ToolStripContainer toolStripContainer_Back;
        private Plot_SplitContainer plot_SplitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private Plot_ToolStripContainer plot_ToolStripContainer_TopMiddle;
    }
}

