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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form5 f5 = new Form5();
            //f5.ShowDialog();
            string myconnection = "Data Source=DESKTOP-9J170IF;Initial Catalog=Final_Project;Integrated Security=True";
            SqlConnection myconn = new SqlConnection(myconnection);
            string query = "Select  * from Affectee where CNIC =" + textBox1.Text + " ;";
            SqlCommand cmd = new SqlCommand(query, myconn);
            SqlDataReader myreader;
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                MessageBox.Show("loaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string Myvalue
        {
            get
            {
                return textBox1.Text;
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
