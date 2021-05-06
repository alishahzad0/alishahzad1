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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myconnection = "Data Source=DESKTOP-9J170IF;Initial Catalog=Final_Project;Integrated Security=True";
            SqlConnection myconn = new SqlConnection(myconnection);
            string query = "Insert into Education_Service (education_center_ID, no_of_classroom,workshops_offered,no_of_std,serviceID) values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text +"','"+this.textBox4.Text+"','"+this.textBox5.Text+ "');";
            SqlCommand cmd = new SqlCommand(query, myconn);
            SqlDataReader myreader;
            try
            {
                myconn.Open();
                myreader = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                this.Hide();
                Form6 f6 = new Form6();
                f6.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();

        }
    }
}
