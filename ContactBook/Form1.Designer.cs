namespace ContactBook
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
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.numbertxt = new System.Windows.Forms.TextBox();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.birthdaytxt = new System.Windows.Forms.DateTimePicker();
            this.addc = new System.Windows.Forms.Button();
            this.savec = new System.Windows.Forms.Button();
            this.removec = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Label();
            this.detailstxt = new System.Windows.Forms.TextBox();
            this.contactslist = new System.Windows.Forms.ListView();
            this.epafes = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(222, 126);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(200, 20);
            this.surnametxt.TabIndex = 1;
            
            // 
            // numbertxt
            // 
            this.numbertxt.Location = new System.Drawing.Point(222, 163);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(200, 20);
            this.numbertxt.TabIndex = 2;
            
            this.numbertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbertxt_KeyPress);
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(222, 206);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(200, 20);
            this.mailtxt.TabIndex = 3;
           
           
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(222, 257);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(200, 38);
            this.addresstxt.TabIndex = 4;
          
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.name.ForeColor = System.Drawing.Color.LightGray;
            this.name.Location = new System.Drawing.Point(46, 87);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 16);
            this.name.TabIndex = 6;
            this.name.Text = "Όνομα";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surname.ForeColor = System.Drawing.Color.LightGray;
            this.surname.Location = new System.Drawing.Point(46, 127);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(69, 16);
            this.surname.TabIndex = 7;
            this.surname.Text = "Επώνυμο";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.number.ForeColor = System.Drawing.Color.Gainsboro;
            this.number.Location = new System.Drawing.Point(46, 170);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(79, 16);
            this.number.TabIndex = 8;
            this.number.Text = "Τηλέφωνο";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mail.ForeColor = System.Drawing.Color.LightGray;
            this.mail.Location = new System.Drawing.Point(46, 206);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(52, 16);
            this.mail.TabIndex = 9;
            this.mail.Text = "E-mail";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.address.ForeColor = System.Drawing.Color.LightGray;
            this.address.Location = new System.Drawing.Point(46, 258);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(149, 16);
            this.address.TabIndex = 10;
            this.address.Text = "Διεύθυνση Κατοικίας";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.birthday.ForeColor = System.Drawing.Color.LightGray;
            this.birthday.Location = new System.Drawing.Point(39, 322);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(159, 16);
            this.birthday.TabIndex = 11;
            this.birthday.Text = "Ημερομηνία Γέννησης";
            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(392, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "ATZENTA";
            
            // 
            // birthdaytxt
            // 
            this.birthdaytxt.Location = new System.Drawing.Point(222, 322);
            this.birthdaytxt.Name = "birthdaytxt";
            this.birthdaytxt.Size = new System.Drawing.Size(200, 20);
            this.birthdaytxt.TabIndex = 14;
            
            // 
            // addc
            // 
            this.addc.Location = new System.Drawing.Point(42, 410);
            this.addc.Name = "addc";
            this.addc.Size = new System.Drawing.Size(121, 23);
            this.addc.TabIndex = 15;
            this.addc.Text = "Προσθήκη Επαφής";
            this.addc.UseVisualStyleBackColor = true;
            this.addc.Click += new System.EventHandler(this.addc_Click);
            // 
            // savec
            // 
            this.savec.Location = new System.Drawing.Point(189, 410);
            this.savec.Name = "savec";
            this.savec.Size = new System.Drawing.Size(126, 23);
            this.savec.TabIndex = 16;
            this.savec.Text = "Αποθήκευση Αλλαγών";
            this.savec.UseVisualStyleBackColor = true;
            this.savec.Click += new System.EventHandler(this.savec_Click);
            // 
            // removec
            // 
            this.removec.Location = new System.Drawing.Point(353, 410);
            this.removec.Name = "removec";
            this.removec.Size = new System.Drawing.Size(124, 23);
            this.removec.TabIndex = 17;
            this.removec.Text = "Διαγραφή Επαφής";
            this.removec.UseVisualStyleBackColor = true;
            this.removec.Click += new System.EventHandler(this.removec_Click);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.details.ForeColor = System.Drawing.Color.LightGray;
            this.details.Location = new System.Drawing.Point(42, 375);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(105, 16);
            this.details.TabIndex = 19;
            this.details.Text = "Λεπτομέρειες";
            // 
            // detailstxt
            // 
            this.detailstxt.Location = new System.Drawing.Point(222, 375);
            this.detailstxt.Name = "detailstxt";
            this.detailstxt.Size = new System.Drawing.Size(200, 20);
            this.detailstxt.TabIndex = 20;
            // 
            // contactslist
            // 
            this.contactslist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.contactslist.Location = new System.Drawing.Point(597, 86);
            this.contactslist.Name = "contactslist";
            this.contactslist.Size = new System.Drawing.Size(213, 347);
            this.contactslist.TabIndex = 21;
            this.contactslist.UseCompatibleStateImageBehavior = false;
            this.contactslist.SelectedIndexChanged += new System.EventHandler(this.contactslist_SelectedIndexChanged);
            // 
            // epafes
            // 
            this.epafes.AutoSize = true;
            this.epafes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.epafes.ForeColor = System.Drawing.Color.LightGray;
            this.epafes.Location = new System.Drawing.Point(597, 67);
            this.epafes.Name = "epafes";
            this.epafes.Size = new System.Drawing.Size(61, 16);
            this.epafes.TabIndex = 22;
            this.epafes.Text = "Επαφές";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(222, 83);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(200, 20);
            this.nametxt.TabIndex = 23;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(890, 456);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.epafes);
            this.Controls.Add(this.contactslist);
            this.Controls.Add(this.detailstxt);
            this.Controls.Add(this.details);
            this.Controls.Add(this.removec);
            this.Controls.Add(this.savec);
            this.Controls.Add(this.addc);
            this.Controls.Add(this.birthdaytxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.address);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.number);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.mailtxt);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.surnametxt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox numbertxt;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birthdaytxt;
        private System.Windows.Forms.Button addc;
        private System.Windows.Forms.Button savec;
        private System.Windows.Forms.Button removec;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.TextBox detailstxt;
        private System.Windows.Forms.ListView contactslist;
        private System.Windows.Forms.Label epafes;
        private System.Windows.Forms.TextBox nametxt;
    }
}

