namespace Airline_reservation
{
    partial class flight_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flight_edit));
            this.logo = new System.Windows.Forms.PictureBox();
            this.editflightlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addbuttom = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.removeaddtextbox = new System.Windows.Forms.TextBox();
            this.donebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-2, -4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(212, 120);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 42;
            this.logo.TabStop = false;
            // 
            // editflightlabel
            // 
            this.editflightlabel.AutoSize = true;
            this.editflightlabel.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editflightlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.editflightlabel.Location = new System.Drawing.Point(298, 21);
            this.editflightlabel.Name = "editflightlabel";
            this.editflightlabel.Size = new System.Drawing.Size(340, 45);
            this.editflightlabel.TabIndex = 41;
            this.editflightlabel.Text = "Add/Remove flight";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addbuttom
            // 
            this.addbuttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.addbuttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbuttom.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbuttom.Location = new System.Drawing.Point(282, 256);
            this.addbuttom.Name = "addbuttom";
            this.addbuttom.Size = new System.Drawing.Size(120, 35);
            this.addbuttom.TabIndex = 45;
            this.addbuttom.Text = "Add";
            this.addbuttom.UseVisualStyleBackColor = false;
            this.addbuttom.Click += new System.EventHandler(this.addbuttom_Click);
            // 
            // removebutton
            // 
            this.removebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.removebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removebutton.Location = new System.Drawing.Point(469, 256);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(120, 35);
            this.removebutton.TabIndex = 46;
            this.removebutton.Text = "Remove";
            this.removebutton.UseVisualStyleBackColor = false;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // removeaddtextbox
            // 
            this.removeaddtextbox.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.removeaddtextbox.Location = new System.Drawing.Point(319, 130);
            this.removeaddtextbox.Multiline = true;
            this.removeaddtextbox.Name = "removeaddtextbox";
            this.removeaddtextbox.Size = new System.Drawing.Size(230, 55);
            this.removeaddtextbox.TabIndex = 48;
            // 
            // donebutton
            // 
            this.donebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.donebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.donebutton.Location = new System.Drawing.Point(684, 384);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(120, 35);
            this.donebutton.TabIndex = 47;
            this.donebutton.Text = "Done";
            this.donebutton.UseVisualStyleBackColor = false;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // flight_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 451);
            this.Controls.Add(this.removeaddtextbox);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.addbuttom);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.editflightlabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "flight_edit";
            this.Text = "flight_edit";
            this.Load += new System.EventHandler(this.flight_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label editflightlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addbuttom;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.TextBox removeaddtextbox;
        private System.Windows.Forms.Button donebutton;
    }
}