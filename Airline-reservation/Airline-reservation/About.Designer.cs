namespace Airline_reservation
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutlabel = new System.Windows.Forms.Label();
            this.aboutustextbox = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aboutlabel
            // 
            this.aboutlabel.AutoSize = true;
            this.aboutlabel.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.aboutlabel.Location = new System.Drawing.Point(371, 9);
            this.aboutlabel.Name = "aboutlabel";
            this.aboutlabel.Size = new System.Drawing.Size(172, 45);
            this.aboutlabel.TabIndex = 17;
            this.aboutlabel.Text = "About us";
            // 
            // aboutustextbox
            // 
            this.aboutustextbox.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutustextbox.Location = new System.Drawing.Point(196, 77);
            this.aboutustextbox.Multiline = true;
            this.aboutustextbox.Name = "aboutustextbox";
            this.aboutustextbox.ReadOnly = true;
            this.aboutustextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.aboutustextbox.Size = new System.Drawing.Size(575, 180);
            this.aboutustextbox.TabIndex = 18;
            this.aboutustextbox.Text = resources.GetString("aboutustextbox.Text");
            this.aboutustextbox.TextChanged += new System.EventHandler(this.aboutustextbox_TextChanged);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-15, -23);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(193, 90);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 19;
            this.logo.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 530);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.aboutustextbox);
            this.Controls.Add(this.aboutlabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label aboutlabel;
        private System.Windows.Forms.TextBox aboutustextbox;
        private System.Windows.Forms.PictureBox logo;
    }
}