namespace HBorsWinApp
{
    partial class SettingFormUC
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
            this.fldType = new HBorsWinApp.ComboBoxField();
            this.fldKey = new HBorsWinApp.TextEnglishField();
            this.fldValue = new HBorsWinApp.TextBoxField();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.fldType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldKey, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldValue, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fldType
            // 
            this.fldType.csControlText = "";
            this.fldType.csFieldName = "type";
            this.fldType.csFormField = true;
            this.fldType.csReadOnly = false;
            this.fldType.csTitleText = "نوع";
            this.fldType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldType.driven_action = null;
            this.fldType.enabled_action = null;
            this.fldType.Location = new System.Drawing.Point(298, 3);
            this.fldType.Name = "fldType";
            this.fldType.Size = new System.Drawing.Size(289, 75);
            this.fldType.TabIndex = 3;
            // 
            // fldKey
            // 
            this.fldKey.csControlText = "";
            this.fldKey.csFieldName = "key";
            this.fldKey.csFormField = true;
            this.fldKey.csReadOnly = false;
            this.fldKey.csTitleText = "کلید انگلیسی";
            this.fldKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldKey.driven_action = null;
            this.fldKey.enabled_action = null;
            this.fldKey.Location = new System.Drawing.Point(3, 3);
            this.fldKey.Name = "fldKey";
            this.fldKey.Size = new System.Drawing.Size(289, 75);
            this.fldKey.TabIndex = 4;
            // 
            // fldValue
            // 
            this.fldValue.csControlText = "";
            this.fldValue.csFieldName = "value";
            this.fldValue.csFormField = true;
            this.fldValue.csReadOnly = false;
            this.fldValue.csTitleText = "مقدار";
            this.fldValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldValue.driven_action = null;
            this.fldValue.enabled_action = null;
            this.fldValue.Location = new System.Drawing.Point(298, 84);
            this.fldValue.Name = "fldValue";
            this.fldValue.Size = new System.Drawing.Size(289, 75);
            this.fldValue.TabIndex = 5;
            // 
            // SettingFormUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingFormUC";
            this.Size = new System.Drawing.Size(590, 162);
            this.Load += new System.EventHandler(this.UnitCostFormUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComboBoxField fldType;
        private TextEnglishField fldKey;
        private TextBoxField fldValue;
    }
}
