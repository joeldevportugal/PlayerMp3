namespace Player
{
    partial class frVolume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frVolume));
            this.lblVolume = new System.Windows.Forms.Label();
            this.trVolume = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(13, 13);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(114, 29);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Volume 0";
            // 
            // trVolume
            // 
            this.trVolume.Location = new System.Drawing.Point(18, 59);
            this.trVolume.Maximum = 100;
            this.trVolume.Name = "trVolume";
            this.trVolume.Size = new System.Drawing.Size(554, 56);
            this.trVolume.TabIndex = 1;
            this.trVolume.Scroll += new System.EventHandler(this.trVolume_Scroll);
            // 
            // frVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 136);
            this.Controls.Add(this.trVolume);
            this.Controls.Add(this.lblVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frVolume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Volume";
            ((System.ComponentModel.ISupportInitialize)(this.trVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trVolume;
    }
}