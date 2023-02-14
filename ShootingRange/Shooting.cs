using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace ShootingRange
{
    public partial class Shooting : Form
    {
        int number = 0;
        public static ShootingApp instance;
        String ConnString = "Server = localhost; User ID = root; Password = 1234; Database = shoot";
        //String ConnString = "Server = dbshoot.cyzxisevetss.eu-west-3.rds.amazonaws.com; User ID = root; Password = 123456789; Database = shoot";
        public Shooting(ShootingApp shootingApp)
        {
            instance = shootingApp;
            shootingApp.Hide();

            InitializeComponent();
            this.CenterToScreen();
            int num = 1;
            int A = 1;
            this.Visible = true;
            comboBox1.Items.Add("ΜΔΑ");
            comboBox1.Items.Add("SPORTS");
            comboBox1.Items.Add("STANDARD");
            shoot10Res.Enabled = false;
            shoot20Res.Enabled = false;
            shoot30Res.Enabled = false;
            shoot40Res.Enabled = false;
            shoot50Res.Enabled = false;
            shoot60Res.Enabled = false;
            if (ConnString != null)
            {
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
                    foreach (String x in list)
                    {
                        BoxSurname.Items.Add(x);
                    }

                    query = "SELECT ammo_type from apothema;";
                    MySqlDataAdapter db = new MySqlDataAdapter(query, conn);
                    db.Fill(ds, "apothema");
                    dt = ds.Tables["apothema"];
                    List<string> list1 = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list1.Add((string)row["ammo_type"]);
                    }
                    foreach (String x in list1)
                    {
                        BoxAmmoMM.Items.Add(x);
                    }
                    conn.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.ToString());
                }
            }
        }
        public void Start1()
        {

        }
        int A = 1;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void addButton_Click(object sender, EventArgs e)
        {

            AddNewTextBox();
        }
        public System.Windows.Forms.TextBox AddNewTextBox()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            Controls.Add(txt);
      
            txt.Top = A * 28;
            txt.Left = 15;
            txt.Text = "Textbox" + this.A.ToString();
            A = A + 1;
            return txt;
        }
        public void label4_Click()
        {

        }

        private void Shooting_Load(object sender, EventArgs e)
        {

        }

        private void rngShots_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            shoot1.Text = rnd.Next(1, 10).ToString();
            shoot2.Text = rnd.Next(1, 10).ToString();
            shoot3.Text = rnd.Next(1, 10).ToString();
            shoot4.Text = rnd.Next(1, 10).ToString();
            shoot5.Text = rnd.Next(1, 10).ToString();
            shoot6.Text = rnd.Next(1, 10).ToString();
            shoot7.Text = rnd.Next(1, 10).ToString();
            shoot8.Text = rnd.Next(1, 10).ToString();
            shoot9.Text = rnd.Next(1, 10).ToString();
            shoot10.Text = rnd.Next(1, 10).ToString();
            shoot11.Text = rnd.Next(1, 10).ToString();
            shoot12.Text = rnd.Next(1, 10).ToString();
            shoot13.Text = rnd.Next(1, 10).ToString();
            shoot14.Text = rnd.Next(1, 10).ToString();
            shoot15.Text = rnd.Next(1, 10).ToString();
            shoot16.Text = rnd.Next(1, 10).ToString();
            shoot17.Text = rnd.Next(1, 10).ToString();
            shoot18.Text = rnd.Next(1, 10).ToString();
            shoot19.Text = rnd.Next(1, 10).ToString();
            shoot20.Text = rnd.Next(1, 10).ToString();
            shoot21.Text = rnd.Next(1, 10).ToString();
            shoot22.Text = rnd.Next(1, 10).ToString();
            shoot23.Text = rnd.Next(1, 10).ToString();
            shoot24.Text = rnd.Next(1, 10).ToString();
            shoot25.Text = rnd.Next(1, 10).ToString();
            shoot26.Text = rnd.Next(1, 10).ToString();
            shoot27.Text = rnd.Next(1, 10).ToString();
            shoot28.Text = rnd.Next(1, 10).ToString();
            shoot29.Text = rnd.Next(1, 10).ToString();
            shoot30.Text = rnd.Next(1, 10).ToString();
            shoot31.Text = rnd.Next(1, 10).ToString();
            shoot32.Text = rnd.Next(1, 10).ToString();
            shoot33.Text = rnd.Next(1, 10).ToString();
            shoot34.Text = rnd.Next(1, 10).ToString();
            shoot35.Text = rnd.Next(1, 10).ToString();
            shoot36.Text = rnd.Next(1, 10).ToString();
            shoot37.Text = rnd.Next(1, 10).ToString();
            shoot38.Text = rnd.Next(1, 10).ToString();
            shoot39.Text = rnd.Next(1, 10).ToString();
            shoot40.Text = rnd.Next(1, 10).ToString();
            shoot41.Text = rnd.Next(1, 10).ToString();
            shoot42.Text = rnd.Next(1, 10).ToString();
            shoot43.Text = rnd.Next(1, 10).ToString();
            shoot44.Text = rnd.Next(1, 10).ToString();
            shoot45.Text = rnd.Next(1, 10).ToString();
            shoot46.Text = rnd.Next(1, 10).ToString();
            shoot47.Text = rnd.Next(1, 10).ToString();
            shoot48.Text = rnd.Next(1, 10).ToString();
            shoot49.Text = rnd.Next(1, 10).ToString();
            shoot50.Text = rnd.Next(1, 10).ToString();
            shoot51.Text = rnd.Next(1, 10).ToString();
            shoot52.Text = rnd.Next(1, 10).ToString();
            shoot53.Text = rnd.Next(1, 10).ToString();
            shoot54.Text = rnd.Next(1, 10).ToString();
            shoot55.Text = rnd.Next(1, 10).ToString();
            shoot56.Text = rnd.Next(1, 10).ToString();
            shoot57.Text = rnd.Next(1, 10).ToString();
            shoot58.Text = rnd.Next(1, 10).ToString();
            shoot59.Text = rnd.Next(1, 10).ToString();
            shoot60.Text = rnd.Next(1, 10).ToString();
            txt1_Leave(sender,e);
            txt2_Leave(sender, e);
            txt3_Leave(sender, e);
            txt4_Leave(sender, e);
            txt5_Leave(sender, e);
            txt6_Leave(sender, e);
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                if (shoot1.Text != null && shoot1.Text != "")
                {
                    res = res + Int32.Parse(shoot1.Text);
                }
                if (shoot2.Text != null && shoot2.Text != "")
                {
                    res = res + Int32.Parse(shoot2.Text);
                }
                if (shoot3.Text != null && shoot3.Text != "")
                {
                    res = res + Int32.Parse(shoot3.Text);
                }
                if (shoot4.Text != null && shoot4.Text != "")
                {
                    res = res + Int32.Parse(shoot4.Text);
                }
                if (shoot5.Text != null && shoot5.Text != "")
                {
                    res = res + Int32.Parse(shoot5.Text);
                }
                if (shoot6.Text != null && shoot6.Text != "")
                {
                    res = res + Int32.Parse(shoot6.Text);
                }
                if (shoot7.Text != null && shoot7.Text != "")
                {
                    res = res + Int32.Parse(shoot7.Text);
                }
                if (shoot8.Text != null && shoot8.Text != "")
                {
                    res = res + Int32.Parse(shoot8.Text);
                }
                if (shoot9.Text != null && shoot9.Text != "")
                {
                    res = res + Int32.Parse(shoot9.Text);
                }
                if (shoot10.Text != null && shoot10.Text != "")
                {
                    res = res + Int32.Parse(shoot10.Text);
                }
                shoot10Res.Text = res.ToString();
            }
            catch (FormatException)
            {
                //Console.WriteLine("Το σκορ πρέπει να είναι ακέραια τιμή!");
                MessageBox.Show("Error: Το σκορ πρέπει να είναι ακέραια τιμή!", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                shoot1.Text = "";
                shoot2.Text = "";
                shoot3.Text = "";
                shoot4.Text = "";
                shoot5.Text = "";
                shoot6.Text = "";
                shoot7.Text = "";
                shoot8.Text = "";
                shoot9.Text = "";
                shoot10.Text = "";
                shoot10Res.Text = "";
            }

            
        }

        private void txt2_Leave(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                if (shoot11.Text != null && shoot11.Text != "")
                {
                    res = res + Int32.Parse(shoot11.Text);
                }
                if (shoot12.Text != null && shoot12.Text != "")
                {
                    res = res + Int32.Parse(shoot12.Text);
                }
                if (shoot13.Text != null && shoot13.Text != "")
                {
                    res = res + Int32.Parse(shoot13.Text);
                }
                if (shoot14.Text != null && shoot14.Text != "")
                {
                    res = res + Int32.Parse(shoot14.Text);
                }
                if (shoot15.Text != null && shoot15.Text != "")
                {
                    res = res + Int32.Parse(shoot15.Text);
                }
                if (shoot16.Text != null && shoot16.Text != "")
                {
                    res = res + Int32.Parse(shoot16.Text);
                }
                if (shoot17.Text != null && shoot17.Text != "")
                {
                    res = res + Int32.Parse(shoot17.Text);
                }
                if (shoot18.Text != null && shoot18.Text != "")
                {
                    res = res + Int32.Parse(shoot18.Text);
                }
                if (shoot19.Text != null && shoot19.Text != "")
                {
                    res = res + Int32.Parse(shoot19.Text);
                }
                if (shoot20.Text != null && shoot20.Text != "")
                {
                    res = res + Int32.Parse(shoot20.Text);
                }
                shoot20Res.Text = res.ToString();
            }
            catch (FormatException)
            {
                //Console.WriteLine("Το σκορ πρέπει να είναι ακέραια τιμή!");
                MessageBox.Show("Error: Το σκορ πρέπει να είναι ακέραια τιμή!", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                shoot11.Text = "";
                shoot12.Text = "";
                shoot13.Text = "";
                shoot14.Text = "";
                shoot15.Text = "";
                shoot16.Text = "";
                shoot17.Text = "";
                shoot18.Text = "";
                shoot19.Text = "";
                shoot20.Text = "";
                shoot20Res.Text = "";
            }
        }

        private void txt3_Leave(object sender, EventArgs e)
        {
            int res = 0;
            if (shoot21.Text != null && shoot21.Text != "")
            {
                res = res + Int32.Parse(shoot21.Text);
            }
            if (shoot22.Text != null && shoot22.Text != "")
            {
                res = res + Int32.Parse(shoot22.Text);
            }
            if (shoot23.Text != null && shoot23.Text != "")
            {
                res = res + Int32.Parse(shoot23.Text);
            }
            if (shoot24.Text != null && shoot24.Text != "")
            {
                res = res + Int32.Parse(shoot24.Text);
            }
            if (shoot25.Text != null && shoot25.Text != "")
            {
                res = res + Int32.Parse(shoot25.Text);
            }
            if (shoot26.Text != null && shoot26.Text != "")
            {
                res = res + Int32.Parse(shoot26.Text);
            }
            if (shoot27.Text != null && shoot27.Text != "")
            {
                res = res + Int32.Parse(shoot27.Text);
            }
            if (shoot28.Text != null && shoot28.Text != "")
            {
                res = res + Int32.Parse(shoot28.Text);
            }
            if (shoot29.Text != null && shoot29.Text != "")
            {
                res = res + Int32.Parse(shoot29.Text);
            }
            if (shoot30.Text != null && shoot30.Text != "")
            {
                res = res + Int32.Parse(shoot30.Text);
            }
            shoot30Res.Text = res.ToString();
        }
        private void txt4_Leave(object sender, EventArgs e)
        {
            int res = 0;
            if (shoot31.Text != null && shoot31.Text != "")
            {
                res = res + Int32.Parse(shoot31.Text);
            }
            if (shoot32.Text != null && shoot32.Text != "")
            {
                res = res + Int32.Parse(shoot32.Text);
            }
            if (shoot33.Text != null && shoot33.Text != "")
            {
                res = res + Int32.Parse(shoot33.Text);
            }
            if (shoot34.Text != null && shoot34.Text != "")
            {
                res = res + Int32.Parse(shoot34.Text);
            }
            if (shoot35.Text != null && shoot35.Text != "")
            {
                res = res + Int32.Parse(shoot35.Text);
            }
            if (shoot36.Text != null && shoot36.Text != "")
            {
                res = res + Int32.Parse(shoot36.Text);
            }
            if (shoot37.Text != null && shoot37.Text != "")
            {
                res = res + Int32.Parse(shoot37.Text);
            }
            if (shoot38.Text != null && shoot38.Text != "")
            {
                res = res + Int32.Parse(shoot38.Text);
            }
            if (shoot39.Text != null && shoot39.Text != "")
            {
                res = res + Int32.Parse(shoot39.Text);
            }
            if (shoot40.Text != null && shoot40.Text != "")
            {
                res = res + Int32.Parse(shoot40.Text);
            }
            shoot40Res.Text = res.ToString();
        }
        private void txt5_Leave(object sender, EventArgs e)
        {
            int res = 0;
            if (shoot41.Text != null && shoot41.Text != "")
            {
                res = res + Int32.Parse(shoot41.Text);
            }
            if (shoot42.Text != null && shoot42.Text != "")
            {
                res = res + Int32.Parse(shoot42.Text);
            }
            if (shoot43.Text != null && shoot43.Text != "")
            {
                res = res + Int32.Parse(shoot43.Text);
            }
            if (shoot44.Text != null && shoot44.Text != "")
            {
                res = res + Int32.Parse(shoot44.Text);
            }
            if (shoot45.Text != null && shoot45.Text != "")
            {
                res = res + Int32.Parse(shoot45.Text);
            }
            if (shoot46.Text != null && shoot46.Text != "")
            {
                res = res + Int32.Parse(shoot46.Text);
            }
            if (shoot47.Text != null && shoot47.Text != "")
            {
                res = res + Int32.Parse(shoot47.Text);
            }
            if (shoot48.Text != null && shoot48.Text != "")
            {
                res = res + Int32.Parse(shoot48.Text);
            }
            if (shoot49.Text != null && shoot49.Text != "")
            {
                res = res + Int32.Parse(shoot49.Text);
            }
            if (shoot50.Text != null && shoot50.Text != "")
            {
                res = res + Int32.Parse(shoot50.Text);
            }
            shoot50Res.Text = res.ToString();
        }
        private void txt6_Leave(object sender, EventArgs e)
        {
            int res = 0;
            if (shoot51.Text != null && shoot51.Text != "")
            {
                res = res + Int32.Parse(shoot51.Text);
            }
            if (shoot52.Text != null && shoot52.Text != "")
            {
                res = res + Int32.Parse(shoot52.Text);
            }
            if (shoot53.Text != null && shoot53.Text != "")
            {
                res = res + Int32.Parse(shoot53.Text);
            }
            if (shoot54.Text != null && shoot54.Text != "")
            {
                res = res + Int32.Parse(shoot54.Text);
            }
            if (shoot55.Text != null && shoot55.Text != "")
            {
                res = res + Int32.Parse(shoot55.Text);
            }
            if (shoot56.Text != null && shoot56.Text != "")
            {
                res = res + Int32.Parse(shoot56.Text);
            }
            if (shoot57.Text != null && shoot57.Text != "")
            {
                res = res + Int32.Parse(shoot57.Text);
            }
            if (shoot58.Text != null && shoot58.Text != "")
            {
                res = res + Int32.Parse(shoot58.Text);
            }
            if (shoot59.Text != null && shoot59.Text != "")
            {
                res = res + Int32.Parse(shoot59.Text);
            }
            if (shoot60.Text != null && shoot60.Text != "")
            {
                res = res + Int32.Parse(shoot60.Text);
            }
            shoot60Res.Text = res.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            shoot1.Text = "";
            shoot2.Text = "";
            shoot3.Text = "";
            shoot4.Text = "";
            shoot5.Text = "";
            shoot6.Text = "";
            shoot7.Text = "";
            shoot8.Text = "";
            shoot9.Text = "";
            shoot10.Text = "";
            shoot11.Text = "";
            shoot12.Text = "";
            shoot13.Text = "";
            shoot14.Text = "";
            shoot15.Text = "";
            shoot16.Text = "";
            shoot17.Text = "";
            shoot18.Text = "";
            shoot19.Text = "";
            shoot20.Text = "";
            shoot21.Text = "";
            shoot22.Text = "";
            shoot23.Text = "";
            shoot24.Text = "";
            shoot25.Text = "";
            shoot26.Text = "";
            shoot27.Text = "";
            shoot28.Text = "";
            shoot29.Text = "";
            shoot30.Text = "";
            shoot31.Text = "";
            shoot32.Text = "";
            shoot33.Text = "";
            shoot34.Text = "";
            shoot35.Text = "";
            shoot36.Text = "";
            shoot37.Text = "";
            shoot38.Text = "";
            shoot39.Text = "";
            shoot40.Text = "";
            shoot41.Text = "";
            shoot42.Text = "";
            shoot43.Text = "";
            shoot44.Text = "";
            shoot45.Text = "";
            shoot46.Text = "";
            shoot47.Text = "";
            shoot48.Text = "";
            shoot49.Text = "";
            shoot50.Text = "";
            shoot51.Text = "";
            shoot52.Text = "";
            shoot53.Text = "";
            shoot54.Text = "";
            shoot55.Text = "";
            shoot56.Text = "";
            shoot57.Text = "";
            shoot58.Text = "";
            shoot59.Text = "";
            shoot60.Text = "";
            shoot10Res.Text = "";
            shoot20Res.Text = "";
            shoot30Res.Text = "";
            shoot40Res.Text = "";
            shoot50Res.Text = "";
            shoot60Res.Text = "";
        }


        private void Shooting_Leave(object sender, EventArgs e)
        {
        }

        private void Shooting_Closed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            instance.Show();
        }

        private void BoxSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxName.Items.Clear();
            BoxName.Text = "";
            BoxMhtrwo.Items.Clear();
            BoxMhtrwo.Text = "";
            BoxSullogos.Items.Clear();
            BoxSullogos.Text = "";
            BoxTupos.Items.Clear();
            BoxTupos.Text = "";
            BoxArOplou.Items.Clear();
            BoxArOplou.Text = "";
            //BoxArAdeia.Items.Clear();
            //BoxArAdeia.SelectedItem = "";
            BoxProvider.Items.Clear();
            BoxProvider.Text = "";

            //BoxAmmoConsum.Items.Clear();
            //BoxAmmoConsum.SelectedItem = "";
            BoxAmmoStr.Items.Clear();
            BoxAmmoStr.Text = "";
            BoxActivityType.Items.Clear();
            BoxActivityType.Text = "";

            //BoxMhtrwo.SelectedIndex = 0 ;
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

        private void BoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxMhtrwo.Items.Clear();
            BoxMhtrwo.Text = "";
            BoxSullogos.Items.Clear();
            BoxSullogos.Text = "";
            BoxTupos.Items.Clear();
            BoxTupos.Text = "";
            BoxArOplou.Items.Clear();
            BoxArOplou.Text = "";
            //BoxArAdeia.Items.Clear();
            //BoxArAdeia.SelectedItem = "";
            BoxProvider.Items.Clear();
            BoxProvider.Text = "";

            //BoxAmmoConsum.Items.Clear();
            //BoxAmmoConsum.SelectedItem = "";
            BoxAmmoStr.Items.Clear();
            BoxAmmoStr.Text = "";
            BoxActivityType.Items.Clear();
            BoxActivityType.Text = "";
            //BoxName.Items.Clear();
            Console.WriteLine(BoxSurname.SelectedItem);
            if (BoxSurname.SelectedItem != null)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    conn.Open();
                    string query = "SELECT * FROM athl where athl_LName like \'%" + BoxSurname.SelectedItem.ToString() + "%\' and athl_FName like \'%" + BoxName.SelectedItem.ToString() + "%\';";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "athl");
                    DataTable dt = ds.Tables["athl"];
                    Console.WriteLine(dt);
                    List<string> list = new List<string>();
                    List<string> list1 = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add((string)row["athl_Mhtrwo"]);
                        list1.Add((string)row["athl_Org"]);
                    }

                    foreach (String x in list)
                    {
                        BoxMhtrwo.Items.Add(x);
                    }
                    foreach (String y in list1)
                    {
                        BoxSullogos.Items.Add(y);
                    }

                    conn.Close();
                }

                catch (Exception e1)
                {
                    Console.WriteLine("Error: {0}", e1.ToString());
                }
            }
        }
        private void Submit(object sender, EventArgs e)
        {
            try
            {
                int x1 = Int32.Parse(shoot1.Text);
                int x2 = Int32.Parse(shoot2.Text);
                int x3 = Int32.Parse(shoot3.Text);
                int x4 = Int32.Parse(shoot4.Text);
                int x5 = Int32.Parse(shoot5.Text);
                int x6 = Int32.Parse(shoot6.Text);
                int x7 = Int32.Parse(shoot7.Text);
                int x8 = Int32.Parse(shoot8.Text);
                int x9 = Int32.Parse(shoot9.Text);
                int x10 = Int32.Parse(shoot10.Text);
                int x11 = Int32.Parse(shoot11.Text);
                int x12 = Int32.Parse(shoot12.Text);
                int x13 = Int32.Parse(shoot13.Text);
                int x14 = Int32.Parse(shoot14.Text);
                int x15 = Int32.Parse(shoot15.Text);
                int x16 = Int32.Parse(shoot16.Text);
                int x17 = Int32.Parse(shoot17.Text);
                int x18 = Int32.Parse(shoot18.Text);
                int x19 = Int32.Parse(shoot19.Text);
                int x20 = Int32.Parse(shoot20.Text);
                int x21 = Int32.Parse(shoot21.Text);
                int x22 = Int32.Parse(shoot22.Text);
                int x23 = Int32.Parse(shoot23.Text);
                int x24 = Int32.Parse(shoot24.Text);
                int x25 = Int32.Parse(shoot25.Text);
                int x26 = Int32.Parse(shoot26.Text);
                int x27 = Int32.Parse(shoot27.Text);
                int x28 = Int32.Parse(shoot28.Text);
                int x29 = Int32.Parse(shoot29.Text);
                int x30 = Int32.Parse(shoot30.Text);
                int x31 = Int32.Parse(shoot31.Text);
                int x32 = Int32.Parse(shoot32.Text);
                int x33 = Int32.Parse(shoot33.Text);
                int x34 = Int32.Parse(shoot34.Text);
                int x35 = Int32.Parse(shoot35.Text);
                int x36 = Int32.Parse(shoot36.Text);
                int x37 = Int32.Parse(shoot37.Text);
                int x38 = Int32.Parse(shoot38.Text);
                int x39 = Int32.Parse(shoot39.Text);
                int x40 = Int32.Parse(shoot40.Text);
                int x41 = Int32.Parse(shoot41.Text);
                int x42 = Int32.Parse(shoot42.Text);
                int x43 = Int32.Parse(shoot43.Text);
                int x44 = Int32.Parse(shoot44.Text);
                int x45 = Int32.Parse(shoot45.Text);
                int x46 = Int32.Parse(shoot46.Text);
                int x47 = Int32.Parse(shoot47.Text);
                int x48 = Int32.Parse(shoot48.Text);
                int x49 = Int32.Parse(shoot49.Text);
                int x50 = Int32.Parse(shoot50.Text);
                int x51 = Int32.Parse(shoot51.Text);
                int x52 = Int32.Parse(shoot52.Text);
                int x53 = Int32.Parse(shoot53.Text);
                int x54 = Int32.Parse(shoot54.Text);
                int x55 = Int32.Parse(shoot55.Text);
                int x56 = Int32.Parse(shoot56.Text);
                int x57 = Int32.Parse(shoot57.Text);
                int x58 = Int32.Parse(shoot58.Text);
                int x59 = Int32.Parse(shoot59.Text);
                int x60 = Int32.Parse(shoot60.Text);
                
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse ");
            }
        }
    }
        
}
