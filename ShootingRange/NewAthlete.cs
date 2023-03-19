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

namespace ShootingRange
{
    public partial class NewAthlete : Form
    {
        private static TextBox t1;
        private static TextBox t2;

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
                MessageBox.Show("Η καταχώρηση του καινούργιου αθλητή ήταν επιτυχής.", "Επιτυχής Καταχώρηση Αθλητή", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                // MySQL insert
                //exit form
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
