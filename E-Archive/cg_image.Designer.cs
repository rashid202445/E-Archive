namespace E_Archive
{
    partial class cg_image
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
            this.cg_pictcher = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cg_pictcher)).BeginInit();
            this.SuspendLayout();
            // 
            // cg_pictcher
            // 
            this.cg_pictcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cg_pictcher.Location = new System.Drawing.Point(0, 0);
            this.cg_pictcher.Name = "cg_pictcher";
            this.cg_pictcher.Size = new System.Drawing.Size(359, 502);
            this.cg_pictcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cg_pictcher.TabIndex = 0;
            this.cg_pictcher.TabStop = false;
            // 
            // cg_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(359, 502);
            this.Controls.Add(this.cg_pictcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "cg_image";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "cg_image";
            this.Load += new System.EventHandler(this.cg_image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cg_pictcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox cg_pictcher;
    }
}