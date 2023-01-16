using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
//using Pomelo.EntityFrameworkCore.MySql;
using System.Configuration;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace ShootingRange
{
    public partial class LoginForm : Form
    {
        String ConnString = "Server = localhost; User ID = root; Password = 12345678; Database = shoot";
        public LoginForm()
        {
            
            //String ConnString = "Server = dbshoot.cyzxisevetss.eu-west-3.rds.amazonaws.com; User ID = root; Password = 1234; Database = shoot";
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            var appConfig = ConfigurationManager.AppSettings;
            string dbname = appConfig["shoot"];
            string username = appConfig["root"];
            string password = appConfig["1234"];
            string hostname = appConfig["dbshoot.cyzxisevetss.eu-west-3.rds.amazonaws.com"];
            string port = appConfig["3306"];
            string str = "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
            //:base(str);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;
            bool attempt = false;
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnString);
                conn.Open();
                
                string query = $"SELECT * FROM user where user_username = '{user}' and user_pass = '{pass}';";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "user");
                DataTable dt = ds.Tables["user"];
                Console.WriteLine(query);
                
                if (dt.Rows.Count != 0)
                {
                    Console.WriteLine("Correct!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error: Λάθος όνομα χρήστη ή κωδικός.", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception y)
            {
                Console.WriteLine("Error: {0}", y.ToString());
            }
                
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
                Application.Exit();
        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
