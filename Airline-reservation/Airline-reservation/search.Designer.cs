namespace Airline_reservation
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchlabel = new System.Windows.Forms.Label();
            this.donebutton = new System.Windows.Forms.Button();
            this.fntextbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.lntextbox = new System.Windows.Forms.TextBox();
            this.emailtextbox = new System.Windows.Forms.TextBox();
            this.fromtextbox = new System.Windows.Forms.TextBox();
            this.totextbox = new System.Windows.Forms.TextBox();
            this.agetextbox = new System.Windows.Forms.TextBox();
            this.gendertextbox = new System.Windows.Forms.TextBox();
            this.flighttypetextbox = new System.Windows.Forms.TextBox();
            this.flightclasstextbox = new System.Windows.Forms.TextBox();
            this.departuretextbox = new System.Windows.Forms.TextBox();
            this.passportnumbertextbox = new System.Windows.Forms.TextBox();
            this.Editinfo = new System.Windows.Forms.Button();
            this.deleteflightbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(-3, -2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(212, 120);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 22;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 54);
            this.textBox1.TabIndex = 23;
            // 
            // searchlabel
            // 
            this.searchlabel.AutoSize = true;
            this.searchlabel.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.searchlabel.Location = new System.Drawing.Point(304, 72);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(253, 45);
            this.searchlabel.TabIndex = 39;
            this.searchlabel.Text = "Enter flight Id";
            // 
            // donebutton
            // 
            this.donebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.donebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.donebutton.Location = new System.Drawing.Point(669, 444);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(153, 35);
            this.donebutton.TabIndex = 40;
            this.donebutton.Text = "Done";
            this.donebutton.UseVisualStyleBackColor = false;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // fntextbox
            // 
            this.fntextbox.Location = new System.Drawing.Point(12, 275);
            this.fntextbox.Multiline = true;
            this.fntextbox.Name = "fntextbox";
            this.fntextbox.ReadOnly = true;
            this.fntextbox.Size = new System.Drawing.Size(138, 25);
            this.fntextbox.TabIndex = 41;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchbutton.Location = new System.Drawing.Point(509, 210);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(120, 35);
            this.searchbutton.TabIndex = 42;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // lntextbox
            // 
            this.lntextbox.Location = new System.Drawing.Point(156, 275);
            this.lntextbox.Multiline = true;
            this.lntextbox.Name = "lntextbox";
            this.lntextbox.ReadOnly = true;
            this.lntextbox.Size = new System.Drawing.Size(138, 25);
            this.lntextbox.TabIndex = 43;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(300, 275);
            this.emailtextbox.Multiline = true;
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.ReadOnly = true;
            this.emailtextbox.Size = new System.Drawing.Size(138, 25);
            this.emailtextbox.TabIndex = 44;
            // 
            // fromtextbox
            // 
            this.fromtextbox.Location = new System.Drawing.Point(444, 275);
            this.fromtextbox.Multiline = true;
            this.fromtextbox.Name = "fromtextbox";
            this.fromtextbox.ReadOnly = true;
            this.fromtextbox.Size = new System.Drawing.Size(138, 25);
            this.fromtextbox.TabIndex = 45;
            // 
            // totextbox
            // 
            this.totextbox.Location = new System.Drawing.Point(588, 275);
            this.totextbox.Multiline = true;
            this.totextbox.Name = "totextbox";
            this.totextbox.ReadOnly = true;
            this.totextbox.Size = new System.Drawing.Size(138, 25);
            this.totextbox.TabIndex = 46;
            // 
            // agetextbox
            // 
            this.agetextbox.Location = new System.Drawing.Point(12, 332);
            this.agetextbox.Multiline = true;
            this.agetextbox.Name = "agetextbox";
            this.agetextbox.ReadOnly = true;
            this.agetextbox.Size = new System.Drawing.Size(138, 25);
            this.agetextbox.TabIndex = 47;
            // 
            // gendertextbox
            // 
            this.gendertextbox.Location = new System.Drawing.Point(156, 332);
            this.gendertextbox.Multiline = true;
            this.gendertextbox.Name = "gendertextbox";
            this.gendertextbox.ReadOnly = true;
            this.gendertextbox.Size = new System.Drawing.Size(138, 25);
            this.gendertextbox.TabIndex = 48;
            // 
            // flighttypetextbox
            // 
            this.flighttypetextbox.Location = new System.Drawing.Point(300, 332);
            this.flighttypetextbox.Multiline = true;
            this.flighttypetextbox.Name = "flighttypetextbox";
            this.flighttypetextbox.ReadOnly = true;
            this.flighttypetextbox.Size = new System.Drawing.Size(138, 25);
            this.flighttypetextbox.TabIndex = 49;
            // 
            // flightclasstextbox
            // 
            this.flightclasstextbox.Location = new System.Drawing.Point(444, 332);
            this.flightclasstextbox.Multiline = true;
            this.flightclasstextbox.Name = "flightclasstextbox";
            this.flightclasstextbox.ReadOnly = true;
            this.flightclasstextbox.Size = new System.Drawing.Size(138, 25);
            this.flightclasstextbox.TabIndex = 50;
            // 
            // departuretextbox
            // 
            this.departuretextbox.Location = new System.Drawing.Point(588, 332);
            this.departuretextbox.Multiline = true;
            this.departuretextbox.Name = "departuretextbox";
            this.departuretextbox.ReadOnly = true;
            this.departuretextbox.Size = new System.Drawing.Size(138, 25);
            this.departuretextbox.TabIndex = 51;
            // 
            // passportnumbertextbox
            // 
            this.passportnumbertextbox.Location = new System.Drawing.Point(299, 390);
            this.passportnumbertextbox.Multiline = true;
            this.passportnumbertextbox.Name = "passportnumbertextbox";
            this.passportnumbertextbox.ReadOnly = true;
            this.passportnumbertextbox.Size = new System.Drawing.Size(138, 25);
            this.passportnumbertextbox.TabIndex = 52;
            // 
            // Editinfo
            // 
            this.Editinfo.BackColor = System.Drawing.Color.Transparent;
            this.Editinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editinfo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Editinfo.Location = new System.Drawing.Point(487, 383);
            this.Editinfo.Name = "Editinfo";
            this.Editinfo.Size = new System.Drawing.Size(153, 32);
            this.Editinfo.TabIndex = 90;
            this.Editinfo.Text = "Edit Information";
            this.Editinfo.UseVisualStyleBackColor = false;
            this.Editinfo.Click += new System.EventHandler(this.Editinfo_Click);
            // 
            // deleteflightbutton
            // 
            this.deleteflightbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.deleteflightbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteflightbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteflightbutton.Location = new System.Drawing.Point(669, 383);
            this.deleteflightbutton.Name = "deleteflightbutton";
            this.deleteflightbutton.Size = new System.Drawing.Size(153, 35);
            this.deleteflightbutton.TabIndex = 91;
            this.deleteflightbutton.Text = "Delete flight";
            this.deleteflightbutton.UseVisualStyleBackColor = false;
            this.deleteflightbutton.Click += new System.EventHandler(this.deleteflightbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.Red;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savebutton.Location = new System.Drawing.Point(487, 444);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(153, 35);
            this.savebutton.TabIndex = 92;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Visible = false;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 502);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.deleteflightbutton);
            this.Controls.Add(this.Editinfo);
            this.Controls.Add(this.passportnumbertextbox);
            this.Controls.Add(this.departuretextbox);
            this.Controls.Add(this.flightclasstextbox);
            this.Controls.Add(this.flighttypetextbox);
            this.Controls.Add(this.gendertextbox);
            this.Controls.Add(this.agetextbox);
            this.Controls.Add(this.totextbox);
            this.Controls.Add(this.fromtextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.lntextbox);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.fntextbox);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.searchlabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label searchlabel;
        private System.Windows.Forms.Button donebutton;
        private System.Windows.Forms.TextBox fntextbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox lntextbox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox fromtextbox;
        private System.Windows.Forms.TextBox totextbox;
        private System.Windows.Forms.TextBox agetextbox;
        private System.Windows.Forms.TextBox gendertextbox;
        private System.Windows.Forms.TextBox flighttypetextbox;
        private System.Windows.Forms.TextBox flightclasstextbox;
        private System.Windows.Forms.TextBox departuretextbox;
        private System.Windows.Forms.TextBox passportnumbertextbox;
        private System.Windows.Forms.Button Editinfo;
        private System.Windows.Forms.Button deleteflightbutton;
        private System.Windows.Forms.Button savebutton;
    }
}