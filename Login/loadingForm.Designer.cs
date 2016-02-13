namespace Login
{
    partial class loadingForm
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
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.glassesBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.glassesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingBar
            // 
            this.loadingBar.ForeColor = System.Drawing.Color.Blue;
            this.loadingBar.Location = new System.Drawing.Point(35, 402);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(430, 57);
            this.loadingBar.TabIndex = 5;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.Location = new System.Drawing.Point(167, 340);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(155, 42);
            this.loadingLabel.TabIndex = 4;
            this.loadingLabel.Text = "Loading . . .";
            // 
            // glassesBox
            // 
            this.glassesBox.Image = global::Login.Properties.Resources.thirdTry;
            this.glassesBox.Location = new System.Drawing.Point(65, 72);
            this.glassesBox.Name = "glassesBox";
            this.glassesBox.Size = new System.Drawing.Size(370, 140);
            this.glassesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.glassesBox.TabIndex = 3;
            this.glassesBox.TabStop = false;
            // 
            // loadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.glassesBox);
            this.Name = "loadingForm";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.glassesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.PictureBox glassesBox;
    }
}
