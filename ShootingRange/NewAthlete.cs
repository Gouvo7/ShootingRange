using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingRange
{
    public partial class NewAthlete : Form
    {
        public static ShootingApp instance;
        public NewAthlete(ShootingApp shoot)
        {
            instance = shoot;
            instance.Hide();
            this.Show();
            InitializeComponent();
            this.CenterToScreen();
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

        }
    }
}
