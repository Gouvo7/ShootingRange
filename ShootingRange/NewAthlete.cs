using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace ShootingRange
{
    public partial class NewAthlete : Form
    {
        private static TextBox t1;
        private static TextBox t2;
        private string ConnString = "Server = localhost; User ID = root; Password = 1234; Database = shoot";
        public static ShootingApp instance;
        public NewAthlete(ShootingApp shoot)
        {
            instance = shoot;
            instance.Hide();
            this.Show();
            InitializeComponent();
            this.CenterToScreen();

            t1 = new TextBox();
            t2 = new TextBox();
            //t1.AutoSize = true;
            //t2.AutoSize = true;
            
            
            //labelAd.Location = new Point(24, 205);
            t1.Location = new Point(380,170);
            //labelAr.Location = new Point(144, 205);
            t2.Location = new Point(500,170);
            this.Controls.Add(t1);
            this.Controls.Add(t2);
            labelAd.Hide();
            labelAr.Hide();
            t1.Hide();
            t2.Hide();

        }

        private void NewAthlete_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasGun = false;
            string surname = SurnameBox.Text;
            string name = NameBox.Text;
            string fname = FathernameBox.Text;
            string mname = MothernameBox.Text;
            string adt = ADTBox.Text;
            string amka = AMKABox.Text;
            string bday = BirthdayBox.Text;
            string address = AddressBox.Text;
            string address_num = AddrNumberBox.Text;
            string tk = PostalBox.Text;
            string region = RegionBox.Text;
            string stathero = LandlineBox.Text;
            string kinhto = MobileBox.Text;
            string email = EmailBox.Text;
            string mhtrwo = MhtrwoBox.Text;
            string sullogos = OrganizationBox.Text;
            string ar_oplou = "";
            string ad_oplou = "";

            Utility util = new Utility();
            int tmp;
            if (gunBox.Checked)
            {
                ar_oplou = t1.Text;
                ad_oplou = t2.Text;
                hasGun = true;
                tmp = util.checker(surname, name, fname, mname, adt, amka, bday, address, address_num, tk, region, stathero, kinhto, email, mhtrwo, sullogos, ar_oplou, ad_oplou);
            }
            else
            {
                tmp = util.checker(surname, name, fname, mname, adt, amka, bday, address, address_num, tk, region, stathero, kinhto, email, mhtrwo, sullogos);
            }
            if (tmp == 0)
            {
                try
                {
                    DateTime z;
                    z = DateTime.Parse(BirthdayBox.Text);
                    string adr = address + " " + address_num + ", " + tk + " " + region;
                    string query = "INSERT INTO ATHL (athl_FName, athl_LName, athl_FatherName, athl_MotherName, athl_ADT, athl_AMKA, athl_Mhtrwo, athl_Org, athl_Bday, athl_Email, athl_Phone,athl_Landline, athl_address) " +
                        "VALUES (@fname,@lname,@fathername,@mothername,@adt,@amka,@mhtrwo,@sullogos,@bday,@email,@mobile,@landline,@address)";
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.Add("@fname", DbType.String).Value = name;
                    cmd.Parameters.Add("@lname", DbType.String).Value = surname;
                    cmd.Parameters.Add("@fathername", DbType.String).Value = fname;
                    cmd.Parameters.Add("@mothername", DbType.String).Value = mname;
                    cmd.Parameters.Add("@adt", DbType.String).Value = adt;
                    cmd.Parameters.Add("@amka", DbType.String).Value = amka;
                    cmd.Parameters.Add("@mhtrwo", DbType.String).Value = mhtrwo;
                    cmd.Parameters.Add("@sullogos", DbType.String).Value = sullogos;
                    cmd.Parameters.Add("@bday", DbType.Date).Value = z.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@email", DbType.String).Value = email;
                    cmd.Parameters.Add("@mobile", DbType.String).Value = kinhto;
                    cmd.Parameters.Add("@landline", DbType.String).Value = stathero;
                    cmd.Parameters.Add("@address", DbType.String).Value = adr;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Η καταχώρηση του καινούργιου αθλητή ήταν επιτυχής.", "Επιτυχής Καταχώρηση Αθλητή", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch (MySqlException db)
                {
                    MessageBox.Show("Πρόβλημα σύνδεσης με την βάση δεδομένων", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Πρόβλημα με το μορφότυπο των δεδομένων", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Console.WriteLine("Wrong values!");
            }
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if (gunBox.Checked)
            {
                //var height = this.Height;
                //this.Height = this.Height + 60;
                //button1.Location = new Point(280, 267);
                labelAd.Show();
                labelAr.Show();
                t1.Show();
                t2.Show();
            }
            else
            {
                //this.Height = Height - 60;
                //button1.Location = new Point(280, 217);
                labelAd.Hide();
                labelAr.Hide();
                t1.Hide();
                t2.Hide();
            }
        }
    }
}
