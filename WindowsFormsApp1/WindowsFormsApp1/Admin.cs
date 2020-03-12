using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        public Admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/WindowsFormsApp1/WindowsFormsApp1/Database/Database.s3db;Version=3;"); cmd = new SQLiteCommand();
            cmd = new SQLiteCommand();

            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "select * from ilanlar where onay=0";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pprice.Text = reader[0].ToString();
                rooms.Text = reader[1].ToString();
                sq.Text = reader[2].ToString();
                age.Text = reader[3].ToString();
                floor.Text = reader[4].ToString();
                heating.Text = reader[5].ToString();
                aidat.Text = reader[6].ToString();
                site.Text = reader[7].ToString();
                esya.Text = reader[8].ToString();
                balkon.Text = reader[9].ToString();
                st.Text = reader[10].ToString();
                cephe.Text = reader[11].ToString();
                Baslikt.Text = reader[12].ToString();
                Ilanno.Text = reader[13].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Update ilanlar set onay=1 where Ilanno='" + Ilanno.Text + "'";
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from ilanlar where Ilanno='" + Ilanno.Text + "'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pprice.Text = reader[0].ToString();
                rooms.Text = reader[1].ToString();
                sq.Text = reader[2].ToString();
                age.Text = reader[3].ToString();
                floor.Text = reader[4].ToString();
                heating.Text = reader[5].ToString();
                aidat.Text = reader[6].ToString();
                site.Text = reader[7].ToString();
                esya.Text = reader[8].ToString();
                balkon.Text = reader[9].ToString();
                st.Text = reader[10].ToString();
                cephe.Text = reader[11].ToString();
                Baslikt.Text = reader[12].ToString();
                Ilanno.Text = reader[13].ToString();
            }
            con.Close();
        }
    }
}
