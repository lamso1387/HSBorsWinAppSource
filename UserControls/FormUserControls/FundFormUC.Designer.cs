namespace HBorsWinApp
{
    partial class FundFormUC
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
            this.flbFundName = new HBorsWinApp.TextBoxField();
            this.fldFundNo = new HBorsWinApp.TextBoxField();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flbFundName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldFundNo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flbFundName
            // 
            this.flbFundName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flbFundName.driven_action = null;
            this.flbFundName.enabled_action = null;
            this.flbFundName.csFieldName = "name";
            this.flbFundName.Location = new System.Drawing.Point(198, 3);
            this.flbFundName.Name = "flbFundName";
            this.flbFundName.Size = new System.Drawing.Size(189, 68);
            this.flbFundName.TabIndex = 0;
            this.flbFundName.csTitleText = "نام صندوق";
            // 
            // fldFundNo
            // 
            this.fldFundNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldFundNo.driven_action = null;
            this.fldFundNo.enabled_action = null;
            this.fldFundNo.csFieldName = "no";
            this.fldFundNo.Location = new System.Drawing.Point(3, 3);
            this.fldFundNo.Name = "fldFundNo";
            this.fldFundNo.Size = new System.Drawing.Size(189, 68);
            this.fldFundNo.TabIndex = 1;
            this.fldFundNo.csTitleText = "شماره صندوق";
            // 
            // FundFormUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FundFormUC";
            this.Size = new System.Drawing.Size(390, 74);
            this.Load += new System.EventHandler(this.FundFormUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TextBoxField flbFundName;
        private TextBoxField fldFundNo;
    }
}
