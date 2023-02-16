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
        public static TextBox t1;
        public static TextBox t2;
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
            t1.AutoSize = true;
            t2.AutoSize = true;
            t1.Location = new Point(24,225);
            t2.Location = new Point(144,225);
            this.Controls.Add(t1);
            this.Controls.Add(t2);
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

        }

        private void valueChanged(object sender, EventArgs e)
        {
            if (gunBox.Checked)
            {
                var height = this.Height;
                this.Height = this.Height + 60;
                button1.Location = new Point(280, 267);
                t1.Show();
                t2.Show();
            }
            else
            {
                this.Height = Height - 60;
                button1.Location = new Point(280, 217);
                t1.Hide();
                t2.Hide();
            }
        }
    }
}
