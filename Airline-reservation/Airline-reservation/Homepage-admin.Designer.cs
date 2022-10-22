namespace Airline_reservation
{
    partial class Homepage_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage_admin));
            this.exitbutton = new System.Windows.Forms.Button();
            this.genderlabel = new System.Windows.Forms.Label();
            this.birthdatelabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.bookedticketbutton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.bookticketbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgpic = new System.Windows.Forms.PictureBox();
            this.addadminbutton = new System.Windows.Forms.Button();
            this.phoneblank = new System.Windows.Forms.TextBox();
            this.emailblank = new System.Windows.Forms.TextBox();
            this.genderblank = new System.Windows.Forms.TextBox();
            this.birthdateblank = new System.Windows.Forms.TextBox();
            this.lastnameblank = new System.Windows.Forms.TextBox();
            this.firstnameblank = new System.Windows.Forms.TextBox();
            this.usernameblank = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.Editprofile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpic)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitbutton.Location = new System.Drawing.Point(615, 386);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(144, 35);
            this.exitbutton.TabIndex = 71;
            this.exitbutton.Text = " Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.saveandexit_Click);
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.genderlabel.Location = new System.Drawing.Point(427, 257);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(100, 25);
            this.genderlabel.TabIndex = 70;
            this.genderlabel.Text = "Gender👬";
            // 
            // birthdatelabel
            // 
            this.birthdatelabel.AutoSize = true;
            this.birthdatelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.birthdatelabel.Location = new System.Drawing.Point(233, 257);
            this.birthdatelabel.Name = "birthdatelabel";
            this.birthdatelabel.Size = new System.Drawing.Size(125, 25);
            this.birthdatelabel.TabIndex = 69;
            this.birthdatelabel.Text = "Birth date🎂";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.usernamelabel.Location = new System.Drawing.Point(373, 71);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(131, 25);
            this.usernamelabel.TabIndex = 68;
            this.usernamelabel.Text = "User name👨";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.phonelabel.Location = new System.Drawing.Point(427, 322);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(119, 25);
            this.phonelabel.TabIndex = 67;
            this.phonelabel.Text = "Phone n0📞";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.emaillabel.Location = new System.Drawing.Point(233, 322);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(86, 25);
            this.emaillabel.TabIndex = 66;
            this.emaillabel.Text = "Email📩";
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.lastnamelabel.Location = new System.Drawing.Point(427, 180);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(130, 25);
            this.lastnamelabel.TabIndex = 65;
            this.lastnamelabel.Text = "Last name👥";
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.firstnamelabel.Location = new System.Drawing.Point(233, 180);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(132, 25);
            this.firstnamelabel.TabIndex = 64;
            this.firstnamelabel.Text = "First name👥";
            // 
            // bookedticketbutton
            // 
            this.bookedticketbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.bookedticketbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookedticketbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookedticketbutton.Location = new System.Drawing.Point(597, 12);
            this.bookedticketbutton.Name = "bookedticketbutton";
            this.bookedticketbutton.Size = new System.Drawing.Size(120, 35);
            this.bookedticketbutton.TabIndex = 62;
            this.bookedticketbutton.Text = "Booked Flights";
            this.bookedticketbutton.UseVisualStyleBackColor = false;
            this.bookedticketbutton.Click += new System.EventHandler(this.bookedticketbutton_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-1, -4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(171, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 61;
            this.logo.TabStop = false;
            // 
            // bookticketbutton
            // 
            this.bookticketbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.bookticketbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookticketbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookticketbutton.Location = new System.Drawing.Point(471, 12);
            this.bookticketbutton.Name = "bookticketbutton";
            this.bookticketbutton.Size = new System.Drawing.Size(120, 35);
            this.bookticketbutton.TabIndex = 60;
            this.bookticketbutton.Text = "Book flight";
            this.bookticketbutton.UseVisualStyleBackColor = false;
            this.bookticketbutton.Click += new System.EventHandler(this.bookticketbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 128);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // bgpic
            // 
            this.bgpic.Image = ((System.Drawing.Image)(resources.GetObject("bgpic.Image")));
            this.bgpic.Location = new System.Drawing.Point(2, 3);
            this.bgpic.Name = "bgpic";
            this.bgpic.Size = new System.Drawing.Size(800, 452);
            this.bgpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgpic.TabIndex = 63;
            this.bgpic.TabStop = false;
            // 
            // addadminbutton
            // 
            this.addadminbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.addadminbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addadminbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addadminbutton.Location = new System.Drawing.Point(597, 103);
            this.addadminbutton.Name = "addadminbutton";
            this.addadminbutton.Size = new System.Drawing.Size(120, 35);
            this.addadminbutton.TabIndex = 79;
            this.addadminbutton.Text = "Add admin";
            this.addadminbutton.UseVisualStyleBackColor = false;
            this.addadminbutton.Click += new System.EventHandler(this.addadminbutton_Click);
            // 
            // phoneblank
            // 
            this.phoneblank.Location = new System.Drawing.Point(417, 350);
            this.phoneblank.Name = "phoneblank";
            this.phoneblank.ReadOnly = true;
            this.phoneblank.Size = new System.Drawing.Size(155, 20);
            this.phoneblank.TabIndex = 87;
            // 
            // emailblank
            // 
            this.emailblank.Location = new System.Drawing.Point(231, 350);
            this.emailblank.Name = "emailblank";
            this.emailblank.ReadOnly = true;
            this.emailblank.Size = new System.Drawing.Size(140, 20);
            this.emailblank.TabIndex = 86;
            // 
            // genderblank
            // 
            this.genderblank.Location = new System.Drawing.Point(417, 285);
            this.genderblank.Name = "genderblank";
            this.genderblank.ReadOnly = true;
            this.genderblank.Size = new System.Drawing.Size(140, 20);
            this.genderblank.TabIndex = 85;
            // 
            // birthdateblank
            // 
            this.birthdateblank.Location = new System.Drawing.Point(231, 285);
            this.birthdateblank.Name = "birthdateblank";
            this.birthdateblank.ReadOnly = true;
            this.birthdateblank.Size = new System.Drawing.Size(140, 20);
            this.birthdateblank.TabIndex = 84;
            // 
            // lastnameblank
            // 
            this.lastnameblank.Location = new System.Drawing.Point(417, 208);
            this.lastnameblank.Name = "lastnameblank";
            this.lastnameblank.ReadOnly = true;
            this.lastnameblank.Size = new System.Drawing.Size(140, 20);
            this.lastnameblank.TabIndex = 83;
            // 
            // firstnameblank
            // 
            this.firstnameblank.Location = new System.Drawing.Point(231, 208);
            this.firstnameblank.Name = "firstnameblank";
            this.firstnameblank.ReadOnly = true;
            this.firstnameblank.Size = new System.Drawing.Size(140, 20);
            this.firstnameblank.TabIndex = 82;
            // 
            // usernameblank
            // 
            this.usernameblank.Location = new System.Drawing.Point(364, 103);
            this.usernameblank.Name = "usernameblank";
            this.usernameblank.ReadOnly = true;
            this.usernameblank.Size = new System.Drawing.Size(140, 20);
            this.usernameblank.TabIndex = 81;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.Red;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savebutton.Location = new System.Drawing.Point(615, 285);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(144, 35);
            this.savebutton.TabIndex = 88;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            // 
            // Editprofile
            // 
            this.Editprofile.BackColor = System.Drawing.Color.Transparent;
            this.Editprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editprofile.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Editprofile.Location = new System.Drawing.Point(615, 201);
            this.Editprofile.Name = "Editprofile";
            this.Editprofile.Size = new System.Drawing.Size(144, 32);
            this.Editprofile.TabIndex = 89;
            this.Editprofile.Text = "Edit profile";
            this.Editprofile.UseVisualStyleBackColor = false;
            this.Editprofile.Click += new System.EventHandler(this.Editprofile_Click_1);
            // 
            // Homepage_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editprofile);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.phoneblank);
            this.Controls.Add(this.emailblank);
            this.Controls.Add(this.genderblank);
            this.Controls.Add(this.birthdateblank);
            this.Controls.Add(this.lastnameblank);
            this.Controls.Add(this.firstnameblank);
            this.Controls.Add(this.usernameblank);
            this.Controls.Add(this.addadminbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.birthdatelabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.lastnamelabel);
            this.Controls.Add(this.firstnamelabel);
            this.Controls.Add(this.bookedticketbutton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.bookticketbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bgpic);
            this.Name = "Homepage_admin";
            this.Text = "Homepage_admin";
            this.Load += new System.EventHandler(this.Homepage_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label birthdatelabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Button bookedticketbutton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button bookticketbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox bgpic;
        private System.Windows.Forms.Button addadminbutton;
        private System.Windows.Forms.TextBox phoneblank;
        private System.Windows.Forms.TextBox emailblank;
        private System.Windows.Forms.TextBox genderblank;
        private System.Windows.Forms.TextBox birthdateblank;
        private System.Windows.Forms.TextBox lastnameblank;
        private System.Windows.Forms.TextBox firstnameblank;
        private System.Windows.Forms.TextBox usernameblank;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button Editprofile;
    }
}