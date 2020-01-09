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
    public partial class Admin : MetroForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
            metroTextBox2.UseSystemPasswordChar = true;
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
        Adminmain am = new Adminmain();
        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (metroTextBox1.Text == "Admin" && metroTextBox2.Text == "123")
            {
                am.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Username and password is invalid");
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
