namespace E_Archive
{
    partial class qu_img
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
            this.qu_pictcher = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qu_pictcher)).BeginInit();
            this.SuspendLayout();
            // 
            // qu_pictcher
            // 
            this.qu_pictcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qu_pictcher.Location = new System.Drawing.Point(0, 0);
            this.qu_pictcher.Name = "qu_pictcher";
            this.qu_pictcher.Size = new System.Drawing.Size(359, 502);
            this.qu_pictcher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qu_pictcher.TabIndex = 0;
            this.qu_pictcher.TabStop = false;
            // 
            // qu_img
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 502);
            this.Controls.Add(this.qu_pictcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "qu_img";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qu_img";
            ((System.ComponentModel.ISupportInitialize)(this.qu_pictcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox qu_pictcher;
    }
}