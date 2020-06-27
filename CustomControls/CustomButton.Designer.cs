namespace HBorsWinApp.CustomControls
{
    partial class CustomButton
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
            ((System.ComponentModel.ISupportInitialize)(this.limage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimage)).BeginInit();
            this.SuspendLayout();
            // 
            // limage
            // 
            this.limage.Image = null;
            this.limage.Location = new System.Drawing.Point(-5, -5);
            this.limage.Size = new System.Drawing.Size(0, 48);
            // 
            // rimage
            // 
            this.rimage.Location = new System.Drawing.Point(176, -5);
            this.rimage.Size = new System.Drawing.Size(0, 48);
            // 
            // CustomButton
            // 
            this.Activecolor = System.Drawing.Color.RoyalBlue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonText = "دکمه";
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Iconimage = null;
            this.IconRightVisible = false;
            this.IconVisible = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomButton";
            this.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Size = new System.Drawing.Size(171, 38);
            this.Text = "دکمه";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextFont = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            ((System.ComponentModel.ISupportInitialize)(this.limage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
