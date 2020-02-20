using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        }

        private void Kurumsalkayit_Click(object sender, EventArgs e)
        {

        }

        private void bireyselradio_CheckedChanged(object sender, EventArgs e)
        {
            bireysel();
        }

        private void kurumsalradio_CheckedChanged(object sender, EventArgs e)
        {
            kurumsal();
        }
    }
}
