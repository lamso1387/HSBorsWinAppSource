namespace HBorsWinApp
{
    partial class DashboardViewUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDashboard = new HBorsWinApp.LoaderPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.a1Panel1 = new SRL.A1Panel();
            this.lblAverageTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLastRow = new HBorsWinApp.DataGridLastRow();
            this.dgvDashboard = new HBorsWinApp.DataGridList();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvUserProfitLoss = new HBorsWinApp.DataGridList();
            this.profit_losses_loadingCircle = new SRL.WinTools.LoadingCircleControl.LoadingCircle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlDashboard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.a1Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserProfitLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDashboard.Controls.Add(this.panel1);
            this.pnlDashboard.Controls.Add(this.dgvLastRow);
            this.pnlDashboard.Controls.Add(this.dgvDashboard);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(4, 3);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(890, 233);
            this.pnlDashboard.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 160);
            this.panel1.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(315, 160);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            title1.Name = "Title1";
            title1.Text = "سهم صندوق ها از سود";
            this.chart1.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(561, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 160);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.a1Panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 55);
            this.panel3.TabIndex = 5;
            // 
            // a1Panel1
            // 
            this.a1Panel1.BorderColor = System.Drawing.Color.Gray;
            this.a1Panel1.Controls.Add(this.lblAverageTotalAmount);
            this.a1Panel1.Controls.Add(this.label1);
            this.a1Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a1Panel1.GradientEndColor = System.Drawing.Color.Gray;
            this.a1Panel1.GradientStartColor = System.Drawing.Color.White;
            this.a1Panel1.Image = null;
            this.a1Panel1.ImageLocation = new System.Drawing.Point(4, 4);
            this.a1Panel1.Location = new System.Drawing.Point(0, 0);
            this.a1Panel1.Name = "a1Panel1";
            this.a1Panel1.Size = new System.Drawing.Size(329, 55);
            this.a1Panel1.TabIndex = 2;
            // 
            // lblAverageTotalAmount
            // 
            this.lblAverageTotalAmount.AutoSize = true;
            this.lblAverageTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAverageTotalAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAverageTotalAmount.Location = new System.Drawing.Point(66, 0);
            this.lblAverageTotalAmount.Name = "lblAverageTotalAmount";
            this.lblAverageTotalAmount.Size = new System.Drawing.Size(52, 20);
            this.lblAverageTotalAmount.TabIndex = 1;
            this.lblAverageTotalAmount.Text = "..مقدار..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(118, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "میانگین سود کل سرمایه گذاری در صندوق";
            // 
            // dgvLastRow
            // 
            this.dgvLastRow.AllowUserToAddRows = false;
            this.dgvLastRow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLastRow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLastRow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLastRow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLastRow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLastRow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLastRow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLastRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLastRow.ColumnHeadersVisible = false;
            this.dgvLastRow.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLastRow.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLastRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLastRow.entity_count_all = 0;
            this.dgvLastRow.entity_page_count = 0;
            this.dgvLastRow.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLastRow.LastRowGrid = null;
            this.dgvLastRow.Location = new System.Drawing.Point(0, 44);
            this.dgvLastRow.Name = "dgvLastRow";
            this.dgvLastRow.page_size = 0;
            this.dgvLastRow.page_start = 0;
            this.dgvLastRow.ReadOnly = true;
            this.dgvLastRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvLastRow.RowHeadersVisible = false;
            this.dgvLastRow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLastRow.set_dgv_height_to_all_rows = false;
            this.dgvLastRow.Size = new System.Drawing.Size(890, 29);
            this.dgvLastRow.TabIndex = 1;
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AllowUserToAddRows = false;
            this.dgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDashboard.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDashboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDashboard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDashboard.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDashboard.entity_count_all = 0;
            this.dgvDashboard.entity_page_count = 0;
            this.dgvDashboard.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDashboard.LastRowGrid = null;
            this.dgvDashboard.Location = new System.Drawing.Point(0, 0);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.page_size = 0;
            this.dgvDashboard.page_start = 0;
            this.dgvDashboard.ReadOnly = true;
            this.dgvDashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDashboard.RowHeadersVisible = false;
            this.dgvDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashboard.set_dgv_height_to_all_rows = false;
            this.dgvDashboard.Size = new System.Drawing.Size(890, 44);
            this.dgvDashboard.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlDashboard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.81395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.18605F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(898, 430);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 242);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 185);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvUserProfitLoss);
            this.tabPage1.Controls.Add(this.profit_losses_loadingCircle);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "سود و زیان سرمایه گذاران";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvUserProfitLoss
            // 
            this.dgvUserProfitLoss.AllowUserToAddRows = false;
            this.dgvUserProfitLoss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserProfitLoss.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUserProfitLoss.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUserProfitLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserProfitLoss.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUserProfitLoss.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserProfitLoss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserProfitLoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserProfitLoss.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserProfitLoss.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserProfitLoss.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUserProfitLoss.entity_count_all = 0;
            this.dgvUserProfitLoss.entity_page_count = 0;
            this.dgvUserProfitLoss.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUserProfitLoss.LastRowGrid = null;
            this.dgvUserProfitLoss.Location = new System.Drawing.Point(3, 3);
            this.dgvUserProfitLoss.Name = "dgvUserProfitLoss";
            this.dgvUserProfitLoss.page_size = 0;
            this.dgvUserProfitLoss.page_start = 0;
            this.dgvUserProfitLoss.ReadOnly = true;
            this.dgvUserProfitLoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvUserProfitLoss.RowHeadersVisible = false;
            this.dgvUserProfitLoss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserProfitLoss.set_dgv_height_to_all_rows = false;
            this.dgvUserProfitLoss.Size = new System.Drawing.Size(844, 44);
            this.dgvUserProfitLoss.TabIndex = 5;
            // 
            // profit_losses_loadingCircle
            // 
            this.profit_losses_loadingCircle.Active = false;
            this.profit_losses_loadingCircle.Color = System.Drawing.Color.Black;
            this.profit_losses_loadingCircle.Dock = System.Windows.Forms.DockStyle.Right;
            this.profit_losses_loadingCircle.InnerCircleRadius = 5;
            this.profit_losses_loadingCircle.Location = new System.Drawing.Point(847, 3);
            this.profit_losses_loadingCircle.Name = "profit_losses_loadingCircle";
            this.profit_losses_loadingCircle.NumberSpoke = 12;
            this.profit_losses_loadingCircle.OuterCircleRadius = 11;
            this.profit_losses_loadingCircle.RotationSpeed = 100;
            this.profit_losses_loadingCircle.Size = new System.Drawing.Size(34, 146);
            this.profit_losses_loadingCircle.SpokeThickness = 2;
            this.profit_losses_loadingCircle.StylePreset = SRL.WinTools.LoadingCircleControl.LoadingCircle.StylePresets.MacOSX;
            this.profit_losses_loadingCircle.TabIndex = 4;
            this.profit_losses_loadingCircle.Text = "profit_losses_loadingCircle";
            this.profit_losses_loadingCircle.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(884, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "سود بر اساس زمان سرمایه گذاری هر شخص";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DashboardViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardViewUC";
            this.Size = new System.Drawing.Size(898, 430);
            this.Load += new System.EventHandler(this.ProductsUC_Load);
            this.pnlDashboard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.a1Panel1.ResumeLayout(false);
            this.a1Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserProfitLoss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LoaderPanel pnlDashboard;
        private DataGridList dgvDashboard;
        private DataGridLastRow dgvLastRow;
        private SRL.A1Panel a1Panel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAverageTotalAmount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private SRL.WinTools.LoadingCircleControl.LoadingCircle profit_losses_loadingCircle;
        private DataGridList dgvUserProfitLoss;
    }
}
