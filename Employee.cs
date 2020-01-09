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
    public partial class Employee : MetroForm
    {
        public Employee()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\ASAD\University data\Fifth Semester\Visual Programming\Project\New Project\hostel-2.mdb");
        DataSet d1 = new DataSet();
        
        private void Employee_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from Role", con);
            adap1.Fill(d1, "Role");
            con.Open();
            metroComboBox1.DataSource = d1.Tables[0];
            metroComboBox1.DisplayMember = "RoleId";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("Insert into Employee (EmpId,EmpName,DOB,EmailAddress,PhoneNo,State,Salary,RoleId) values ('" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text + "','" + metroComboBox1.Text + "')", con);

            com.ExecuteNonQuery();
            MessageBox.Show("One record added");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("Update Employee set EmpName = '" + metroTextBox2.Text + "', DOB = '" + metroTextBox3.Text + "', EmailAddress = '" + metroTextBox4.Text + "', PhoneNo ='" + metroTextBox5.Text + "' , State = '" + metroTextBox6.Text + "', Salary = '" + metroTextBox7.Text + "', RoleId = '" + metroComboBox1.Text + "' where EmpId = " + metroTextBox1.Text + "", con);
            com.ExecuteNonQuery();
            MessageBox.Show("One Record Updated");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            OleDbCommand com = new OleDbCommand("Delete from Employee where EmpId = " + metroTextBox1.Text + "", con);
            com.ExecuteNonQuery();
            MessageBox.Show("One Record Deleted");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Adminmain am = new Adminmain();
            am.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
