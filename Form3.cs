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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name;
            string Fname;
            int Age;
            string Bgroup;
            long Contact;
            string Address;
            string Mcondition;
            float Amount;
            if ((textBox1.Text != " ") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != "") && (textBox7.Text != "") && (textBox8.Text != ""))
            {
                Name = textBox1.Text;
                Fname = textBox2.Text;
                Age = int.Parse(textBox3.Text);
                Bgroup = textBox4.Text;
                Contact = long.Parse(textBox5.Text);
                Address = textBox6.Text;
                Mcondition = textBox7.Text;
                Amount = int.Parse(textBox8.Text);

                Class1 a = new Class1(Name, Fname, Age, Bgroup, Contact, Address, Mcondition, Amount);

                label17.Text = a.getname();
                label16.Text = a.getfname();
                label15.Text = Convert.ToString(a.getage());
                label14.Text = a.getbgroup();
                label13.Text = Convert.ToString(a.getcontact());
                label12.Text = a.getaddress();
                label11.Text = a.getmcondition();
                label10.Text = Convert.ToString(a.getamount());
            }
            else
            {
                MessageBox.Show("Please Fill the Information");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Name;
                string Fname;
                int Age;
                string Bgroup;
                long Contact;
                string Address;
                string Mcondition;
                float Amount;


                Name = textBox1.Text;
                Fname = textBox2.Text;
                Age = int.Parse(textBox3.Text);
                Bgroup = textBox4.Text;
                Contact = long.Parse(textBox5.Text);
                Address = textBox6.Text;
                Mcondition = textBox7.Text;
                Amount = int.Parse(textBox8.Text);

                Class2 obj = new Class2(Name, Fname, Age, Bgroup, Contact, Address, Mcondition, Amount);


                string connestring = "datasource=localhost;port=3306;username=root;password=12345";
                MySqlConnection con = new MySqlConnection(connestring);
                con.Open();
                string insert = "insert into blood_bank.patient (Name, Father_Name, Age, Blood_Group, Contact, Address, Medical_Condition, Amount_in_Liters) values('" + obj.getname() + "','" + obj.getfname() + "','" + obj.getage() + "','" + obj.getbgroup() + "','" + obj.getcontact() + "','" + obj.getaddress() + "','" + obj.getmcondition() + "','" + obj.getamount() + "')";
                MySqlCommand cmd = new MySqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
