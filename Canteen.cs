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
using System.Data.SqlClient;
namespace MetroUI
{
    public partial class Canteen : MetroForm
    {
        string id;
        public Canteen()
        {
            
            InitializeComponent();
      
        }
        public Canteen(String s)
        {
            id = s;
            InitializeComponent();
            metroLabel9.Text = id;
        }

       
         
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\ASAD\University data\Fifth Semester\Visual Programming\Project\New Project\hostel-2.mdb");
        DataSet d1 = new DataSet();
        DataSet d2 = new DataSet();
        DataSet d3 = new DataSet();
        DataSet d4 = new DataSet();
        DataSet d5 = new DataSet();
       
        private void Canteen_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adap = new OleDbDataAdapter("select * from Canteen", con);
            adap.Fill(d1, "Canteen");
            adap.Fill(d2, "Canteen");
            adap.Fill(d3, "Canteen");
            adap.Fill(d4, "Canteen");

            //OleDbDataAdapter adap2 = new OleDbDataAdapter("select * from Canteen", con);
            //adap.Fill(d2, "Canteen");

            con.Open();

            metroComboBox1.DataSource = d1.Tables[0];
            metroComboBox1.DisplayMember = "Fastfood";

            metroComboBox2.DataSource = d2.Tables[0];
            metroComboBox2.DisplayMember = "Chips";

            metroComboBox3.DataSource = d3.Tables[0];
            metroComboBox3.DisplayMember = "C_Size";

            metroComboBox4.DataSource = d4.Tables[0];
            metroComboBox4.DisplayMember = "Drinktype";
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int d = 0;
            int a = Convert.ToInt16(metroTextBox1.Text);
            int b = Convert.ToInt16(metroTextBox1.Text);
            int c = Convert.ToInt16(metroTextBox1.Text);
            
            

            int amount = 0;
            if (metroComboBox1.Text == "Chicken Burger")
            {
                amount += 80*a;
            }
            else if (metroComboBox1.Text == "Zinger Cheese Burger") {
                amount += 120*a;
            
            }
            else if (metroComboBox1.Text == "Pizza")
            {
                amount += 200*a;
            }

            if (metroComboBox2.Text == "Lays")
            {
                if (metroComboBox3.Text == "Small") {
                    amount += 20 * b;
                
                }
                else if (metroComboBox3.Text == "Medium")
                {
                    amount += 40 * b;

                }
                else if (metroComboBox3.Text == "Large")
                {
                    amount += 70 * b;

                }
            }


            else if (metroComboBox2.Text == "Chatpatta")
            {
                if (metroComboBox3.Text == "Small")
                {
                    amount += 10 * b;

                }
                else if (metroComboBox3.Text == "Medium")
                {
                    amount += 20 * b;

                }
                else if (metroComboBox3.Text == "Large")
                {
                    amount += 30 * b;

                }
            }

            else if (metroComboBox2.Text == "Frio")
            {
                if (metroComboBox3.Text == "Small")
                {
                    amount += 15 * b;

                }
                else if (metroComboBox3.Text == "Medium")
                {
                    amount += 25 * b;

                }
                else if (metroComboBox3.Text == "Large")
                {
                    amount += 35 * b;

                }
            }

            if (metroComboBox4.Text == "Pepsi") {
                amount += 30 * c;
            }
            else if (metroComboBox4.Text == "String")
            {
                amount += 30 * c;
            }
            else if (metroComboBox4.Text == "Dew")
            {
                amount += 30 * c;
            }

            OleDbCommand com = new OleDbCommand("Insert into StdCanteen (Fastfood,F_Quantity,Chips,C_Quantity,C_Size,Drinktype,No_of_drinks,Amount) values ('" + metroComboBox1.Text + "'," + metroTextBox1.Text + ",'" + metroComboBox2.Text + "'," + metroTextBox2.Text + ",'" + metroComboBox3.Text + "','" + metroComboBox4.Text + "'," + metroTextBox3.Text + ", "+amount+")", con);

            com.ExecuteNonQuery();
            MessageBox.Show("One record added");

            metroLabel11.Text = amount.ToString();

           // OleDbDataAdapter adap1 = new OleDbDataAdapter("select count(Amount) from StdCanteen", con);
          // adap1.Fill(d5, "StdCanteen");
           

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            Studentinfo ss = new Studentinfo(id);
            ss.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
