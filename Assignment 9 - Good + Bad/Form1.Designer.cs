namespace Assignment_9___Good___Bad
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
            this.badButton = new System.Windows.Forms.Button();
            this.goodButton = new System.Windows.Forms.Button();
            this.displayImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // badButton
            // 
            this.badButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.badButton.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.badButton.Location = new System.Drawing.Point(455, 326);
            this.badButton.Name = "badButton";
            this.badButton.Size = new System.Drawing.Size(141, 71);
            this.badButton.TabIndex = 0;
            this.badButton.Text = "Bad";
            this.badButton.UseVisualStyleBackColor = false;
            this.badButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // goodButton
            // 
            this.goodButton.BackColor = System.Drawing.Color.Green;
            this.goodButton.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goodButton.Location = new System.Drawing.Point(191, 326);
            this.goodButton.Name = "goodButton";
            this.goodButton.Size = new System.Drawing.Size(141, 71);
            this.goodButton.TabIndex = 1;
            this.goodButton.Text = "Good";
            this.goodButton.UseVisualStyleBackColor = false;
            this.goodButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // displayImage
            // 
            this.displayImage.Image = global::Assignment_9___Good___Bad.Properties.Resources.asteroid;
            this.displayImage.Location = new System.Drawing.Point(277, 54);
            this.displayImage.Name = "displayImage";
            this.displayImage.Size = new System.Drawing.Size(228, 216);
            this.displayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayImage.TabIndex = 2;
            this.displayImage.TabStop = false;
            this.displayImage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayImage);
            this.Controls.Add(this.goodButton);
            this.Controls.Add(this.badButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button badButton;
        private System.Windows.Forms.Button goodButton;
        private System.Windows.Forms.PictureBox displayImage;
    }
}

