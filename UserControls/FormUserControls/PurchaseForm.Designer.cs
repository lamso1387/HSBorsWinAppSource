namespace HBorsWinApp
{
    partial class  PurchaseForm
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
            this.fldPurchaser = new HBorsWinApp.ComboBoxField();
            this.fldCalcType = new HBorsWinApp.ComboBoxField();
            this.fldAmountPercent = new HBorsWinApp.NumbericField();
            this.fldPartner = new HBorsWinApp.ComboBoxField();
            this.flbBankPercent = new HBorsWinApp.TextNumberField();
            this.fldBankIntrest = new HBorsWinApp.TextNumberField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fldKasrAz = new HBorsWinApp.NumbericField();
            this.fldKasrTa = new HBorsWinApp.NumbericField();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.fldAmount = new HBorsWinApp.TextNumberField();
            this.pnlLblAmount = new System.Windows.Forms.Panel();
            this.lblAmountLeft = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.pnlLblAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.fldPurchaser, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldCalcType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldAmountPercent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldPartner, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.flbBankPercent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fldBankIntrest, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlAmount, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fldPurchaser
            // 
            this.fldPurchaser.csControlText = "";
            this.fldPurchaser.csFieldName = "buyer_id";
            this.fldPurchaser.csFormField = true;
            this.fldPurchaser.csReadOnly = false;
            this.fldPurchaser.csTitleText = "سرمایه گذار*";
            this.fldPurchaser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldPurchaser.driven_action = null;
            this.fldPurchaser.enabled_action = null;
            this.fldPurchaser.Location = new System.Drawing.Point(509, 3);
            this.fldPurchaser.Name = "fldPurchaser";
            this.fldPurchaser.Size = new System.Drawing.Size(248, 97);
            this.fldPurchaser.TabIndex = 0;
            // 
            // fldCalcType
            // 
            this.fldCalcType.csControlText = "";
            this.fldCalcType.csFieldName = "calc_type";
            this.fldCalcType.csFormField = false;
            this.fldCalcType.csReadOnly = false;
            this.fldCalcType.csTitleText = "نحوه محاسبه*";
            this.fldCalcType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldCalcType.driven_action = null;
            this.fldCalcType.enabled_action = null;
            this.fldCalcType.Location = new System.Drawing.Point(256, 3);
            this.fldCalcType.Name = "fldCalcType";
            this.fldCalcType.Size = new System.Drawing.Size(247, 97);
            this.fldCalcType.TabIndex = 1;
            // 
            // fldAmountPercent
            // 
            this.fldAmountPercent.csControlText = "";
            this.fldAmountPercent.csFieldName = "percent";
            this.fldAmountPercent.csFormField = false;
            this.fldAmountPercent.csReadOnly = false;
            this.fldAmountPercent.csTitleText = "درصد تسهیم";
            this.fldAmountPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldAmountPercent.driven_action = null;
            this.fldAmountPercent.enabled_action = null;
            this.fldAmountPercent.Location = new System.Drawing.Point(3, 3);
            this.fldAmountPercent.Name = "fldAmountPercent";
            this.fldAmountPercent.Size = new System.Drawing.Size(247, 97);
            this.fldAmountPercent.TabIndex = 2;
            // 
            // fldPartner
            // 
            this.fldPartner.csControlText = "";
            this.fldPartner.csFieldName = "bank_copartner_id";
            this.fldPartner.csFormField = true;
            this.fldPartner.csReadOnly = false;
            this.fldPartner.csTitleText = "شریک";
            this.fldPartner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldPartner.driven_action = null;
            this.fldPartner.enabled_action = null;
            this.fldPartner.Location = new System.Drawing.Point(509, 209);
            this.fldPartner.Name = "fldPartner";
            this.fldPartner.Size = new System.Drawing.Size(248, 97);
            this.fldPartner.TabIndex = 6;
            // 
            // flbBankPercent
            // 
            this.flbBankPercent.csControlText = "";
            this.flbBankPercent.csFieldName = "bank_copartner_percent";
            this.flbBankPercent.csFormField = true;
            this.flbBankPercent.csReadOnly = false;
            this.flbBankPercent.csTitleText = "سود بانکی شراکت";
            this.flbBankPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flbBankPercent.driven_action = null;
            this.flbBankPercent.enabled_action = null;
            this.flbBankPercent.Location = new System.Drawing.Point(256, 209);
            this.flbBankPercent.Name = "flbBankPercent";
            this.flbBankPercent.Size = new System.Drawing.Size(247, 97);
            this.flbBankPercent.TabIndex = 7;
            // 
            // fldBankIntrest
            // 
            this.fldBankIntrest.csControlText = "";
            this.fldBankIntrest.csFieldName = "bank_copartner_intrest";
            this.fldBankIntrest.csFormField = true;
            this.fldBankIntrest.csReadOnly = false;
            this.fldBankIntrest.csTitleText = "درصد شراکت";
            this.fldBankIntrest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldBankIntrest.driven_action = null;
            this.fldBankIntrest.enabled_action = null;
            this.fldBankIntrest.Location = new System.Drawing.Point(3, 209);
            this.fldBankIntrest.Name = "fldBankIntrest";
            this.fldBankIntrest.Size = new System.Drawing.Size(247, 97);
            this.fldBankIntrest.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.fldKasrAz);
            this.panel1.Controls.Add(this.fldKasrTa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(256, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 97);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(99, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(57, 97);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fldKasrAz
            // 
            this.fldKasrAz.csControlText = "";
            this.fldKasrAz.csFieldName = "kasr_az";
            this.fldKasrAz.csFormField = false;
            this.fldKasrAz.csReadOnly = false;
            this.fldKasrAz.csTitleText = "صورت کسر";
            this.fldKasrAz.Dock = System.Windows.Forms.DockStyle.Right;
            this.fldKasrAz.driven_action = null;
            this.fldKasrAz.enabled_action = null;
            this.fldKasrAz.Location = new System.Drawing.Point(156, 0);
            this.fldKasrAz.Name = "fldKasrAz";
            this.fldKasrAz.Size = new System.Drawing.Size(91, 97);
            this.fldKasrAz.TabIndex = 3;
            // 
            // fldKasrTa
            // 
            this.fldKasrTa.csControlText = "";
            this.fldKasrTa.csFieldName = "kasr_ta";
            this.fldKasrTa.csFormField = false;
            this.fldKasrTa.csReadOnly = false;
            this.fldKasrTa.csTitleText = "مخرج کسر";
            this.fldKasrTa.Dock = System.Windows.Forms.DockStyle.Left;
            this.fldKasrTa.driven_action = null;
            this.fldKasrTa.enabled_action = null;
            this.fldKasrTa.Location = new System.Drawing.Point(0, 0);
            this.fldKasrTa.Name = "fldKasrTa";
            this.fldKasrTa.Size = new System.Drawing.Size(99, 97);
            this.fldKasrTa.TabIndex = 4;
            // 
            // pnlAmount
            // 
            this.pnlAmount.Controls.Add(this.fldAmount);
            this.pnlAmount.Controls.Add(this.pnlLblAmount);
            this.pnlAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAmount.Location = new System.Drawing.Point(509, 106);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(248, 97);
            this.pnlAmount.TabIndex = 9;
            // 
            // fldAmount
            // 
            this.fldAmount.csControlText = "";
            this.fldAmount.csFieldName = "amount";
            this.fldAmount.csFormField = true;
            this.fldAmount.csReadOnly = false;
            this.fldAmount.csTitleText = "مبلغ*";
            this.fldAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldAmount.driven_action = null;
            this.fldAmount.enabled_action = null;
            this.fldAmount.Location = new System.Drawing.Point(0, 0);
            this.fldAmount.Name = "fldAmount";
            this.fldAmount.Size = new System.Drawing.Size(248, 76);
            this.fldAmount.TabIndex = 5;
            // 
            // pnlLblAmount
            // 
            this.pnlLblAmount.Controls.Add(this.lblAmountLeft);
            this.pnlLblAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLblAmount.Location = new System.Drawing.Point(0, 76);
            this.pnlLblAmount.Name = "pnlLblAmount";
            this.pnlLblAmount.Size = new System.Drawing.Size(248, 21);
            this.pnlLblAmount.TabIndex = 6;
            // 
            // lblAmountLeft
            // 
            this.lblAmountLeft.AutoSize = true;
            this.lblAmountLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAmountLeft.Location = new System.Drawing.Point(101, 0);
            this.lblAmountLeft.Name = "lblAmountLeft";
            this.lblAmountLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAmountLeft.Size = new System.Drawing.Size(147, 20);
            this.lblAmountLeft.TabIndex = 6;
            this.lblAmountLeft.Text = "مبلغ قابل تخصیص: نامشخص";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "PurchaseForm";
            this.Size = new System.Drawing.Size(760, 309);
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlLblAmount.ResumeLayout(false);
            this.pnlLblAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComboBoxField fldPurchaser;
        private TextNumberField fldAmount;
        private ComboBoxField fldPartner;
        private TextNumberField flbBankPercent;
        private TextNumberField fldBankIntrest;
        private NumbericField fldAmountPercent;
        private System.Windows.Forms.Panel panel1;
        private NumbericField fldKasrAz;
        private NumbericField fldKasrTa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private ComboBoxField fldCalcType;
        private System.Windows.Forms.Label lblAmountLeft;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.Panel pnlLblAmount;
    }
}
