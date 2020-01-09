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
    public partial class Adminmain : MetroForm
    {
        public Adminmain()
        {
            InitializeComponent();
        }

        private void Adminmain_Load(object sender, EventArgs e)
        {

        }
        AStudent AS = new AStudent();
        private void metroTile1_Click(object sender, EventArgs e)
        {
            AS.Show();
            this.Hide();
        }
        Employee ep = new Employee();
        private void metroTile2_Click(object sender, EventArgs e)
        {
            ep.Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
