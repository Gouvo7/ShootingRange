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
    public partial class Shooting : Form
    {
        public Shooting()
        {
            InitializeComponent();
            int num = 1;
            int A = 1;
            comboBox1.Items.Add("ΜΔΑ");
            comboBox1.Items.Add("SPORTS");
            comboBox1.Items.Add("STANDARD");

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

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
        
}
