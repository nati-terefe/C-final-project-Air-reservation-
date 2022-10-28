namespace Airline_reservation
{
    partial class addflight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addflight));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.addflightlabel = new System.Windows.Forms.Label();
            this.depcomboBox = new System.Windows.Forms.ComboBox();
            this.aircraftcombobox = new System.Windows.Forms.ComboBox();
            this.depdateandtimepick = new System.Windows.Forms.DateTimePicker();
            this.deptime = new System.Windows.Forms.Label();
            this.flighthourtextbox = new System.Windows.Forms.TextBox();
            this.noofseatstextbox = new System.Windows.Forms.TextBox();
            this.copilolttextbox = new System.Windows.Forms.TextBox();
            this.pilolttextbox = new System.Windows.Forms.TextBox();
            this.flighthourlabel = new System.Windows.Forms.Label();
            this.destinationlabel = new System.Windows.Forms.Label();
            this.departurelabel = new System.Windows.Forms.Label();
            this.noofseatslabel = new System.Windows.Forms.Label();
            this.aircraftlabel = new System.Windows.Forms.Label();
            this.pilotslabel = new System.Windows.Forms.Label();
            this.addflightbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.piloterror = new System.Windows.Forms.ErrorProvider(this.components);
            this.copiloterror = new System.Windows.Forms.ErrorProvider(this.components);
            this.departureerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.aircrafterror = new System.Windows.Forms.ErrorProvider(this.components);
            this.destinationerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.noofseatserror = new System.Windows.Forms.ErrorProvider(this.components);
            this.flighthourerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.bookedseatserror = new System.Windows.Forms.ErrorProvider(this.components);
            this.progresserror = new System.Windows.Forms.ErrorProvider(this.components);
            this.destinationcombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piloterror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiloterror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircrafterror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noofseatserror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flighthourerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedseatserror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progresserror)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, -1);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(228, 123);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 45;
            this.logo.TabStop = false;
            // 
            // addflightlabel
            // 
            this.addflightlabel.AutoSize = true;
            this.addflightlabel.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addflightlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.addflightlabel.Location = new System.Drawing.Point(440, 81);
            this.addflightlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addflightlabel.Name = "addflightlabel";
            this.addflightlabel.Size = new System.Drawing.Size(245, 56);
            this.addflightlabel.TabIndex = 64;
            this.addflightlabel.Text = "Add Flight";
            // 
            // depcomboBox
            // 
            this.depcomboBox.Enabled = false;
            this.depcomboBox.FormattingEnabled = true;
            this.depcomboBox.Location = new System.Drawing.Point(325, 230);
            this.depcomboBox.Name = "depcomboBox";
            this.depcomboBox.Size = new System.Drawing.Size(195, 24);
            this.depcomboBox.TabIndex = 146;
            // 
            // aircraftcombobox
            // 
            this.aircraftcombobox.FormattingEnabled = true;
            this.aircraftcombobox.Location = new System.Drawing.Point(549, 228);
            this.aircraftcombobox.Name = "aircraftcombobox";
            this.aircraftcombobox.Size = new System.Drawing.Size(195, 24);
            this.aircraftcombobox.TabIndex = 145;
            this.aircraftcombobox.SelectedIndexChanged += new System.EventHandler(this.aircraftcombobox_SelectedIndexChanged);
            // 
            // depdateandtimepick
            // 
            this.depdateandtimepick.Location = new System.Drawing.Point(790, 317);
            this.depdateandtimepick.Name = "depdateandtimepick";
            this.depdateandtimepick.Size = new System.Drawing.Size(200, 22);
            this.depdateandtimepick.TabIndex = 144;
            // 
            // deptime
            // 
            this.deptime.AutoSize = true;
            this.deptime.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.deptime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deptime.Location = new System.Drawing.Point(784, 282);
            this.deptime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deptime.Name = "deptime";
            this.deptime.Size = new System.Drawing.Size(206, 32);
            this.deptime.TabIndex = 143;
            this.deptime.Text = "Departure Time";
            // 
            // flighthourtextbox
            // 
            this.flighthourtextbox.Location = new System.Drawing.Point(549, 320);
            this.flighthourtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.flighthourtextbox.Name = "flighthourtextbox";
            this.flighthourtextbox.Size = new System.Drawing.Size(195, 22);
            this.flighthourtextbox.TabIndex = 141;
            // 
            // noofseatstextbox
            // 
            this.noofseatstextbox.Enabled = false;
            this.noofseatstextbox.Location = new System.Drawing.Point(790, 230);
            this.noofseatstextbox.Margin = new System.Windows.Forms.Padding(4);
            this.noofseatstextbox.Name = "noofseatstextbox";
            this.noofseatstextbox.ReadOnly = true;
            this.noofseatstextbox.Size = new System.Drawing.Size(195, 22);
            this.noofseatstextbox.TabIndex = 140;
            // 
            // copilolttextbox
            // 
            this.copilolttextbox.Location = new System.Drawing.Point(87, 282);
            this.copilolttextbox.Margin = new System.Windows.Forms.Padding(4);
            this.copilolttextbox.Name = "copilolttextbox";
            this.copilolttextbox.Size = new System.Drawing.Size(195, 22);
            this.copilolttextbox.TabIndex = 138;
            // 
            // pilolttextbox
            // 
            this.pilolttextbox.Location = new System.Drawing.Point(86, 230);
            this.pilolttextbox.Margin = new System.Windows.Forms.Padding(4);
            this.pilolttextbox.Name = "pilolttextbox";
            this.pilolttextbox.Size = new System.Drawing.Size(195, 22);
            this.pilolttextbox.TabIndex = 137;
            // 
            // flighthourlabel
            // 
            this.flighthourlabel.AutoSize = true;
            this.flighthourlabel.BackColor = System.Drawing.SystemColors.Control;
            this.flighthourlabel.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.flighthourlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flighthourlabel.Location = new System.Drawing.Point(543, 282);
            this.flighthourlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flighthourlabel.Name = "flighthourlabel";
            this.flighthourlabel.Size = new System.Drawing.Size(175, 32);
            this.flighthourlabel.TabIndex = 136;
            this.flighthourlabel.Text = "Hour of flight";
            // 
            // destinationlabel
            // 
            this.destinationlabel.AutoSize = true;
            this.destinationlabel.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.destinationlabel.ForeColor = System.Drawing.Color.Black;
            this.destinationlabel.Location = new System.Drawing.Point(319, 285);
            this.destinationlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationlabel.Name = "destinationlabel";
            this.destinationlabel.Size = new System.Drawing.Size(155, 32);
            this.destinationlabel.TabIndex = 135;
            this.destinationlabel.Text = "Destination";
            // 
            // departurelabel
            // 
            this.departurelabel.AutoSize = true;
            this.departurelabel.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.departurelabel.ForeColor = System.Drawing.Color.Black;
            this.departurelabel.Location = new System.Drawing.Point(319, 179);
            this.departurelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departurelabel.Name = "departurelabel";
            this.departurelabel.Size = new System.Drawing.Size(138, 32);
            this.departurelabel.TabIndex = 134;
            this.departurelabel.Text = "Departure";
            // 
            // noofseatslabel
            // 
            this.noofseatslabel.AutoSize = true;
            this.noofseatslabel.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.noofseatslabel.ForeColor = System.Drawing.Color.Black;
            this.noofseatslabel.Location = new System.Drawing.Point(784, 179);
            this.noofseatslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noofseatslabel.Name = "noofseatslabel";
            this.noofseatslabel.Size = new System.Drawing.Size(156, 32);
            this.noofseatslabel.TabIndex = 132;
            this.noofseatslabel.Text = "No of Seats";
            // 
            // aircraftlabel
            // 
            this.aircraftlabel.AutoSize = true;
            this.aircraftlabel.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.aircraftlabel.ForeColor = System.Drawing.Color.Black;
            this.aircraftlabel.Location = new System.Drawing.Point(543, 179);
            this.aircraftlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aircraftlabel.Name = "aircraftlabel";
            this.aircraftlabel.Size = new System.Drawing.Size(106, 32);
            this.aircraftlabel.TabIndex = 131;
            this.aircraftlabel.Text = "Aircraft";
            // 
            // pilotslabel
            // 
            this.pilotslabel.AutoSize = true;
            this.pilotslabel.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.pilotslabel.ForeColor = System.Drawing.Color.Black;
            this.pilotslabel.Location = new System.Drawing.Point(81, 179);
            this.pilotslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pilotslabel.Name = "pilotslabel";
            this.pilotslabel.Size = new System.Drawing.Size(83, 32);
            this.pilotslabel.TabIndex = 130;
            this.pilotslabel.Text = "Pilots";
            // 
            // addflightbutton
            // 
            this.addflightbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.addflightbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addflightbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.addflightbutton.Location = new System.Drawing.Point(597, 468);
            this.addflightbutton.Margin = new System.Windows.Forms.Padding(4);
            this.addflightbutton.Name = "addflightbutton";
            this.addflightbutton.Size = new System.Drawing.Size(204, 43);
            this.addflightbutton.TabIndex = 129;
            this.addflightbutton.Text = "Add Flight";
            this.addflightbutton.UseVisualStyleBackColor = false;
            this.addflightbutton.Click += new System.EventHandler(this.addflightbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelbutton.Location = new System.Drawing.Point(861, 468);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(160, 43);
            this.cancelbutton.TabIndex = 58;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // piloterror
            // 
            this.piloterror.ContainerControl = this;
            // 
            // copiloterror
            // 
            this.copiloterror.ContainerControl = this;
            // 
            // departureerror
            // 
            this.departureerror.ContainerControl = this;
            // 
            // aircrafterror
            // 
            this.aircrafterror.ContainerControl = this;
            // 
            // destinationerror
            // 
            this.destinationerror.ContainerControl = this;
            // 
            // noofseatserror
            // 
            this.noofseatserror.ContainerControl = this;
            // 
            // flighthourerror
            // 
            this.flighthourerror.ContainerControl = this;
            // 
            // bookedseatserror
            // 
            this.bookedseatserror.ContainerControl = this;
            // 
            // progresserror
            // 
            this.progresserror.ContainerControl = this;
            // 
            // destinationcombobox
            // 
            this.destinationcombobox.FormattingEnabled = true;
            this.destinationcombobox.Location = new System.Drawing.Point(325, 320);
            this.destinationcombobox.Name = "destinationcombobox";
            this.destinationcombobox.Size = new System.Drawing.Size(195, 24);
            this.destinationcombobox.TabIndex = 149;
            // 
            // addflight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 551);
            this.Controls.Add(this.destinationcombobox);
            this.Controls.Add(this.depcomboBox);
            this.Controls.Add(this.aircraftcombobox);
            this.Controls.Add(this.depdateandtimepick);
            this.Controls.Add(this.deptime);
            this.Controls.Add(this.flighthourtextbox);
            this.Controls.Add(this.noofseatstextbox);
            this.Controls.Add(this.copilolttextbox);
            this.Controls.Add(this.pilolttextbox);
            this.Controls.Add(this.flighthourlabel);
            this.Controls.Add(this.destinationlabel);
            this.Controls.Add(this.departurelabel);
            this.Controls.Add(this.noofseatslabel);
            this.Controls.Add(this.aircraftlabel);
            this.Controls.Add(this.pilotslabel);
            this.Controls.Add(this.addflightbutton);
            this.Controls.Add(this.addflightlabel);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addflight";
            this.Text = "bookticket";
            this.Load += new System.EventHandler(this.addflight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piloterror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiloterror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departureerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircrafterror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noofseatserror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flighthourerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedseatserror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progresserror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label addflightlabel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ComboBox depcomboBox;
        private System.Windows.Forms.ComboBox aircraftcombobox;
        private System.Windows.Forms.DateTimePicker depdateandtimepick;
        private System.Windows.Forms.Label deptime;
        private System.Windows.Forms.TextBox flighthourtextbox;
        private System.Windows.Forms.TextBox noofseatstextbox;
        private System.Windows.Forms.TextBox copilolttextbox;
        private System.Windows.Forms.TextBox pilolttextbox;
        private System.Windows.Forms.Label flighthourlabel;
        private System.Windows.Forms.Label destinationlabel;
        private System.Windows.Forms.Label departurelabel;
        private System.Windows.Forms.Label noofseatslabel;
        private System.Windows.Forms.Label aircraftlabel;
        private System.Windows.Forms.Label pilotslabel;
        private System.Windows.Forms.Button addflightbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.ErrorProvider piloterror;
        private System.Windows.Forms.ErrorProvider copiloterror;
        private System.Windows.Forms.ErrorProvider departureerror;
        private System.Windows.Forms.ErrorProvider aircrafterror;
        private System.Windows.Forms.ErrorProvider destinationerror;
        private System.Windows.Forms.ErrorProvider noofseatserror;
        private System.Windows.Forms.ErrorProvider flighthourerror;
        private System.Windows.Forms.ErrorProvider bookedseatserror;
        private System.Windows.Forms.ErrorProvider progresserror;
        private System.Windows.Forms.ComboBox destinationcombobox;
    }
}