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
    public partial class NewWeapon : Form
    {
        String ConnString = "Server = localhost; User ID = root; Password = 1234; Database = shoot";
        public static ShootingApp instance;
        public NewWeapon(ShootingApp shootingApp)
        {
            instance = shootingApp;
            shootingApp.Hide();
            InitializeComponent();
            this.Show();
            this.CenterToScreen();
            ButtonSoma.Select();
        }

        private void NewWeapon_Close(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            instance.Show();
        }

        private void Check_Changed(object sender, EventArgs e)
        {
            if (!ButtonSoma.Checked)
            {
                BoxName.Enabled = true;
                BoxSurname.Enabled = true;
                BoxADT.Enabled = true;
                BoxName.Text = "";
                label3.Show();
                label4.Show();
                BoxName.Show();
                BoxSurname.Show();
                BoxADT.Show();
            }
            else
            {
                BoxName.Enabled = false;
                BoxName.Text = "Πήγασος";
                BoxSurname.Enabled = false;
                BoxSurname.Text = "";
                BoxADT.Enabled = false;
                BoxADT.Text = "";

            }
        }

        private void BoxSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(BoxSurname.SelectedItem);
            BoxName.Items.Clear();
            BoxName.Text = "";
            //Console.WriteLine("yes");
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
            BoxName.SelectedItem = 0;
        }

        private void NewWeapon_Load(object sender, EventArgs e)
        {

        }
    }
}
