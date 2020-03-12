namespace WindowsFormsApp1
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.pass2p = new System.Windows.Forms.TextBox();
            this.kurumsalradio = new System.Windows.Forms.RadioButton();
            this.bireyselradio = new System.Windows.Forms.RadioButton();
            this.BireyselKayit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passp = new System.Windows.Forms.TextBox();
            this.usernamep = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.email = new System.Windows.Forms.Label();
            this.emailp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Emailc = new System.Windows.Forms.TextBox();
            this.emailcomp = new System.Windows.Forms.Label();
            this.KurumsalKayit = new System.Windows.Forms.Button();
            this.HphoneC = new System.Windows.Forms.TextBox();
            this.PhoneC = new System.Windows.Forms.TextBox();
            this.TC = new System.Windows.Forms.TextBox();
            this.Cname = new System.Windows.Forms.TextBox();
            this.pass2c = new System.Windows.Forms.TextBox();
            this.Passc = new System.Windows.Forms.TextBox();
            this.UsernameC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Şifre Tekrar";
            // 
            // pass2p
            // 
            this.pass2p.Location = new System.Drawing.Point(85, 95);
            this.pass2p.Name = "pass2p";
            this.pass2p.Size = new System.Drawing.Size(100, 20);
            this.pass2p.TabIndex = 33;
            // 
            // kurumsalradio
            // 
            this.kurumsalradio.AutoSize = true;
            this.kurumsalradio.Location = new System.Drawing.Point(409, 81);
            this.kurumsalradio.Name = "kurumsalradio";
            this.kurumsalradio.Size = new System.Drawing.Size(68, 17);
            this.kurumsalradio.TabIndex = 32;
            this.kurumsalradio.Text = "Kurumsal";
            this.kurumsalradio.UseVisualStyleBackColor = true;
            this.kurumsalradio.CheckedChanged += new System.EventHandler(this.kurumsalradio_CheckedChanged);
            // 
            // bireyselradio
            // 
            this.bireyselradio.AutoSize = true;
            this.bireyselradio.Checked = true;
            this.bireyselradio.Location = new System.Drawing.Point(245, 81);
            this.bireyselradio.Name = "bireyselradio";
            this.bireyselradio.Size = new System.Drawing.Size(61, 17);
            this.bireyselradio.TabIndex = 31;
            this.bireyselradio.TabStop = true;
            this.bireyselradio.Text = "Bireysel";
            this.bireyselradio.UseVisualStyleBackColor = true;
            this.bireyselradio.CheckedChanged += new System.EventHandler(this.bireyselradio_CheckedChanged);
            // 
            // BireyselKayit
            // 
            this.BireyselKayit.Location = new System.Drawing.Point(94, 124);
            this.BireyselKayit.Name = "BireyselKayit";
            this.BireyselKayit.Size = new System.Drawing.Size(75, 23);
            this.BireyselKayit.TabIndex = 30;
            this.BireyselKayit.Text = "Kayıt Ol";
            this.BireyselKayit.UseVisualStyleBackColor = true;
            this.BireyselKayit.Click += new System.EventHandler(this.BireyselKayit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kullanıcı adı";
            // 
            // passp
            // 
            this.passp.Location = new System.Drawing.Point(85, 69);
            this.passp.Name = "passp";
            this.passp.Size = new System.Drawing.Size(100, 20);
            this.passp.TabIndex = 27;
            // 
            // usernamep
            // 
            this.usernamep.Location = new System.Drawing.Point(86, 17);
            this.usernamep.Name = "usernamep";
            this.usernamep.Size = new System.Drawing.Size(100, 20);
            this.usernamep.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.emailp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.usernamep);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.passp);
            this.panel2.Controls.Add(this.pass2p);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BireyselKayit);
            this.panel2.Location = new System.Drawing.Point(151, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 167);
            this.panel2.TabIndex = 53;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(48, 46);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 41;
            this.email.Text = "Email";
            // 
            // emailp
            // 
            this.emailp.Location = new System.Drawing.Point(86, 43);
            this.emailp.Name = "emailp";
            this.emailp.Size = new System.Drawing.Size(100, 20);
            this.emailp.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Emailc);
            this.panel3.Controls.Add(this.emailcomp);
            this.panel3.Controls.Add(this.KurumsalKayit);
            this.panel3.Controls.Add(this.HphoneC);
            this.panel3.Controls.Add(this.PhoneC);
            this.panel3.Controls.Add(this.TC);
            this.panel3.Controls.Add(this.Cname);
            this.panel3.Controls.Add(this.pass2c);
            this.panel3.Controls.Add(this.Passc);
            this.panel3.Controls.Add(this.UsernameC);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(384, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 314);
            this.panel3.TabIndex = 54;
            this.panel3.Visible = false;
            // 
            // Emailc
            // 
            this.Emailc.Location = new System.Drawing.Point(104, 43);
            this.Emailc.Name = "Emailc";
            this.Emailc.Size = new System.Drawing.Size(100, 20);
            this.Emailc.TabIndex = 88;
            // 
            // emailcomp
            // 
            this.emailcomp.AutoSize = true;
            this.emailcomp.Location = new System.Drawing.Point(61, 46);
            this.emailcomp.Name = "emailcomp";
            this.emailcomp.Size = new System.Drawing.Size(32, 13);
            this.emailcomp.TabIndex = 87;
            this.emailcomp.Text = "Email";
            // 
            // KurumsalKayit
            // 
            this.KurumsalKayit.Location = new System.Drawing.Point(116, 251);
            this.KurumsalKayit.Name = "KurumsalKayit";
            this.KurumsalKayit.Size = new System.Drawing.Size(75, 23);
            this.KurumsalKayit.TabIndex = 86;
            this.KurumsalKayit.Text = "Kayıtol";
            this.KurumsalKayit.UseVisualStyleBackColor = true;
            this.KurumsalKayit.Click += new System.EventHandler(this.KurumsalKayit_Click);
            // 
            // HphoneC
            // 
            this.HphoneC.Location = new System.Drawing.Point(105, 199);
            this.HphoneC.Name = "HphoneC";
            this.HphoneC.Size = new System.Drawing.Size(100, 20);
            this.HphoneC.TabIndex = 85;
            // 
            // PhoneC
            // 
            this.PhoneC.Location = new System.Drawing.Point(104, 173);
            this.PhoneC.Name = "PhoneC";
            this.PhoneC.Size = new System.Drawing.Size(100, 20);
            this.PhoneC.TabIndex = 84;
            // 
            // TC
            // 
            this.TC.Location = new System.Drawing.Point(104, 147);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(100, 20);
            this.TC.TabIndex = 83;
            // 
            // Cname
            // 
            this.Cname.Location = new System.Drawing.Point(104, 121);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(100, 20);
            this.Cname.TabIndex = 81;
            // 
            // pass2c
            // 
            this.pass2c.Location = new System.Drawing.Point(104, 95);
            this.pass2c.Name = "pass2c";
            this.pass2c.Size = new System.Drawing.Size(100, 20);
            this.pass2c.TabIndex = 80;
            // 
            // Passc
            // 
            this.Passc.Location = new System.Drawing.Point(104, 69);
            this.Passc.Name = "Passc";
            this.Passc.Size = new System.Drawing.Size(100, 20);
            this.Passc.TabIndex = 79;
            // 
            // UsernameC
            // 
            this.UsernameC.Location = new System.Drawing.Point(103, 17);
            this.UsernameC.Name = "UsernameC";
            this.UsernameC.Size = new System.Drawing.Size(100, 20);
            this.UsernameC.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Sabit Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Cep Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "TC Kimlik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Şirket Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Şifre Tekrar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(22, 12);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 55;
            this.Backbutton.Text = "Geri";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 636);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kurumsalradio);
            this.Controls.Add(this.bireyselradio);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass2p;
        private System.Windows.Forms.RadioButton kurumsalradio;
        private System.Windows.Forms.RadioButton bireyselradio;
        private System.Windows.Forms.Button BireyselKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passp;
        private System.Windows.Forms.TextBox usernamep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KurumsalKayit;
        private System.Windows.Forms.TextBox HphoneC;
        private System.Windows.Forms.TextBox PhoneC;
        private System.Windows.Forms.TextBox TC;
        private System.Windows.Forms.TextBox Cname;
        private System.Windows.Forms.TextBox pass2c;
        private System.Windows.Forms.TextBox Passc;
        private System.Windows.Forms.TextBox UsernameC;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailp;
        private System.Windows.Forms.TextBox Emailc;
        private System.Windows.Forms.Label emailcomp;
        private System.Windows.Forms.Button Backbutton;
    }
}