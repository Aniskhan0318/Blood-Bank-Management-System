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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmapj = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmapj, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(bitmapj, 0, 100);
            e.Graphics.DrawString("Blood record", new Font("TimesNewRoman", 20, FontStyle.Bold), Brushes.Blue, new Point(120, 30));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
