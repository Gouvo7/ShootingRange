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
            shoot1.Enabled = false;
            shoot3.Enabled = false;
            shoot2.Enabled = false;
            shoot5.Enabled = false;
            shoot7.Enabled = false;
            shoot10Res.Enabled = false;
            shoot8.Enabled = false;
            shoot10.Enabled = false;
            shoot6.Enabled = false;
            shoot4.Enabled = false;
            shoot9.Enabled = false;
            shoot19.Enabled = false;
            shoot14.Enabled = false;
            shoot16.Enabled = false;
            shoot20.Enabled = false;
            shoot18.Enabled = false;
            shoot20Res.Enabled = false;
            shoot17.Enabled = false;
            shoot15.Enabled = false;
            shoot12.Enabled = false;
            shoot13.Enabled = false;
            shoot11.Enabled = false;
            shoot29.Enabled = false;
            shoot24.Enabled = false;
            shoot26.Enabled = false;
            shoot30.Enabled = false;
            shoot28.Enabled = false;
            shoot30Res.Enabled = false;
            shoot27.Enabled = false;
            shoot25.Enabled = false;
            shoot22.Enabled = false;
            shoot23.Enabled = false;
            shoot21.Enabled = false;
            shoot59.Enabled = false;
            shoot54.Enabled = false;
            shoot56.Enabled = false;
            shoot60.Enabled = false;
            shoot58.Enabled = false;
            shoot60Res.Enabled = false;
            shoot57.Enabled = false;
            shoot55.Enabled = false;
            shoot52.Enabled = false;
            shoot53.Enabled = false;
            shoot51.Enabled = false;
            shoot49.Enabled = false;
            shoot44.Enabled = false;
            shoot46.Enabled = false;
            shoot50.Enabled = false;
            shoot48.Enabled = false;
            shoot50Res.Enabled = false;
            shoot47.Enabled = false;
            shoot45.Enabled = false;
            shoot42.Enabled = false;
            shoot43.Enabled = false;
            shoot41.Enabled = false;
            shoot39.Enabled = false;
            shoot34.Enabled = false;

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

        private void Shooting_Load(object sender, EventArgs e)
        {

        }
    }
        
}
