using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Final_Project_Database
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myconnection = "Data Source=DESKTOP-9J170IF;Initial Catalog=Final_Project;Integrated Security=True";
            SqlConnection myconn = new SqlConnection(myconnection);
            string query = "create view [Employee_and_Affectee_Details] AS select employee.employee_name, employee.employee_ID, affectee.name, affectee.cnic from affectee inner join employee ON employee.employee_ID=affectee.employee_ID;";
            SqlCommand cmd = new SqlCommand(query, myconn);
            SqlDataReader myreader;
            try
            {
                myconn.Open();
                myreader = cmd.ExecuteReader();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            Form18 f18 = new Form18();
            f18.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myconnection = "Data Source=DESKTOP-9J170IF;Initial Catalog=Final_Project;Integrated Security=True";
            SqlConnection myconn = new SqlConnection(myconnection);
            string query = "create view [donation_details] as select donor.name, donor.donorID, funds.funds_collected, funds.date from donor inner join funds on donor.donorID =funds.donorID ";
          
            
            SqlCommand cmd = new SqlCommand(query, myconn);
            SqlDataReader myreader;
            try
            {
                myconn.Open();
                myreader = cmd.ExecuteReader();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            Form19 f19 = new Form19();
            f19.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
