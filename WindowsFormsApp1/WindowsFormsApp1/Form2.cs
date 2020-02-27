using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/WindowsFormsApp1/WindowsFormsApp1/Database/Database.s3db;Version=3;");
        }
        private void bireysel()
        {
            
            panel3.Visible = false;
            panel2.Visible = true;

        }
        private void kurumsal()
        {
            panel3.Visible = true;
            panel2.Visible = false;

        }

        private void BireyselKayit_Click(object sender, EventArgs e)
        {
            if (passp.Text == "" || pass2p.Text == "" || emailp.Text == "" || usernamep.Text == "")
            {
                MessageBox.Show("Boş Giriş yapılamaz");
            }
            else if (passp.Text != pass2p.Text)
            {
                MessageBox.Show("Şifreler Aynı Değil.");
            }
            else
            {
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into persons(Username,Email,Password) values ('" + usernamep.Text + "','" + emailp.Text + "','" + passp.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarılı");
            }
        }

 

        private void bireyselradio_CheckedChanged(object sender, EventArgs e)
        {
            bireysel();
        }

        private void kurumsalradio_CheckedChanged(object sender, EventArgs e)
        {
            kurumsal();
        }

        private void KurumsalKayit_Click(object sender, EventArgs e)
        {
            if (Passc.Text == "" || pass2c.Text == "" || Emailc.Text == "" || UsernameC.Text == ""||TC.Text==""||Cname.Text==""||PhoneC.Text==""||HphoneC.Text=="")
            {
                MessageBox.Show("Boş Giriş yapılamaz");
            }
            else if (Passc.Text != pass2c.Text)
            {
                MessageBox.Show("Şifreler Aynı Değil.");
            }
            else
            {
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into Companies(Username,Email,Password,Companyname,TC,Cphone,Sphone) values ('" + UsernameC.Text + "','" + Emailc.Text + "','" + Passc.Text+"','"+ Cname.Text + "','" + TC.Text+"','"+ PhoneC.Text + "','" + HphoneC.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarılı");
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
