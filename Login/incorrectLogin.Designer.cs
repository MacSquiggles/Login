namespace Login
{
    partial class incorrectLogin
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
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.tryAgainButton = new System.Windows.Forms.Button();
            this.sadBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.BackColor = System.Drawing.Color.White;
            this.incorrectLabel.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLabel.Location = new System.Drawing.Point(65, 65);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(351, 52);
            this.incorrectLabel.TabIndex = 0;
            this.incorrectLabel.Text = "Your login was incorrect";
            // 
            // tryAgainButton
            // 
            this.tryAgainButton.BackColor = System.Drawing.Color.White;
            this.tryAgainButton.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgainButton.Location = new System.Drawing.Point(3, 389);
            this.tryAgainButton.Name = "tryAgainButton";
            this.tryAgainButton.Size = new System.Drawing.Size(494, 68);
            this.tryAgainButton.TabIndex = 1;
            this.tryAgainButton.Text = "Try Again";
            this.tryAgainButton.UseVisualStyleBackColor = false;
            this.tryAgainButton.Click += new System.EventHandler(this.tryAgainButton_Click);
            // 
            // sadBox
            // 
            this.sadBox.Image = global::Login.Properties.Resources.sadgif;
            this.sadBox.Location = new System.Drawing.Point(90, 150);
            this.sadBox.Name = "sadBox";
            this.sadBox.Size = new System.Drawing.Size(300, 207);
            this.sadBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sadBox.TabIndex = 2;
            this.sadBox.TabStop = false;
            // 
            // incorrectLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.sadBox);
            this.Controls.Add(this.tryAgainButton);
            this.Controls.Add(this.incorrectLabel);
            this.Name = "incorrectLogin";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.sadBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Button tryAgainButton;
        private System.Windows.Forms.PictureBox sadBox;
    }
}
