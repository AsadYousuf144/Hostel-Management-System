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
using System.Data.OleDb;

namespace MetroUI
{
    public partial class Studentinfo : MetroForm
    {
        string id;
        public Studentinfo(String s)
        {
            id = s;
            InitializeComponent();
            metroTextBox1.Text = id;
        }

        public Studentinfo()
        {
            // TODO: Complete member initialization
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\ASAD\University data\Fifth Semester\Visual Programming\Project\New Project\hostel-2.mdb");
        DataSet d1 = new DataSet();
        

        private void Studentinfo_Load(object sender, EventArgs e)
        {

            con.Open();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("Update Student set StdName = '" + metroTextBox2.Text + "', DOB = '" + metroTextBox3.Text + "', EmailAddress = '" + metroTextBox4.Text + "', PhoneNo ='" + metroTextBox5.Text + "' , State = '" + metroTextBox6.Text + "', Semester = '" + metroTextBox7.Text + "' where StdId = " + metroTextBox1.Text + "", con);
            com.ExecuteNonQuery();
            MessageBox.Show("One Record Updated");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Canteen c = new Canteen(metroTextBox1.Text);
            c.Show();
            this.Hide();
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            Loginstudent ls = new Loginstudent();
            ls.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
