namespace Card_Flip
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
            this.backButton = new System.Windows.Forms.Button();
            this.faceButton = new System.Windows.Forms.Button();
            this.cardFrontImage = new System.Windows.Forms.PictureBox();
            this.cardBackImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardFrontImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackImage)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(74, 540);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(238, 115);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Show the Card Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // faceButton
            // 
            this.faceButton.Location = new System.Drawing.Point(431, 540);
            this.faceButton.Name = "faceButton";
            this.faceButton.Size = new System.Drawing.Size(238, 115);
            this.faceButton.TabIndex = 3;
            this.faceButton.Text = "Show the Card Face";
            this.faceButton.UseVisualStyleBackColor = true;
            this.faceButton.Click += new System.EventHandler(this.faceButton_Click);
            // 
            // cardFrontImage
            // 
            this.cardFrontImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardFrontImage.Image = global::Card_Flip.Properties.Resources._9GjLNvD;
            this.cardFrontImage.Location = new System.Drawing.Point(404, 38);
            this.cardFrontImage.Name = "cardFrontImage";
            this.cardFrontImage.Size = new System.Drawing.Size(288, 397);
            this.cardFrontImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFrontImage.TabIndex = 1;
            this.cardFrontImage.TabStop = false;
            // 
            // cardBackImage
            // 
            this.cardBackImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardBackImage.Image = global::Card_Flip.Properties.Resources.cardback_45;
            this.cardBackImage.Location = new System.Drawing.Point(52, 38);
            this.cardBackImage.Name = "cardBackImage";
            this.cardBackImage.Size = new System.Drawing.Size(288, 397);
            this.cardBackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackImage.TabIndex = 0;
            this.cardBackImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 705);
            this.Controls.Add(this.faceButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cardFrontImage);
            this.Controls.Add(this.cardBackImage);
            this.Name = "Form1";
            this.Text = "Hearthstone";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardFrontImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackImage;
        private System.Windows.Forms.PictureBox cardFrontImage;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button faceButton;
    }
}

