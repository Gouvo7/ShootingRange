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
    public partial class Practice : Form
    {
        public static ShootingApp instance;
        public Practice(ShootingApp shoot)
        {
            instance = shoot;
            instance.Hide();
            this.Show();
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void Practice_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Practice_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance.Show();
        }
        
    }
}
