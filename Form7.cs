using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Blood_Bank_System
{
    public partial class Form7 : Form
    {
        string name;
        public Form7(string a)
        {
            InitializeComponent();
            name = a;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connestring = "datasource=localhost;port=3306;username=root;password=12345";
            MySqlConnection con = new MySqlConnection(connestring);
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * FROM blood_bank.donors", con);
            con.Open();
            DataSet datset = new DataSet();
            adapter.Fill(datset, "donors");
            dataGridView1.DataSource = datset.Tables["donors"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connestring = "datasource=localhost;port=3306;username=root;password=12345";
            MySqlConnection con = new MySqlConnection(connestring);
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * FROM blood_bank.patient", con);
            con.Open();
            DataSet pat = new DataSet();
            adapter.Fill(pat, "patient");
            dataGridView1.DataSource = pat.Tables["patient"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {   if (textBox1.Text != "")
            {

                string connestring = "datasource=localhost;port=3306;username=root;password=12345";
                string query = "DELETE FROM `blood_bank`.`donors` WHERE ID ='" + int.Parse(textBox1.Text) + "'";
                MySqlConnection con = new MySqlConnection(connestring);
                MySqlCommand MyCommand2 = new MySqlCommand(query, con);
                MySqlDataReader rea;
                con.Open();
                rea = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (rea.Read())
                {

                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Enter id please");
            }  
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {


                string connestring = "datasource=localhost;port=3306;username=root;password=12345";
                string query = "DELETE FROM `blood_bank`.`patient` WHERE ID ='" + int.Parse(textBox2.Text) + "'";
                MySqlConnection con = new MySqlConnection(connestring);
                MySqlCommand MyCommand2 = new MySqlCommand(query, con);
                MySqlDataReader rea;
                con.Open();
                rea = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (rea.Read())
                {

                }

                con.Close();
            }
            else
            {
                MessageBox.Show("please Enter id");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = ("Welcome Mr " + name);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
