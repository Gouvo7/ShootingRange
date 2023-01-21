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
    public partial class ShootingApp : Form
    {
        public static ShootingApp instance;
        //String ConnString = "Server = localhost; User ID = root; Password = 12345678; Database = shoot";
        String ConnString = "Server = dbshoot.cyzxisevetss.eu-west-3.rds.amazonaws.com; User ID = root; Password=12345678; Database = shoot;";
        public ShootingApp()
        {
            InitializeComponent();
            instance = this;
            this.CenterToScreen();
            comboBox1.Items.Add("Αναζήτηση");
            comboBox1.Items.Add("Καταχώρηση Βολής");
            comboBox1.Items.Add("Αναφορές");
            comboBox1.SelectedIndex = 0;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.AllowUserToResizeRows = false;

            dateBox.Items.Add("01");
            dateBox.Items.Add("02");
            dateBox.Items.Add("03");
            dateBox.Items.Add("04");
            dateBox.Items.Add("05");
            dateBox.Items.Add("06");
            dateBox.Items.Add("07");
            dateBox.Items.Add("08");
            dateBox.Items.Add("09");
            dateBox.Items.Add("10");
            dateBox.Items.Add("11");
            dateBox.Items.Add("12");
            dateBox.Items.Add("13");
            dateBox.Items.Add("14");
            dateBox.Items.Add("15");
            dateBox.Items.Add("16");
            dateBox.Items.Add("17");
            dateBox.Items.Add("18");
            dateBox.Items.Add("19");
            dateBox.Items.Add("20");
            dateBox.Items.Add("21");
            dateBox.Items.Add("22");
            dateBox.Items.Add("23");
            dateBox.Items.Add("24");
            dateBox.Items.Add("25");
            dateBox.Items.Add("26");
            dateBox.Items.Add("27");
            dateBox.Items.Add("28");
            dateBox.Items.Add("29");
            dateBox.Items.Add("30");
            dateBox.Items.Add("31");
            monthBox.Items.Add("Ιανουάριος");
            monthBox.Items.Add("Φεβρουάριος");
            monthBox.Items.Add("Μάρτιος");
            monthBox.Items.Add("Απρίλιος");
            monthBox.Items.Add("Μάιος");
            monthBox.Items.Add("Ιούνιος");
            monthBox.Items.Add("Ιούλιος");
            monthBox.Items.Add("Αύγουστος");
            monthBox.Items.Add("Σεπτέμβριος");
            monthBox.Items.Add("Οκτώβριος");
            monthBox.Items.Add("Νοέμβριος");
            monthBox.Items.Add("Δεκέμβριος");
            yearBox.Items.Add("2022");
            yearBox.Items.Add("2023");
            yearBox.Items.Add("2024");
            yearBox.Items.Add("2025");
            yearBox.Items.Add("2026");
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
                string query = "SELECT * FROM athl where athl_ID < 1000";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "athl");
                DataTable dt = ds.Tables["athl"];
                List<string> list = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add((string)row["athl_LName"]);
                }
                dataGridView1.DataSource = ds.Tables[0];

                foreach (String x in list)
                {
                    BoxSurname.Items.Add(x);
                }

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
        }

        private void BoxSurname_LostFocus(object sender, EventArgs e)
        {
            //BoxSurname.SelectedIndex = BoxSurname;
            Console.WriteLine("ta exusa");
            MessageBox.Show("Error: Λάθος όνομα χρήστη ή κωδικός.", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (BoxName.Text.Equals(""))
            {
                // μόνο με επώνυμο
            }
            if (BoxSurname.Text.Equals(""))
            {
                MessageBox.Show("Error: Δεν γαμιέσαι; Τι σκατά θα βρω;", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                Console.WriteLine(BoxSurname.Text);
                MySqlConnection conn = new MySqlConnection(ConnString);
                conn.Open();
                
                string query = "SELECT * FROM athl where athl_LName like '%";

                string tmp = BoxSurname.Text+ "%'";
                query = query + tmp;
                Console.WriteLine(query);

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                if (ds != null)
                    da.Fill(ds, "athl");
                    DataTable dt = ds.Tables["athl"];
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception e1)
            {
                Console.WriteLine("Error: {0}", e1.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoxName.Text = "";
            BoxSurname.Text = "";
            BoxName.Items.Clear();
            dataGridView1.ClearSelection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //panel1.Visible = true;
                //panel2.Visible = false;
                //panel3.Visible = false;
                resetDefaults();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                //panel1.Visible = false;
                //panel2.Visible = true;
                //panel3.Visible = false;
                resetDefaults();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                //panel1.Visible = false;
                //panel2.Visible = false;
                //panel3.Visible = true;
                resetDefaults();
                
            }
            
        }

        private void resetDefaults()
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Error: Λάθος όνομα χρήστη ή κωδικός.", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shooting a = new Shooting(this);
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Practice b = new Practice(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string d = "";
            string m = "";
            string y = "";
            if (dateBox.SelectedItem != null)
            {
                d = dateBox.SelectedItem.ToString();
            }
            if (monthBox.SelectedItem != null)
            {
                m = monthBox.SelectedItem.ToString();
                if (m.Equals("Ιανουάριος"))
                { 
                    m = "01";
                }
                else if (m.Equals("Φεβρουάριος"))
                {
                    m = "02";
                }
                else if (m.Equals("Μάρτιος"))
                {
                    m = "03";
                }
                else if (m.Equals("Απρίλιος"))
                {
                    m = "04";
                }
                else if (m.Equals("Μάιος"))
                {
                    m = "05";
                }
                else if (m.Equals("Ιούνιος"))
                {
                    m = "06";
                }
                else if (m.Equals("Ιούλιος"))
                {
                    m = "07";
                }
                else if (m.Equals("Αύγουστος"))
                {
                    m = "08";
                }
                else if (m.Equals("Σεπτέμβριος"))
                {
                    m = "09";
                }
                else if (m.Equals("Οκτώβριος"))
                {
                    m = "10";
                }
                else if (m.Equals("Νοέμβριος"))
                {
                    m = "11";
                }
                else if (m.Equals("Δεκέμβριος"))
                {
                    m = "12";
                }
            }
            if (yearBox.SelectedItem != null) 
            { 
                y = yearBox.SelectedItem.ToString();
            }
            Console.WriteLine(d + m + y);

        }

        private void SurnameLeave(object sender, EventArgs e)
        {
            Console.WriteLine(BoxSurname.SelectedItem);
            if (BoxSurname.SelectedItem != null)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    conn.Open();
                    string query = "SELECT * FROM athl where athl_LName like \'%" + BoxSurname.SelectedItem.ToString() + "%\'";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "athl");
                    DataTable dt = ds.Tables["athl"];
                    Console.WriteLine(dt);
                    List<string> list = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add((string)row["athl_FName"]);
                    }
                    dataGridView1.DataSource = ds.Tables[0];

                    foreach (String x in list)
                    {
                        BoxName.Items.Add(x);
                    }

                    conn.Close();
                }

                catch (Exception e1)
                {
                    Console.WriteLine("Error: {0}", e1.ToString());
                }   
            }
        }

        private void BoxSurname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
