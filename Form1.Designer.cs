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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bottomRight_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.bottomMiddle_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.bottomLeft_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.topRight_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.topMiddle_Plot_SplitContainer = new Quantization_Tool.Plot_SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel_Plots.SuspendLayout();
            this.topLeft_panel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_Plot.SuspendLayout();
            this.tableLayoutPanel_Back.SuspendLayout();
            this.tableLayoutPanel_bottom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRight_Plot_SplitContainer)).BeginInit();
            this.bottomRight_Plot_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMiddle_Plot_SplitContainer)).BeginInit();
            this.bottomMiddle_Plot_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeft_Plot_SplitContainer)).BeginInit();
            this.bottomLeft_Plot_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topRight_Plot_SplitContainer)).BeginInit();
            this.topRight_Plot_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topMiddle_Plot_SplitContainer)).BeginInit();
            this.topMiddle_Plot_SplitContainer.SuspendLayout();
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
            this.tableLayoutPanel_Plots.Controls.Add(this.bottomRight_Plot_SplitContainer, 2, 1);
            this.tableLayoutPanel_Plots.Controls.Add(this.topLeft_panel, 0, 0);
            this.tableLayoutPanel_Plots.Controls.Add(this.bottomMiddle_Plot_SplitContainer, 1, 1);
            this.tableLayoutPanel_Plots.Controls.Add(this.bottomLeft_Plot_SplitContainer, 0, 1);
            this.tableLayoutPanel_Plots.Controls.Add(this.topRight_Plot_SplitContainer, 2, 0);
            this.tableLayoutPanel_Plots.Controls.Add(this.topMiddle_Plot_SplitContainer, 1, 0);
            this.tableLayoutPanel_Plots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Plots.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Plots.Name = "tableLayoutPanel_Plots";
            this.tableLayoutPanel_Plots.RowCount = 2;
            this.tableLayoutPanel_Plots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Plots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Plots.Size = new System.Drawing.Size(3529, 1595);
            this.tableLayoutPanel_Plots.TabIndex = 7;
            // 
            // topLeft_panel
            // 
            this.topLeft_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLeft_panel.Controls.Add(this.tableLayoutPanel1);
            this.topLeft_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLeft_panel.Location = new System.Drawing.Point(4, 4);
            this.topLeft_panel.Name = "topLeft_panel";
            this.topLeft_panel.Size = new System.Drawing.Size(1169, 790);
            this.topLeft_panel.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel_Plots);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(3535, 1601);
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
            this.tabControl1.Size = new System.Drawing.Size(3555, 1658);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_Plot);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(3535, 1601);
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
            this.panel_Plot.Size = new System.Drawing.Size(3529, 1595);
            this.panel_Plot.TabIndex = 0;
            // 
            // plot_plotView
            // 
            this.plot_plotView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot_plotView.Location = new System.Drawing.Point(0, 0);
            this.plot_plotView.Name = "plot_plotView";
            this.plot_plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot_plotView.Size = new System.Drawing.Size(3527, 1593);
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
            this.tableLayoutPanel_Back.Size = new System.Drawing.Size(3561, 1764);
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
            this.tableLayoutPanel_bottom.Location = new System.Drawing.Point(3, 1667);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 788);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bottomRight_Plot_SplitContainer
            // 
            this.bottomRight_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomRight_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRight_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bottomRight_Plot_SplitContainer.IsSplitterFixed = true;
            this.bottomRight_Plot_SplitContainer.Location = new System.Drawing.Point(2356, 801);
            this.bottomRight_Plot_SplitContainer.Name = "bottomRight_Plot_SplitContainer";
            this.bottomRight_Plot_SplitContainer.Panel1MinSize = 100;
            this.bottomRight_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 790);
            this.bottomRight_Plot_SplitContainer.SplitterDistance = 100;
            this.bottomRight_Plot_SplitContainer.TabIndex = 0;
            // 
            // bottomMiddle_Plot_SplitContainer
            // 
            this.bottomMiddle_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomMiddle_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomMiddle_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bottomMiddle_Plot_SplitContainer.IsSplitterFixed = true;
            this.bottomMiddle_Plot_SplitContainer.Location = new System.Drawing.Point(1180, 801);
            this.bottomMiddle_Plot_SplitContainer.Name = "bottomMiddle_Plot_SplitContainer";
            this.bottomMiddle_Plot_SplitContainer.Panel1MinSize = 100;
            this.bottomMiddle_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 790);
            this.bottomMiddle_Plot_SplitContainer.SplitterDistance = 100;
            this.bottomMiddle_Plot_SplitContainer.TabIndex = 9;
            // 
            // bottomLeft_Plot_SplitContainer
            // 
            this.bottomLeft_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomLeft_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeft_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bottomLeft_Plot_SplitContainer.IsSplitterFixed = true;
            this.bottomLeft_Plot_SplitContainer.Location = new System.Drawing.Point(4, 801);
            this.bottomLeft_Plot_SplitContainer.Name = "bottomLeft_Plot_SplitContainer";
            this.bottomLeft_Plot_SplitContainer.Panel1MinSize = 100;
            this.bottomLeft_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 790);
            this.bottomLeft_Plot_SplitContainer.SplitterDistance = 100;
            this.bottomLeft_Plot_SplitContainer.TabIndex = 10;
            // 
            // topRight_Plot_SplitContainer
            // 
            this.topRight_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topRight_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRight_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.topRight_Plot_SplitContainer.IsSplitterFixed = true;
            this.topRight_Plot_SplitContainer.Location = new System.Drawing.Point(2356, 4);
            this.topRight_Plot_SplitContainer.Name = "topRight_Plot_SplitContainer";
            this.topRight_Plot_SplitContainer.Panel1MinSize = 100;
            this.topRight_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 790);
            this.topRight_Plot_SplitContainer.SplitterDistance = 100;
            this.topRight_Plot_SplitContainer.TabIndex = 11;
            // 
            // topMiddle_Plot_SplitContainer
            // 
            this.topMiddle_Plot_SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topMiddle_Plot_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topMiddle_Plot_SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.topMiddle_Plot_SplitContainer.IsSplitterFixed = true;
            this.topMiddle_Plot_SplitContainer.Location = new System.Drawing.Point(1180, 4);
            this.topMiddle_Plot_SplitContainer.Name = "topMiddle_Plot_SplitContainer";
            this.topMiddle_Plot_SplitContainer.Panel1MinSize = 100;
            this.topMiddle_Plot_SplitContainer.Size = new System.Drawing.Size(1169, 790);
            this.topMiddle_Plot_SplitContainer.SplitterDistance = 100;
            this.topMiddle_Plot_SplitContainer.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Location = new System.Drawing.Point(0, 688);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1167, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3561, 1764);
            this.Controls.Add(this.tableLayoutPanel_Back);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel_Plots.ResumeLayout(false);
            this.topLeft_panel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_Plot.ResumeLayout(false);
            this.tableLayoutPanel_Back.ResumeLayout(false);
            this.tableLayoutPanel_bottom.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRight_Plot_SplitContainer)).EndInit();
            this.bottomRight_Plot_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomMiddle_Plot_SplitContainer)).EndInit();
            this.bottomMiddle_Plot_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeft_Plot_SplitContainer)).EndInit();
            this.bottomLeft_Plot_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topRight_Plot_SplitContainer)).EndInit();
            this.topRight_Plot_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topMiddle_Plot_SplitContainer)).EndInit();
            this.topMiddle_Plot_SplitContainer.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private Plot_SplitContainer bottomMiddle_Plot_SplitContainer;
        private Plot_SplitContainer bottomRight_Plot_SplitContainer;
        private Plot_SplitContainer bottomLeft_Plot_SplitContainer;
        private Plot_SplitContainer topRight_Plot_SplitContainer;
        private Plot_SplitContainer topMiddle_Plot_SplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

