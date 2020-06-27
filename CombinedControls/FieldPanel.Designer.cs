

namespace HBorsWinApp
{
    partial class FieldPanel
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.title = new HBorsWinApp.CustomLabel();
            this.pnlField = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.title);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(150, 29);
            this.pnlTitle.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Dock = System.Windows.Forms.DockStyle.Right;
            this.title.Location = new System.Drawing.Point(95, 0);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.title.Size = new System.Drawing.Size(55, 13);
            this.title.TabIndex = 0;
            this.title.Text = "عنوان فیلد";
            // 
            // pnlField
            // 
            this.pnlField.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlField.Location = new System.Drawing.Point(0, 29);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(150, 31);
            this.pnlField.TabIndex = 0;
            // 
            // FieldPanel
            // 
            this.Controls.Add(this.pnlField);
            this.Controls.Add(this.pnlTitle);
            this.Name = "FieldPanel";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlField;
        private CustomLabel title;
    }
}
