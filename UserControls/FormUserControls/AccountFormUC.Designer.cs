namespace HBorsWinApp
{
    partial class AccountFormUC
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
            this.fldFund = new HBorsWinApp.ComboBoxField();
            this.fldAccounter = new HBorsWinApp.ComboBoxField();
            this.fldNo = new HBorsWinApp.TextBoxField();
            this.fldName = new HBorsWinApp.TextBoxField();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fldName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fldFund, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldAccounter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldNo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fldFund
            // 
            this.fldFund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldFund.driven_action = null;
            this.fldFund.enabled_action = null;
            this.fldFund.csFieldName = "fund_id";
            this.fldFund.Location = new System.Drawing.Point(298, 3);
            this.fldFund.Name = "fldFund";
            this.fldFund.Size = new System.Drawing.Size(289, 75);
            this.fldFund.TabIndex = 3;
            this.fldFund.csTitleText = "صندوق";
            // 
            // fldAccounter
            // 
            this.fldAccounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldAccounter.driven_action = null;
            this.fldAccounter.enabled_action = null;
            this.fldAccounter.csFieldName = "accounter_id";
            this.fldAccounter.Location = new System.Drawing.Point(3, 3);
            this.fldAccounter.Name = "fldAccounter";
            this.fldAccounter.Size = new System.Drawing.Size(289, 75);
            this.fldAccounter.TabIndex = 4;
            this.fldAccounter.csTitleText = "صاحب حساب";
            // 
            // fldNo
            // 
            this.fldNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldNo.driven_action = null;
            this.fldNo.enabled_action = null;
            this.fldNo.csFieldName = "no";
            this.fldNo.Location = new System.Drawing.Point(3, 84);
            this.fldNo.Name = "fldNo";
            this.fldNo.Size = new System.Drawing.Size(289, 75);
            this.fldNo.TabIndex = 5;
            this.fldNo.csTitleText = "شماره حساب";
            // 
            // fldName
            // 
            this.fldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldName.driven_action = null;
            this.fldName.enabled_action = null;
            this.fldName.csFieldName = "name";
            this.fldName.Location = new System.Drawing.Point(298, 84);
            this.fldName.Name = "fldName";
            this.fldName.Size = new System.Drawing.Size(289, 75);
            this.fldName.TabIndex = 6;
            this.fldName.csTitleText = "نام حساب";
            // 
            // AccountFormUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccountFormUC";
            this.Size = new System.Drawing.Size(590, 162);
            this.Load += new System.EventHandler(this.UnitCostFormUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TextBoxField fldName;
        private ComboBoxField fldFund;
        private ComboBoxField fldAccounter;
        private TextBoxField fldNo;
    }
}
