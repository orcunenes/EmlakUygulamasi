using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class add : Form
    {
        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        public add()
        {
            InitializeComponent();
        }

        private void addthis_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Ilanlar(Price,Room,Square,Age,Floor,Heating,Aidat,Siteici,Esyali,Balkon,ST,Cephe) values ('" + Pprice.Text + "','" + rooms.Text + "','" + sq.Text + "','" + age.Text + "','" + floor.Text + "','" + heating.Text + "','" + aidat.Text + "','" + site.Text + "','" + esya.Text + "','" + balkon.Text + "','" + st.Text + "','" + cephe.Text + "')";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("İlanınız Eklendi.");
        }

        private void resimekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // chose the images type
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
