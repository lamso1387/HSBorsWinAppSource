namespace HBorsWinApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.miDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeposit = new System.Windows.Forms.ToolStripMenuItem();
            this.miFund = new System.Windows.Forms.ToolStripMenuItem();
            this.miAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.miUnitCost = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.miCache = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.main_loading = new HBorsWinApp.CombinedControls.LoadingUC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMain = new HBorsWinApp.LoaderPanel();
            this.miSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Silver;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDashboard,
            this.miDeposit,
            this.miFund,
            this.miAccount,
            this.miUnitCost,
            this.miUsers,
            this.miCache,
            this.miSetting});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(120, 370);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // miDashboard
            // 
            this.miDashboard.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.miDashboard.Name = "miDashboard";
            this.miDashboard.Padding = new System.Windows.Forms.Padding(4);
            this.miDashboard.Size = new System.Drawing.Size(119, 35);
            this.miDashboard.Text = "داشبورد";
            this.miDashboard.Click += new System.EventHandler(this.miDashboard_Click);
            // 
            // miDeposit
            // 
            this.miDeposit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miDeposit.Margin = new System.Windows.Forms.Padding(0, 10, 0, 4);
            this.miDeposit.Name = "miDeposit";
            this.miDeposit.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.miDeposit.Size = new System.Drawing.Size(119, 35);
            this.miDeposit.Text = "ثبت سرمایه";
            this.miDeposit.Click += new System.EventHandler(this.miDeposit_Click);
            // 
            // miFund
            // 
            this.miFund.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.miFund.Name = "miFund";
            this.miFund.Padding = new System.Windows.Forms.Padding(4);
            this.miFund.Size = new System.Drawing.Size(119, 35);
            this.miFund.Text = "صندوق ها";
            this.miFund.Click += new System.EventHandler(this.سفارToolStripMenuItem_Click);
            // 
            // miAccount
            // 
            this.miAccount.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.miAccount.Name = "miAccount";
            this.miAccount.Padding = new System.Windows.Forms.Padding(4);
            this.miAccount.Size = new System.Drawing.Size(119, 35);
            this.miAccount.Text = "حساب ها";
            this.miAccount.Click += new System.EventHandler(this.miAccount_Click);
            // 
            // miUnitCost
            // 
            this.miUnitCost.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.miUnitCost.Name = "miUnitCost";
            this.miUnitCost.Padding = new System.Windows.Forms.Padding(4);
            this.miUnitCost.Size = new System.Drawing.Size(119, 35);
            this.miUnitCost.Text = "هزینه واحدها";
            this.miUnitCost.Click += new System.EventHandler(this.miSetting_Click);
            // 
            // miUsers
            // 
            this.miUsers.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.miUsers.Name = "miUsers";
            this.miUsers.Padding = new System.Windows.Forms.Padding(4);
            this.miUsers.Size = new System.Drawing.Size(119, 35);
            this.miUsers.Text = "کاربران";
            this.miUsers.Click += new System.EventHandler(this.miUsers_Click);
            // 
            // miCache
            // 
            this.miCache.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.miCache.Name = "miCache";
            this.miCache.Padding = new System.Windows.Forms.Padding(4);
            this.miCache.Size = new System.Drawing.Size(119, 35);
            this.miCache.Text = "بروزرسانی محلی";
            this.miCache.Visible = false;
            this.miCache.Click += new System.EventHandler(this.miCache_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.pnlLoading);
            this.panel3.Controls.Add(this.main_loading);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel3.Location = new System.Drawing.Point(20, 400);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(760, 30);
            this.panel3.TabIndex = 2;
            // 
            // pnlLoading
            // 
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoading.Location = new System.Drawing.Point(0, 0);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(356, 30);
            this.pnlLoading.TabIndex = 0;
            // 
            // main_loading
            // 
            this.main_loading.Dock = System.Windows.Forms.DockStyle.Right;
            this.main_loading.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.main_loading.LblText = "...";
            this.main_loading.Location = new System.Drawing.Point(356, 0);
            this.main_loading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.main_loading.Name = "main_loading";
            this.main_loading.Size = new System.Drawing.Size(404, 30);
            this.main_loading.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(660, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 370);
            this.panel2.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(20, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(640, 370);
            this.pnlMain.TabIndex = 3;
            // 
            // miSetting
            // 
            this.miSetting.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.miSetting.Name = "miSetting";
            this.miSetting.Padding = new System.Windows.Forms.Padding(4);
            this.miSetting.Size = new System.Drawing.Size(119, 35);
            this.miSetting.Text = "تنظیمات";
            this.miSetting.Click += new System.EventHandler(this.miSetting_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.DisplayHeader = false;
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "بورسک";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem miDeposit;
        private System.Windows.Forms.ToolStripMenuItem miFund;
        private System.Windows.Forms.ToolStripMenuItem miUnitCost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlLoading;
        private LoaderPanel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem miCache;
        private CombinedControls.LoadingUC main_loading;
        private System.Windows.Forms.ToolStripMenuItem miUsers;
        private System.Windows.Forms.ToolStripMenuItem miAccount;
        private System.Windows.Forms.ToolStripMenuItem miDashboard;
        private System.Windows.Forms.ToolStripMenuItem miSetting;
    }
}

