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
    public partial class Form1 : Form
    {
        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        SQLiteCommand cmd2;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/WindowsFormsApp1/WindowsFormsApp1/Database/Database.s3db;Version=3;");

        }
        private void kayıtol_Click(object sender, EventArgs e)
        {
            Form kayitform = new Form2();
            kayitform.Show();
        }

        private void Girisyap_Click(object sender, EventArgs e)
        {   
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from persons ";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0] == username.Text&&reader[2]==password.Text)
                {
                    Form homepage = new Homepage();
                    homepage.Show();
                    this.Close();
                }
            }reader.Close();

            cmd2.CommandText = "select * from Companies ";
            SQLiteDataReader readerC = cmd2.ExecuteReader();
            while (readerC.Read())
            {
                if (readerC[0] == username.Text && readerC[2] == password.Text)
                {
                    Form homepage = new Homepage();
                    homepage.Show();
                    this.Close();
                }
            }
            con.Close();

        }


    }
}
