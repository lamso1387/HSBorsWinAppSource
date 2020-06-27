namespace HBorsWinApp
{
    partial class UserFormUC
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
            this.fldName = new HBorsWinApp.TextBoxField();
            this.fldFamily = new HBorsWinApp.TextBoxField();
            this.fldMobile = new HBorsWinApp.TextNumberField();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fldFamily, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldMobile, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fldName
            // 
            this.fldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldName.driven_action = null;
            this.fldName.enabled_action = null;
            this.fldName.csFieldName = "first_name";
            this.fldName.Location = new System.Drawing.Point(298, 3);
            this.fldName.Name = "fldName";
            this.fldName.Size = new System.Drawing.Size(289, 75);
            this.fldName.TabIndex = 0;
            this.fldName.csTitleText = "نام";
            // 
            // fldFamily
            // 
            this.fldFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldFamily.driven_action = null;
            this.fldFamily.enabled_action = null;
            this.fldFamily.csFieldName = "last_name";
            this.fldFamily.Location = new System.Drawing.Point(3, 3);
            this.fldFamily.Name = "fldFamily";
            this.fldFamily.Size = new System.Drawing.Size(289, 75);
            this.fldFamily.TabIndex = 1;
            this.fldFamily.csTitleText = "نام خانوادگی";
            // 
            // fldMobile
            // 
            this.fldMobile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldMobile.driven_action = null;
            this.fldMobile.enabled_action = null;
            this.fldMobile.csFieldName = "mobile";
            this.fldMobile.Location = new System.Drawing.Point(298, 84);
            this.fldMobile.Name = "fldMobile";
            this.fldMobile.Size = new System.Drawing.Size(289, 75);
            this.fldMobile.TabIndex = 2;
            this.fldMobile.csTitleText = "موبایل";
            // 
            // UserFormUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserFormUC";
            this.Size = new System.Drawing.Size(590, 162);
            this.Load += new System.EventHandler(this.UnitCostFormUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TextBoxField fldFamily;
        private TextBoxField fldName;
        private TextNumberField fldMobile;
    }
}
