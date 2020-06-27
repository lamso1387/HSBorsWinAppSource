namespace HBorsWinApp
{
    partial class UnitCostFormUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fldDate = new HBorsWinApp.TextDateField();
            this.flbFund = new HBorsWinApp.ComboBoxField();
            this.fldIssue = new HBorsWinApp.TextNumberField();
            this.fldCancel = new HBorsWinApp.TextNumberField();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flbFund, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldIssue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fldCancel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 195);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fldDate);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 90);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "نمونه صحیح: 1399/02/03    با 1399 شروع به نوشتن کنید";
            // 
            // fldDate
            // 
            this.fldDate.csControlText = "";
            this.fldDate.csFieldName = "hsdate";
            this.fldDate.csFormField = true;
            this.fldDate.csReadOnly = false;
            this.fldDate.csTitleText = "تاریخ";
            this.fldDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.fldDate.driven_action = null;
            this.fldDate.enabled_action = null;
            this.fldDate.Location = new System.Drawing.Point(0, 0);
            this.fldDate.Name = "fldDate";
            this.fldDate.Size = new System.Drawing.Size(314, 71);
            this.fldDate.TabIndex = 1;
            // 
            // flbFund
            // 
            this.flbFund.csControlText = "";
            this.flbFund.csFieldName = "fund_id";
            this.flbFund.csFormField = true;
            this.flbFund.csReadOnly = false;
            this.flbFund.csTitleText = "صندوق";
            this.flbFund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flbFund.driven_action = null;
            this.flbFund.enabled_action = null;
            this.flbFund.Location = new System.Drawing.Point(325, 3);
            this.flbFund.Name = "flbFund";
            this.flbFund.Size = new System.Drawing.Size(317, 91);
            this.flbFund.TabIndex = 0;
            // 
            // fldIssue
            // 
            this.fldIssue.csControlText = "";
            this.fldIssue.csFieldName = "issue_cost";
            this.fldIssue.csFormField = true;
            this.fldIssue.csReadOnly = false;
            this.fldIssue.csTitleText = "هزینه صدور";
            this.fldIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldIssue.driven_action = null;
            this.fldIssue.enabled_action = null;
            this.fldIssue.Location = new System.Drawing.Point(325, 100);
            this.fldIssue.Name = "fldIssue";
            this.fldIssue.Size = new System.Drawing.Size(317, 92);
            this.fldIssue.TabIndex = 2;
            // 
            // fldCancel
            // 
            this.fldCancel.csControlText = "";
            this.fldCancel.csFieldName = "cancel_cost";
            this.fldCancel.csFormField = true;
            this.fldCancel.csReadOnly = false;
            this.fldCancel.csTitleText = "هزینه ابطال";
            this.fldCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldCancel.driven_action = null;
            this.fldCancel.enabled_action = null;
            this.fldCancel.Location = new System.Drawing.Point(3, 100);
            this.fldCancel.Name = "fldCancel";
            this.fldCancel.Size = new System.Drawing.Size(316, 92);
            this.fldCancel.TabIndex = 3;
            // 
            // UnitCostFormUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UnitCostFormUC";
            this.Size = new System.Drawing.Size(645, 195);
            this.Load += new System.EventHandler(this.UnitCostFormUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComboBoxField flbFund;
        private TextDateField fldDate;
        private TextNumberField fldIssue;
        private TextNumberField fldCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
