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
    public partial class AStudent : MetroForm
    {
        public AStudent()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\ASAD\University data\Fifth Semester\Visual Programming\Project\New Project\hostel-2.mdb");
        DataSet d1 = new DataSet();
        DataSet d2 = new DataSet();
        private void AStudent_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Program", con);
            adap.Fill(d1, "Program");
            con.Open();

            metroComboBox1.DataSource = d1.Tables[0];
            metroComboBox1.DisplayMember = "ProgramId";

            OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from Dept", con);
            adap1.Fill(d2, "Dept");
   
            metroComboBox2.DataSource = d2.Tables[0];
            metroComboBox2.DisplayMember = "DeptId";
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            

           OleDbCommand com = new OleDbCommand("Insert into Student (StdId,StdName,DOB,EmailAddress,PhoneNo,State,Semester,ProgramId,DeptId) values ('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text + "','" + metroComboBox1.Text + "','" + metroComboBox2.Text + "')", con);
          
            com.ExecuteNonQuery();
           MessageBox.Show("One record added");
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("Update Student set StdName = '" + metroTextBox2.Text + "', DOB = '" + metroTextBox3.Text + "', EmailAddress = '" + metroTextBox4.Text + "', PhoneNo ='" + metroTextBox5.Text + "' , State = '" + metroTextBox6.Text + "', Semester = '" + metroTextBox7.Text + "', ProgramId = '" + metroComboBox1.Text + "', DeptId = '" + metroComboBox2.Text + "' where StdId = " + metroTextBox1.Text + "", con);
            com.ExecuteNonQuery();
            MessageBox.Show("One Record Updated");
        
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("Delete from Student where StdId = " + metroTextBox1.Text + "", con);
            com.ExecuteNonQuery();
            MessageBox.Show("One Record Deleted");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Adminmain am = new Adminmain();
            am.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            AllocateRoom al = new AllocateRoom();
            al.Show();
            this.Hide();
        }
    }
}
