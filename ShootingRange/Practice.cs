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
        public Practice()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            base.Hide();
        }

        private void Practice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("DISPOSED");
        }

        private void Practice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("DISPOSED");
        }
        
    }
}
