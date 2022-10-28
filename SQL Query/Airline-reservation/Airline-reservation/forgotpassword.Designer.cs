namespace Airline_reservation
{
    partial class forgotpassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.newpasswordlabel = new System.Windows.Forms.Label();
            this.newpasswordtextbox = new System.Windows.Forms.TextBox();
            this.hinttextbox = new System.Windows.Forms.TextBox();
            this.hintlable = new System.Windows.Forms.Label();
            this.resetpassword = new System.Windows.Forms.Label();
            this.resetbutton = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.usernameerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.hinterror = new System.Windows.Forms.ErrorProvider(this.components);
            this.passworderror = new System.Windows.Forms.ErrorProvider(this.components);
            this.questionlabel = new System.Windows.Forms.Label();
            this.questionerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnhintq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinterror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionerror)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(340, 166);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernamelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernamelabel.ForeColor = System.Drawing.Color.Black;
            this.usernamelabel.Location = new System.Drawing.Point(401, 135);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(166, 31);
            this.usernamelabel.TabIndex = 11;
            this.usernamelabel.Text = "👨User name";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernametextbox.ForeColor = System.Drawing.Color.Black;
            this.usernametextbox.Location = new System.Drawing.Point(396, 167);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(253, 23);
            this.usernametextbox.TabIndex = 12;
            // 
            // newpasswordlabel
            // 
            this.newpasswordlabel.AutoSize = true;
            this.newpasswordlabel.BackColor = System.Drawing.Color.Transparent;
            this.newpasswordlabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newpasswordlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.newpasswordlabel.Location = new System.Drawing.Point(401, 404);
            this.newpasswordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newpasswordlabel.Name = "newpasswordlabel";
            this.newpasswordlabel.Size = new System.Drawing.Size(209, 31);
            this.newpasswordlabel.TabIndex = 13;
            this.newpasswordlabel.Text = "🔒New password";
            // 
            // newpasswordtextbox
            // 
            this.newpasswordtextbox.ForeColor = System.Drawing.Color.Black;
            this.newpasswordtextbox.Location = new System.Drawing.Point(396, 438);
            this.newpasswordtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.newpasswordtextbox.Name = "newpasswordtextbox";
            this.newpasswordtextbox.PasswordChar = '*';
            this.newpasswordtextbox.Size = new System.Drawing.Size(253, 22);
            this.newpasswordtextbox.TabIndex = 14;
            // 
            // hinttextbox
            // 
            this.hinttextbox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hinttextbox.ForeColor = System.Drawing.Color.Black;
            this.hinttextbox.Location = new System.Drawing.Point(396, 352);
            this.hinttextbox.Margin = new System.Windows.Forms.Padding(4);
            this.hinttextbox.Name = "hinttextbox";
            this.hinttextbox.Size = new System.Drawing.Size(253, 23);
            this.hinttextbox.TabIndex = 36;
            // 
            // hintlable
            // 
            this.hintlable.AutoSize = true;
            this.hintlable.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.hintlable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.hintlable.Location = new System.Drawing.Point(401, 318);
            this.hintlable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintlable.Name = "hintlable";
            this.hintlable.Size = new System.Drawing.Size(182, 31);
            this.hintlable.TabIndex = 35;
            this.hintlable.Text = "Hint Answer🔑";
            // 
            // resetpassword
            // 
            this.resetpassword.AutoSize = true;
            this.resetpassword.BackColor = System.Drawing.Color.Transparent;
            this.resetpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetpassword.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetpassword.ForeColor = System.Drawing.Color.Black;
            this.resetpassword.Location = new System.Drawing.Point(444, 26);
            this.resetpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetpassword.Name = "resetpassword";
            this.resetpassword.Size = new System.Drawing.Size(189, 31);
            this.resetpassword.TabIndex = 37;
            this.resetpassword.Text = "Reset password";
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetbutton.Location = new System.Drawing.Point(701, 496);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(4);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(160, 43);
            this.resetbutton.TabIndex = 38;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnclose.Location = new System.Drawing.Point(264, 496);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(160, 43);
            this.btnclose.TabIndex = 39;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // usernameerror
            // 
            this.usernameerror.ContainerControl = this;
            // 
            // hinterror
            // 
            this.hinterror.ContainerControl = this;
            // 
            // passworderror
            // 
            this.passworderror.ContainerControl = this;
            // 
            // questionlabel
            // 
            this.questionlabel.AutoSize = true;
            this.questionlabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.questionlabel.ForeColor = System.Drawing.Color.Navy;
            this.questionlabel.Location = new System.Drawing.Point(401, 276);
            this.questionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionlabel.Name = "questionlabel";
            this.questionlabel.Size = new System.Drawing.Size(20, 31);
            this.questionlabel.TabIndex = 49;
            this.questionlabel.Text = ".";
            // 
            // questionerror
            // 
            this.questionerror.ContainerControl = this;
            // 
            // btnhintq
            // 
            this.btnhintq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.btnhintq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhintq.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnhintq.Location = new System.Drawing.Point(396, 218);
            this.btnhintq.Margin = new System.Windows.Forms.Padding(4);
            this.btnhintq.Name = "btnhintq";
            this.btnhintq.Size = new System.Drawing.Size(160, 43);
            this.btnhintq.TabIndex = 51;
            this.btnhintq.Text = "Hint Question";
            this.btnhintq.UseVisualStyleBackColor = false;
            this.btnhintq.Click += new System.EventHandler(this.btnhintq_Click);
            // 
            // forgotpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnhintq);
            this.Controls.Add(this.questionlabel);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.resetpassword);
            this.Controls.Add(this.hinttextbox);
            this.Controls.Add(this.hintlable);
            this.Controls.Add(this.newpasswordtextbox);
            this.Controls.Add(this.newpasswordlabel);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "forgotpassword";
            this.Text = "forgotpassword";
            this.Load += new System.EventHandler(this.forgotpassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinterror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionerror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label newpasswordlabel;
        private System.Windows.Forms.TextBox newpasswordtextbox;
        private System.Windows.Forms.TextBox hinttextbox;
        private System.Windows.Forms.Label hintlable;
        private System.Windows.Forms.Label resetpassword;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ErrorProvider usernameerror;
        private System.Windows.Forms.ErrorProvider hinterror;
        private System.Windows.Forms.ErrorProvider passworderror;
        private System.Windows.Forms.Label questionlabel;
        private System.Windows.Forms.ErrorProvider questionerror;
        private System.Windows.Forms.Button btnhintq;
    }
}