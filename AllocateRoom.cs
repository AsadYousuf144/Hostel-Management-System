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
    public partial class AllocateRoom : MetroForm
    {

        public AllocateRoom()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\ASAD\University data\Fifth Semester\Visual Programming\Project\New Project\hostel-2.mdb");
        DataSet d1 = new DataSet();
        DataSet d2 = new DataSet();
        DataSet d3 = new DataSet();
        DataSet d4 = new DataSet("Booking");
        private void AllocateRoom_Load(object sender, EventArgs e)
        {
            //OleDbDataAdapter adap = new OleDbDataAdapter("select * from Room", con);
            //adap.Fill(d1, "Room");
            con.Open();
            //metroComboBox1.DataSource = d1.Tables[0];
            //metroComboBox1.DisplayMember = "RoomName";

            OleDbDataAdapter adap1 = new OleDbDataAdapter("select * from Student", con);
            adap1.Fill(d2, "Student");
            metroComboBox2.DataSource = d2.Tables[0];
            metroComboBox2.DisplayMember = "StdId";

            OleDbDataAdapter adap3 = new OleDbDataAdapter("select * from RoomType", con);
            adap3.Fill(d3, "Room");
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }
        int counter = 0;
        private void metroButton2_Click(object sender, EventArgs e)
        {

            try
            {

              
                OleDbCommand com = new OleDbCommand("Insert into Room (StdId,RoomName,RoomPrice,RoomType) values(" + metroComboBox2.Text + "," + metroTextBox2.Text + "," + metroTextBox5.Text + ",'" + metroTextBox3.Text + "')", con);
             
                com.ExecuteNonQuery();

                // con.Open();
                OleDbCommand com1 = new OleDbCommand("Insert into RoomType (RoomType,RoomDescription) values('" + metroTextBox3.Text + "','" + metroTextBox4.Text + "')", con);
              
                com1.ExecuteNonQuery();

                // con.Open();
                //OleDbCommand com6 = new OleDbCommand ();
                //com.Connection = con;
                //com6.CommandText="insert into Booking(BookingId,BookingData,Check-in-Date,Check-out-Date,Year,Amount) values("+ metroTextBox8.Text + ",'" + metroTextBox10.Text + "','" + metroTextBox1.Text + "','" + metroTextBox7.Text + "'," + metroTextBox6.Text + "," + metroTextBox9.Text + "";
                //com6.ExecuteNonQuery();

                MessageBox.Show("Record Inserted");
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {

            OleDbCommand com3 = new OleDbCommand("Delete from Room where StdId = " + metroComboBox2.Text + "", con);
            com3.ExecuteNonQuery();

            //OleDbCommand com7 = new OleDbCommand("Delete from Booking where BookingId = " + metroTextBox8.Text + "", con);
            //com7.ExecuteNonQuery();

            MessageBox.Show("One row deleted");
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            AStudent aa = new AStudent();
            aa.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    OleDbCommand com6 = new OleDbCommand();
            //    com6.Connection = con;
            //    com6.CommandText = "insert into Booking(BookingId,BookingData,Check-in-Date,Check-out-Date,Year,Amount) values(" + metroTextBox8.Text + ",'" + metroTextBox10.Text + "','" + metroTextBox1.Text + "','" + metroTextBox7.Text + "'," + metroTextBox6.Text + "," + metroTextBox9.Text + "";
            //    com6.ExecuteNonQuery();
            //    con.Close();
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error"+ex);
            //}

            //try
            //{
            //    con.Open();
            //    OleDbCommand command = new OleDbCommand();
            //    command.Connection = con;
            //    command.CommandText = "insert into Booking (BookingId,BookingDate,Check_in_Date,Check_out_Date,Time,Year,Amount) values ("+metroTextBox8.Text+","+metroTextBox10.Text+","+metroTextBox1.Text+","+metroTextBox7.Text+","+metroTextBox6.Text+","+metroTextBox9.Text+")";
            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Data Insert Successfully!");
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error  " + ex);
            //}

            try
            {
                OleDbCommand com7 = new OleDbCommand("insert into Booking(BookingId,BookingDate,Check_in_Date,Check_out_Date,Amount) values (" + Convert.ToInt16(metroTextBox8.Text) + ",'"+metroTextBox10.Text+"','"+metroTextBox1.Text+"','"+metroTextBox7.Text+"',"+Convert.ToInt16(metroTextBox9.Text)+")", con);

                com7.ExecuteNonQuery();

                MessageBox.Show("One row Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            OleDbCommand com7 = new OleDbCommand("Delete from Booking where BookingId = " + metroTextBox8.Text + "", con);
            com7.ExecuteNonQuery();

            MessageBox.Show("One row deleted");
        }
    }
}
