using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MetroUI
{
    public partial class Loginstudent : MetroForm
    {
        public Loginstudent()
        {
            InitializeComponent();
        }
       OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\ASAD\University data\Fifth Semester\Visual Programming\Project\New Project\hostel-2.mdb");
        DataSet d1 = new DataSet();
        DataSet d2 = new DataSet();
       
        private void Loginstudent_Load(object sender, EventArgs e)
        {
           // OleDbDataAdapter adap = new OleDbDataAdapter("select * from Student", con);
            //adap.Fill(d1, "Student");

            //con.Open();
            metroTextBox2.UseSystemPasswordChar = true;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Student where StdId = " + metroTextBox1.Text + " and Password = " + metroTextBox2.Text + " ", con);
            
            adap.Fill(d2, "Student");

            Studentinfo si = new Studentinfo(metroTextBox1.Text);
            si.Show();
            this.Hide();
           //Studentinfo s = new Studentinfo();

            //try
            //{
            //    string constring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\ASAD\University data\Fifth Semester\Visual Programming\Project\New Project\hostel-2.mdb";
            //    OleDbConnection conDataBase = new OleDbConnection(constring);
            //    OleDbCommand cmdDataBase = new OleDbCommand("Select * from Student where StdId=" + this.metroTextBox1.Text + " and Password=" + this.metroTextBox2.Text + ";", conDataBase);
            //    OleDbDataReader myReader;

            //    conDataBase.Open();
            //    myReader = cmdDataBase.ExecuteReader();
            //    int count = 0;
            //    while (myReader.Read())
            //    {
            //        count = count + 1;
            //    }
            //    if (count == 1)
            //    {
            //        MessageBox.Show("Login Successful");
            //        this.Hide();
            //        //Cafe c = new Cafe();
            //        Studentinfo s = new Studentinfo();
            //        s.Show();
            //    }
            //    else if (count > 1)
            //    {
            //        MessageBox.Show("Duplicate Username or Password");
            //    }
            //    else
            //        MessageBox.Show("Username or Password do not match");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
