using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShootingRange
{
    public partial class Form1 : Form
    {

        // String ConnString = "Server = localhost; User ID = root; Password = gouvoop; Database = testdb";
        String ConnString = "Server = 10.1.11.28; User ID = ngouvousis; Password=Nek@niro_{Gou22}; Database = lawdb;";
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Αναζήτηση");
            comboBox1.Items.Add("Καταχώρηση Βολής");
            comboBox1.Items.Add("Αναφορές");
            comboBox1.SelectedIndex = 0;


            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            //Console.OutputEncoding = "chcp 1253");

            //Console.OutputEncoding = System.Text.Encoding.GetEncoding("unicode");
            String greek = "Λάκης";
            byte[] tmp1 = Encoding.Unicode.GetBytes(greek);
            //byte c = 'á';
            Console.WriteLine(Encoding.GetEncoding("unicode").GetString(tmp1));
            Console.WriteLine(greek);
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnString);
                conn.Open();
                string query = "SELECT * FROM lawdb.wcm_con where wcmcon_ID < 1000";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "courses");
                DataTable dt = ds.Tables["courses"];
                Console.WriteLine(dt);

                
                dataGridView1.DataSource = ds.Tables[0];
                
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(textBox1.Text);
                MySqlConnection conn = new MySqlConnection(ConnString);
                conn.Open();
                
                string query = "SELECT * FROM wcm_con where wcmcon_Alias like '%";
                // byte[] tmp = textBox2.Text;
                //tmp = Encoding.UTF8.GetString(tmp);
                //byte z
                string tmp = textBox2.Text + "%'";
                query = query + tmp;
                Console.WriteLine(query);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                if (ds != null)
                    da.Fill(ds, "wcm_con");
                    DataTable dt = ds.Tables["wcm_con"];
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception e1)
            {
                Console.WriteLine("Error: {0}", e1.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dataGridView1.ClearSelection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                resetDefaults();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                resetDefaults();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                resetDefaults();
                
            }
            
        }

        private void resetDefaults()
        {
            if (panel1.Visible)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
