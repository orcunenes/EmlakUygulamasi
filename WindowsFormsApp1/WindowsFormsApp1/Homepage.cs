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
    public partial class Homepage : Form
    {
        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        public Homepage()
        {
            InitializeComponent();
        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source=C:/Users/orcun/Desktop/WindowsFormsApp1/WindowsFormsApp1/Database/Database.s3db;Version=3;");
         /*   cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from ilanlar ";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

            }
            con.Close();*/
           
        }
        private void onsalebutton_Click(object sender, EventArgs e)
        {
            //form satilikform=new satilikform();
            //satilikform.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form kiralikform=new kiralikform();
            //satilikform.show();
        }

        private void ilanekle_Click(object sender, EventArgs e)
        {
            Form add = new add();
            add.Show();
            this.Close();

        }
    }
}
