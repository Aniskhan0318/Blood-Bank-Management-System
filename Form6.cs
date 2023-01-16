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
    public partial class Form6 : Form
    {
        public string a;

        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox1.Text != ""))
            {
                int id = int.Parse(textBox1.Text);
                string password = textBox2.Text;
                string uname;

                int i = 0;
                int j = 1;
                string connestring = "datasource=localhost;port=3306;username=root;password=12345";
                MySqlConnection aut = new MySqlConnection(connestring);
                MySqlDataAdapter addd = new MySqlDataAdapter("SELECT * FROM blood_bank.admin WHERE ID='" + textBox1.Text + " ' and Password = '" + textBox2.Text + "'", aut);
                DataTable dt = new DataTable();
                addd.Fill(dt);
                if (dt.Rows.Count.ToString() == "1")
                {
                    string conestring = "datasource=localhost;port=3306;username=root;password=12345";
                    string query = "SELECT Name FROM `blood_bank`.`admin` WHERE ID ='" + int.Parse(textBox1.Text) + "'";
                    MySqlConnection con = new MySqlConnection(conestring);
                    MySqlCommand MyCommand2 = new MySqlCommand(query, con);
                    MySqlDataReader rea;
                    con.Open();
                    MyCommand2.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                    rea = MyCommand2.ExecuteReader();
                    while (rea.Read())
                    {
                        uname = rea.GetValue(0).ToString();
                        a = uname;
                        /*public string getaname()
                        {
                            return a;
                        }*/

                        Form7 form = new Form7(a);
                        form.Show();
                    }
                    con.Close();


                }
                else
                {
                    MessageBox.Show("Wrong User name or paswword");
                }


                aut.Close();
            }
            else
            {
                MessageBox.Show("Please fill all text boxes");
            }
               
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
