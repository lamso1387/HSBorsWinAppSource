namespace HBorsWinApp.UserControls.DashboardUserControls
{
    partial class FundDashboardUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFundStatus = new HBorsWinApp.DataGridList();
            this.dgvLastRow = new HBorsWinApp.DataGridLastRow();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastRow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFundStatus
            // 
            this.dgvFundStatus.AllowUserToAddRows = false;
            this.dgvFundStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFundStatus.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFundStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFundStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFundStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFundStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFundStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFundStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFundStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFundStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFundStatus.entity_count_all = 0;
            this.dgvFundStatus.entity_page_count = 0;
            this.dgvFundStatus.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFundStatus.LastRowGrid = null;
            this.dgvFundStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvFundStatus.Name = "dgvFundStatus";
            this.dgvFundStatus.page_size = 0;
            this.dgvFundStatus.page_start = 0;
            this.dgvFundStatus.ReadOnly = true;
            this.dgvFundStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFundStatus.RowHeadersVisible = false;
            this.dgvFundStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFundStatus.Size = new System.Drawing.Size(928, 336);
            this.dgvFundStatus.TabIndex = 0;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLastRow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLastRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLastRow.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLastRow.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLastRow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLastRow.entity_count_all = 0;
            this.dgvLastRow.entity_page_count = 0;
            this.dgvLastRow.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLastRow.LastRowGrid = null;
            this.dgvLastRow.Location = new System.Drawing.Point(0, 336);
            this.dgvLastRow.Name = "dgvLastRow";
            this.dgvLastRow.page_size = 0;
            this.dgvLastRow.page_start = 0;
            this.dgvLastRow.ReadOnly = true;
            this.dgvLastRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvLastRow.RowHeadersVisible = false;
            this.dgvLastRow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLastRow.Size = new System.Drawing.Size(928, 37);
            this.dgvLastRow.TabIndex = 1;
            // 
            // FundDashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFundStatus);
            this.Controls.Add(this.dgvLastRow);
            this.Name = "FundDashboardUC";
            this.Size = new System.Drawing.Size(928, 373);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLastRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridList dgvFundStatus;
        private DataGridLastRow dgvLastRow;
    }
}
