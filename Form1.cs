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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = new ComboBox();
         //   combobox.Items.Insert(0, "Select type");
            // comboBox1_intervals.Items.Add (new ListItem("Database Administrator"));
            //combobox.SelectedText="Select Type";
            //combobox.Text = "Abc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string myconnection = "Data Source=DESKTOP-9J170IF;Initial Catalog=Final_Project;Integrated Security=True";
         SqlConnection myconn = new SqlConnection(myconnection);
         myconn.Open();
         if (myconn.State == ConnectionState.Open)
         {
             MessageBox.Show("Connected");
             this.Hide();
             
             if (comboBox1.Text=="Employee")
             {
                 Form2 f2 = new Form2();
                 f2.ShowDialog();
             }
             else
                 if (comboBox1.Text == "Database Administrator")
                 {
                     Form5 f5 = new Form5();
                     f5.ShowDialog();
                 }
         }
         else
         {
             MessageBox.Show("Failed");
         }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
