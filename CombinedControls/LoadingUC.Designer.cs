namespace HBorsWinApp.CombinedControls
{
    partial class LoadingUC
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
            this.lblLoading = new HBorsWinApp.LoaderLabel();
            this.loading_circle = new SRL.WinTools.LoadingCircleControl.LoadingCircle();
            this.SuspendLayout();
            // 
            // lblLoading
            // 
            this.lblLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoading.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLoading.Location = new System.Drawing.Point(0, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoading.Size = new System.Drawing.Size(178, 24);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "...";
            // 
            // loading_circle
            // 
            this.loading_circle.Active = false;
            this.loading_circle.Color = System.Drawing.Color.Black;
            this.loading_circle.Dock = System.Windows.Forms.DockStyle.Right;
            this.loading_circle.InnerCircleRadius = 5;
            this.loading_circle.Location = new System.Drawing.Point(178, 0);
            this.loading_circle.Name = "loading_circle";
            this.loading_circle.NumberSpoke = 12;
            this.loading_circle.OuterCircleRadius = 11;
            this.loading_circle.RotationSpeed = 100;
            this.loading_circle.Size = new System.Drawing.Size(34, 24);
            this.loading_circle.SpokeThickness = 2;
            this.loading_circle.StylePreset = SRL.WinTools.LoadingCircleControl.LoadingCircle.StylePresets.MacOSX;
            this.loading_circle.TabIndex = 3;
            this.loading_circle.Text = "loadingCircle1";
            this.loading_circle.Visible = false;
            // 
            // LoadingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.loading_circle);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoadingUC";
            this.Size = new System.Drawing.Size(212, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private LoaderLabel lblLoading;
        private SRL.WinTools.LoadingCircleControl.LoadingCircle loading_circle;
    }
}
