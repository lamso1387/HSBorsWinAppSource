namespace HBorsWinApp
{
    partial class DepositFormUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fldFund = new HBorsWinApp.ComboBoxField();
            this.fldUnit = new HBorsWinApp.ComboBoxField();
            this.fldAccount = new HBorsWinApp.ComboBoxField();
            this.fldCount = new HBorsWinApp.NumbericField();
            this.fldAmount = new HBorsWinApp.TextNumberField();
            this.fldIssueCost = new HBorsWinApp.TextNumberField();
            this.btnInsertPurchase = new HBorsWinApp.CustomControls.ButtonInsert();
            this.dataGridView1 = new HBorsWinApp.DataGridList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new HBorsWinApp.CustomControls.ButtonEdit();
            this.btnRemove = new HBorsWinApp.CustomControls.ButtonDelete();
            this.buyerGridLastRow = new HBorsWinApp.DataGridLastRow();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerGridLastRow)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.fldFund, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldUnit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fldAccount, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.fldCount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fldAmount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fldIssueCost, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fldFund
            // 
            this.fldFund.csControlText = "";
            this.fldFund.csFieldName = "fund_id";
            this.fldFund.csFormField = true;
            this.fldFund.csReadOnly = false;
            this.fldFund.csTitleText = "نام صندوق";
            this.fldFund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldFund.driven_action = null;
            this.fldFund.enabled_action = null;
            this.fldFund.Location = new System.Drawing.Point(483, 3);
            this.fldFund.Name = "fldFund";
            this.fldFund.Size = new System.Drawing.Size(314, 60);
            this.fldFund.TabIndex = 3;
            // 
            // fldUnit
            // 
            this.fldUnit.csControlText = "";
            this.fldUnit.csFieldName = "unit_cost_id";
            this.fldUnit.csFormField = true;
            this.fldUnit.csReadOnly = false;
            this.fldUnit.csTitleText = "تاریخ صدور";
            this.fldUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldUnit.driven_action = null;
            this.fldUnit.enabled_action = null;
            this.fldUnit.Location = new System.Drawing.Point(3, 3);
            this.fldUnit.Name = "fldUnit";
            this.fldUnit.Size = new System.Drawing.Size(314, 60);
            this.fldUnit.TabIndex = 4;
            // 
            // fldAccount
            // 
            this.fldAccount.csControlText = "";
            this.fldAccount.csFieldName = "account_id";
            this.fldAccount.csFormField = true;
            this.fldAccount.csReadOnly = false;
            this.fldAccount.csTitleText = "حساب";
            this.fldAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldAccount.driven_action = null;
            this.fldAccount.enabled_action = null;
            this.fldAccount.Location = new System.Drawing.Point(483, 135);
            this.fldAccount.Name = "fldAccount";
            this.fldAccount.Size = new System.Drawing.Size(314, 62);
            this.fldAccount.TabIndex = 7;
            // 
            // fldCount
            // 
            this.fldCount.csControlText = "";
            this.fldCount.csFieldName = "count";
            this.fldCount.csFormField = true;
            this.fldCount.csReadOnly = false;
            this.fldCount.csTitleText = "تعداد";
            this.fldCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldCount.driven_action = null;
            this.fldCount.enabled_action = null;
            this.fldCount.Location = new System.Drawing.Point(483, 69);
            this.fldCount.Name = "fldCount";
            this.fldCount.Size = new System.Drawing.Size(314, 60);
            this.fldCount.TabIndex = 11;
            // 
            // fldAmount
            // 
            this.fldAmount.csControlText = "";
            this.fldAmount.csFieldName = "amount";
            this.fldAmount.csFormField = true;
            this.fldAmount.csReadOnly = false;
            this.fldAmount.csTitleText = "مبلغ";
            this.fldAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldAmount.driven_action = null;
            this.fldAmount.Enabled = false;
            this.fldAmount.enabled_action = null;
            this.fldAmount.Location = new System.Drawing.Point(3, 135);
            this.fldAmount.Name = "fldAmount";
            this.fldAmount.Size = new System.Drawing.Size(314, 62);
            this.fldAmount.TabIndex = 9;
            // 
            // fldIssueCost
            // 
            this.fldIssueCost.csControlText = "";
            this.fldIssueCost.csFieldName = "issue_cost_";
            this.fldIssueCost.csFormField = false;
            this.fldIssueCost.csReadOnly = true;
            this.fldIssueCost.csTitleText = "هزینه صدور هر واحد";
            this.fldIssueCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldIssueCost.driven_action = null;
            this.fldIssueCost.Enabled = false;
            this.fldIssueCost.enabled_action = null;
            this.fldIssueCost.Location = new System.Drawing.Point(3, 69);
            this.fldIssueCost.Name = "fldIssueCost";
            this.fldIssueCost.Size = new System.Drawing.Size(314, 60);
            this.fldIssueCost.TabIndex = 12;
            // 
            // btnInsertPurchase
            // 
            this.btnInsertPurchase.Active = false;
            this.btnInsertPurchase.Activecolor = System.Drawing.Color.Silver;
            this.btnInsertPurchase.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInsertPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsertPurchase.BorderRadius = 0;
            this.btnInsertPurchase.ButtonText = "افزودن سرمایه گذار";
            this.btnInsertPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertPurchase.DisabledColor = System.Drawing.Color.Gray;
            this.btnInsertPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertPurchase.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInsertPurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInsertPurchase.Iconimage = null;
            this.btnInsertPurchase.Iconimage_right = null;
            this.btnInsertPurchase.Iconimage_right_Selected = null;
            this.btnInsertPurchase.Iconimage_Selected = null;
            this.btnInsertPurchase.IconMarginLeft = 0;
            this.btnInsertPurchase.IconMarginRight = 0;
            this.btnInsertPurchase.IconRightVisible = false;
            this.btnInsertPurchase.IconRightZoom = 0D;
            this.btnInsertPurchase.IconVisible = false;
            this.btnInsertPurchase.IconZoom = 90D;
            this.btnInsertPurchase.IsTab = false;
            this.btnInsertPurchase.Location = new System.Drawing.Point(0, 0);
            this.btnInsertPurchase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertPurchase.Name = "btnInsertPurchase";
            this.btnInsertPurchase.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnInsertPurchase.OnHovercolor = System.Drawing.Color.SlateGray;
            this.btnInsertPurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsertPurchase.selected = false;
            this.btnInsertPurchase.Size = new System.Drawing.Size(111, 30);
            this.btnInsertPurchase.TabIndex = 6;
            this.btnInsertPurchase.Text = "افزودن سرمایه گذار";
            this.btnInsertPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsertPurchase.Textcolor = System.Drawing.Color.White;
            this.btnInsertPurchase.TextFont = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInsertPurchase.Click += new System.EventHandler(this.btnInsertPurchase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.entity_count_all = 0;
            this.dataGridView1.entity_page_count = 0;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.LastRowGrid = null;
            this.dataGridView1.Location = new System.Drawing.Point(111, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.page_size = 0;
            this.dataGridView1.page_start = 0;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.set_dgv_height_to_all_rows = false;
            this.dataGridView1.Size = new System.Drawing.Size(689, 172);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnInsertPurchase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 200);
            this.panel1.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.Active = false;
            this.btnEdit.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "ویرایش";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = null;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 90D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(0, 58);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.BlueViolet;
            this.btnEdit.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(111, 30);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Active = false;
            this.btnRemove.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemove.BorderRadius = 0;
            this.btnRemove.ButtonText = "حذف";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRemove.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemove.Iconimage = null;
            this.btnRemove.Iconimage_right = null;
            this.btnRemove.Iconimage_right_Selected = null;
            this.btnRemove.Iconimage_Selected = null;
            this.btnRemove.IconMarginLeft = 0;
            this.btnRemove.IconMarginRight = 0;
            this.btnRemove.IconRightVisible = true;
            this.btnRemove.IconRightZoom = 0D;
            this.btnRemove.IconVisible = true;
            this.btnRemove.IconZoom = 90D;
            this.btnRemove.IsTab = false;
            this.btnRemove.Location = new System.Drawing.Point(0, 30);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Normalcolor = System.Drawing.Color.Red;
            this.btnRemove.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemove.selected = false;
            this.btnRemove.Size = new System.Drawing.Size(111, 28);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "حذف";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.Textcolor = System.Drawing.Color.White;
            this.btnRemove.TextFont = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // buyerGridLastRow
            // 
            this.buyerGridLastRow.AllowUserToAddRows = false;
            this.buyerGridLastRow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buyerGridLastRow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.buyerGridLastRow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyerGridLastRow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buyerGridLastRow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.buyerGridLastRow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buyerGridLastRow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.buyerGridLastRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyerGridLastRow.ColumnHeadersVisible = false;
            this.buyerGridLastRow.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.buyerGridLastRow.DefaultCellStyle = dataGridViewCellStyle4;
            this.buyerGridLastRow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buyerGridLastRow.entity_count_all = 0;
            this.buyerGridLastRow.entity_page_count = 0;
            this.buyerGridLastRow.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.buyerGridLastRow.LastRowGrid = null;
            this.buyerGridLastRow.Location = new System.Drawing.Point(111, 372);
            this.buyerGridLastRow.Name = "buyerGridLastRow";
            this.buyerGridLastRow.page_size = 0;
            this.buyerGridLastRow.page_start = 0;
            this.buyerGridLastRow.ReadOnly = true;
            this.buyerGridLastRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buyerGridLastRow.RowHeadersVisible = false;
            this.buyerGridLastRow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buyerGridLastRow.set_dgv_height_to_all_rows = false;
            this.buyerGridLastRow.Size = new System.Drawing.Size(689, 28);
            this.buyerGridLastRow.TabIndex = 9;
            // 
            // DepositFormUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buyerGridLastRow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepositFormUC";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.DepositFormUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buyerGridLastRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComboBoxField fldUnit;
        private ComboBoxField fldAccount;
        private TextNumberField fldAmount;
        private ComboBoxField fldFund;
        private NumbericField fldCount;
        private CustomControls.ButtonInsert btnInsertPurchase;
        private DataGridList dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.ButtonDelete btnRemove;
        private TextNumberField fldIssueCost;
        private DataGridLastRow buyerGridLastRow;
        private CustomControls.ButtonEdit btnEdit;
    }
}
