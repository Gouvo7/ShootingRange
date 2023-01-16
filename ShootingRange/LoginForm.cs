﻿using MySqlConnector;
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
using System.Data.Common;


namespace ShootingRange
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            String ConnString = "Server=dbshoot.cyzxisevetss.eu-west-3.rds.amazonaws.com; User ID = root; Password = 12345678; Database = dbshoot";
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            //string str = "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
            //:base(str);

            MySqlConnection conn = new MySqlConnection(ConnString);
            conn.Open();
            string query = "SELECT * FROM lawdb.wcm_ind where wcmcon_ID < 1000";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "courses");
            DataTable dt = ds.Tables["courses"];
            Console.WriteLine(dt);
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add((string)row["wcmIND_LastName"]);
            }
            //dataGridView1.DataSource = ds.Tables[0];

            foreach (String x in list)
            {
                //BoxSurname.Items.Add(x);
            }

            conn.Close();

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

            bool correct = false;
            if (user.Equals("admin"))
            {
                if (pass.Equals("1234"))
                {
                    correct = true;
                    
                }
            }
            if (correct)
                this.Dispose();
            else
                MessageBox.Show("Error: Λάθος όνομα χρήστη ή κωδικός.","Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
