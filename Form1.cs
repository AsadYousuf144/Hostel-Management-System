using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUI
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Admin ad = new Admin();
        private void metroTile1_Click(object sender, EventArgs e)
        {
            ad.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Loginstudent sl = new Loginstudent();
            sl.Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
