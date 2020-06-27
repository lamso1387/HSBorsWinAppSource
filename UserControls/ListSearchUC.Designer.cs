namespace HBorsWinApp
{
    partial class ListSearchUC<TEntity, TEntityForm, TEntitySearch>
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
            this.pnlFilter = new HBorsWinApp.LoaderPanel();
            this.dgv = new HBorsWinApp.DataGridList();
            this.pnlList = new HBorsWinApp.LoaderPanel();
            this.pnlStrip = new HBorsWinApp.LoaderPanel();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.tbPageNo = new HBorsWinApp.CustomTextNumber();
            this.llGoTo = new System.Windows.Forms.LinkLabel();
            this.btnEdit = new HBorsWinApp.CustomControls.ButtonEdit();
            this.btnDelete = new HBorsWinApp.CustomControls.ButtonDelete();
            this.llLastPage = new System.Windows.Forms.LinkLabel();
            this.llNext = new System.Windows.Forms.LinkLabel();
            this.llPrevious = new System.Windows.Forms.LinkLabel();
            this.llFirstPage = new System.Windows.Forms.LinkLabel();
            this.lblRecordOfAll = new System.Windows.Forms.Label();
            this.pnlButtons = new HBorsWinApp.LoaderPanel();
            this.btnAdd = new HBorsWinApp.CustomControls.ButtonAdd();
            this.btnSearch = new HBorsWinApp.CustomControls.ButtonSearch();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlList.SuspendLayout();
            this.pnlStrip.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(898, 113);
            this.pnlFilter.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.entity_count_all = 0;
            this.dgv.entity_page_count = 0;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.LastRowGrid = null;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.page_size = 0;
            this.dgv.page_start = 0;
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.set_dgv_height_to_all_rows = false;
            this.dgv.Size = new System.Drawing.Size(898, 243);
            this.dgv.TabIndex = 0;
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlList.Controls.Add(this.dgv);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 151);
            this.pnlList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(898, 243);
            this.pnlList.TabIndex = 1;
            // 
            // pnlStrip
            // 
            this.pnlStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlStrip.Controls.Add(this.lblTotalPage);
            this.pnlStrip.Controls.Add(this.tbPageNo);
            this.pnlStrip.Controls.Add(this.llGoTo);
            this.pnlStrip.Controls.Add(this.btnEdit);
            this.pnlStrip.Controls.Add(this.btnDelete);
            this.pnlStrip.Controls.Add(this.llLastPage);
            this.pnlStrip.Controls.Add(this.llNext);
            this.pnlStrip.Controls.Add(this.llPrevious);
            this.pnlStrip.Controls.Add(this.llFirstPage);
            this.pnlStrip.Controls.Add(this.lblRecordOfAll);
            this.pnlStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStrip.Location = new System.Drawing.Point(0, 394);
            this.pnlStrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlStrip.Name = "pnlStrip";
            this.pnlStrip.Size = new System.Drawing.Size(898, 36);
            this.pnlStrip.TabIndex = 2;
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalPage.Location = new System.Drawing.Point(413, 0);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPage.Size = new System.Drawing.Size(36, 20);
            this.lblTotalPage.TabIndex = 13;
            this.lblTotalPage.Text = "از کل";
            // 
            // tbPageNo
            // 
            this.tbPageNo.BackColor = System.Drawing.SystemColors.Window;
            this.tbPageNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbPageNo.Location = new System.Drawing.Point(449, 0);
            this.tbPageNo.Name = "tbPageNo";
            this.tbPageNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPageNo.Size = new System.Drawing.Size(29, 27);
            this.tbPageNo.TabIndex = 1;
            // 
            // llGoTo
            // 
            this.llGoTo.AutoSize = true;
            this.llGoTo.Dock = System.Windows.Forms.DockStyle.Right;
            this.llGoTo.Location = new System.Drawing.Point(478, 0);
            this.llGoTo.Name = "llGoTo";
            this.llGoTo.Size = new System.Drawing.Size(71, 20);
            this.llGoTo.TabIndex = 11;
            this.llGoTo.TabStop = true;
            this.llGoTo.Text = "برو به صفحه";
            this.llGoTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGoTo_LinkClicked);
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
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.btnEdit.Location = new System.Drawing.Point(171, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.BlueViolet;
            this.btnEdit.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(171, 36);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Active = false;
            this.btnDelete.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "حذف";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Red;
            this.btnDelete.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(171, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // llLastPage
            // 
            this.llLastPage.AutoSize = true;
            this.llLastPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.llLastPage.Location = new System.Drawing.Point(549, 0);
            this.llLastPage.Name = "llLastPage";
            this.llLastPage.Size = new System.Drawing.Size(58, 20);
            this.llLastPage.TabIndex = 7;
            this.llLastPage.TabStop = true;
            this.llLastPage.Text = "صفحه اخر";
            this.llLastPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLastPage_LinkClicked);
            // 
            // llNext
            // 
            this.llNext.AutoSize = true;
            this.llNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.llNext.Location = new System.Drawing.Point(607, 0);
            this.llNext.Name = "llNext";
            this.llNext.Size = new System.Drawing.Size(57, 20);
            this.llNext.TabIndex = 8;
            this.llNext.TabStop = true;
            this.llNext.Text = "صفحه بعد";
            this.llNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNext_LinkClicked);
            // 
            // llPrevious
            // 
            this.llPrevious.AutoSize = true;
            this.llPrevious.Dock = System.Windows.Forms.DockStyle.Right;
            this.llPrevious.Location = new System.Drawing.Point(664, 0);
            this.llPrevious.Name = "llPrevious";
            this.llPrevious.Size = new System.Drawing.Size(60, 20);
            this.llPrevious.TabIndex = 6;
            this.llPrevious.TabStop = true;
            this.llPrevious.Text = "صفحه قبل";
            this.llPrevious.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPrevious_LinkClicked);
            // 
            // llFirstPage
            // 
            this.llFirstPage.AutoSize = true;
            this.llFirstPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.llFirstPage.Location = new System.Drawing.Point(724, 0);
            this.llFirstPage.Name = "llFirstPage";
            this.llFirstPage.Size = new System.Drawing.Size(60, 20);
            this.llFirstPage.TabIndex = 5;
            this.llFirstPage.TabStop = true;
            this.llFirstPage.Text = "صفحه اول";
            this.llFirstPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFirstPage_LinkClicked);
            // 
            // lblRecordOfAll
            // 
            this.lblRecordOfAll.AutoSize = true;
            this.lblRecordOfAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRecordOfAll.Location = new System.Drawing.Point(784, 0);
            this.lblRecordOfAll.Name = "lblRecordOfAll";
            this.lblRecordOfAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRecordOfAll.Size = new System.Drawing.Size(114, 20);
            this.lblRecordOfAll.TabIndex = 12;
            this.lblRecordOfAll.Text = "نمایش 0 رکورد از کل";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnSearch);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 113);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(898, 38);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Active = false;
            this.btnAdd.Activecolor = System.Drawing.Color.Silver;
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "افزودن";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = null;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = false;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = false;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.OnHovercolor = System.Drawing.Color.SlateGray;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(171, 38);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Active = false;
            this.btnSearch.Activecolor = System.Drawing.Color.Silver;
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "جستجو";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = false;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = false;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(727, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.OnHovercolor = System.Drawing.Color.SlateGray;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(171, 38);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // ListSearchUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlStrip);
            this.Controls.Add(this.pnlFilter);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListSearchUC";
            this.Size = new System.Drawing.Size(898, 430);
            this.Load += new System.EventHandler(this.ProductsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.pnlStrip.ResumeLayout(false);
            this.pnlStrip.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LoaderPanel pnlFilter;
        private LoaderPanel pnlList;
        private LoaderPanel pnlStrip;
        private LoaderPanel pnlButtons;
        private DataGridList dgv;
        private CustomControls.ButtonSearch btnSearch;
        private CustomControls.ButtonAdd btnAdd;
        private System.Windows.Forms.LinkLabel llLastPage;
        private System.Windows.Forms.LinkLabel llNext;
        private System.Windows.Forms.LinkLabel llPrevious;
        private System.Windows.Forms.LinkLabel llFirstPage;
        private CustomControls.ButtonDelete btnDelete;
        private CustomControls.ButtonEdit btnEdit;
        private System.Windows.Forms.LinkLabel llGoTo;
        private System.Windows.Forms.Label lblRecordOfAll;
        private System.Windows.Forms.Label lblTotalPage;
        private CustomTextNumber tbPageNo;
    }
}
