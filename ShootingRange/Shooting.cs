using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Text.RegularExpressions;



namespace ShootingRange
{
    public partial class Shooting : Form
    {
        int number = 0;
        public static ShootingApp instance;
        String ConnString = "Server = localhost; User ID = root; Password = 1234; Database = shoot";
        //String ConnString = "Server = dbshoot.cyzxisevetss.eu-west-3.rds.amazonaws.com; User ID = root; Password = 123456789; Database = shoot";
        public Shooting(ShootingApp shootingApp)
        {
            instance = shootingApp;
            shootingApp.Hide();

            InitializeComponent();
            this.CenterToScreen();
            int num = 1;
            int A = 1;
            this.Visible = true;
            comboBox1.Items.Add("ΜΔΑ");
            comboBox1.Items.Add("SPORTS");
            comboBox1.Items.Add("STANDARD");
            comboBox1.SelectedIndex = 0;
            BoxAmmoStr.Items.Add("Σωματείο");
            BoxAmmoStr.Items.Add("Αθλητή");
            BoxAmmoStr.Items.Add("Μικτή");
            BoxActivityType.Items.Add("Αγώνας");
            BoxActivityType.Items.Add("Προπόνηση");
            BoxActivityType.Items.Add("Αγώνας/Προπόνηση");
            BoxActivityType.SelectedIndex = 0;
            BoxHour.Items.Add("08:00-09:00");
            BoxHour.Items.Add("09:00-10:00");
            BoxHour.Items.Add("10:00-11:00");
            BoxHour.Items.Add("11:00-12:00");
            BoxHour.Items.Add("12:00-13:00");
            BoxHour.Items.Add("13:00-14:00");
            BoxHour.Items.Add("14:00-15:00");
            BoxHour.Items.Add("15:00-16:00");
            BoxHour.Items.Add("16:00-17:00");
            BoxHour.Items.Add("17:00-18:00");
            BoxHour.Items.Add("18:00-19:00");
            BoxHour.Items.Add("19:00-20:00");
            BoxHour.SelectedIndex = 0;
            shoot10Res.Enabled = false;
            shoot20Res.Enabled = false;
            shoot30Res.Enabled = false;
            shoot40Res.Enabled = false;
            shoot50Res.Enabled = false;
            shoot60Res.Enabled = false;
            BoxProvider.Enabled = false;
            if (ConnString != null)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    conn.Open();
                    string query = "SELECT * FROM athl where athl_ID < 1000";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "athl");
                    DataTable dt = ds.Tables["athl"];
                    List<string> list = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add((string)row["athl_LName"]);
                    }
                    list = list.Distinct().ToList();
                    foreach (String x in list)
                    {
                        BoxSurname.Items.Add(x);

                    }

                    query = "SELECT ammo_type from apothema;";
                    MySqlDataAdapter db = new MySqlDataAdapter(query, conn);
                    db.Fill(ds, "apothema");
                    dt = ds.Tables["apothema"];
                    List<string> list1 = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list1.Add((string)row["ammo_type"]);
                    }
                    foreach (String x in list1)
                    {
                        BoxAmmoMM.Items.Add(x);
                    }
                    BoxAmmoMM.SelectedIndex = 0;
                    query = "select distinct weapon_TypeName from weapon;";
                    MySqlDataAdapter dc = new MySqlDataAdapter(query, conn);
                    dc.Fill(ds, "weapon");
                    dt = ds.Tables["weapon"];
                    List<string> list2 = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list2.Add((string)row["weapon_TypeName"]);
                    }
                    foreach (String x in list2)
                    {
                        BoxTupos.Items.Add(x);
                    }
                    conn.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.ToString());
                }
                if (BoxAmmoStr.Items.Count > 0)
                    BoxAmmoStr.SelectedIndex = 0;
                BoxAmmoStr.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        int A = 1;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void Shooting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearValues();
        }

        private void Shooting_Leave(object sender, EventArgs e)
        {
        }

        private void Shooting_Closed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            instance.Show();
        }

        private void BoxSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoxName.Items.Clear();
            BoxName.Text = "";
            Clear_Fields();
            Console.WriteLine(BoxSurname.SelectedItem);
            if (BoxSurname.SelectedItem != null)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    conn.Open();
                    string query = "SELECT * FROM athl where athl_LName like \'%" + BoxSurname.Text + "%\'";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "athl");
                    DataTable dt = ds.Tables["athl"];
                    List<string> list = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add((string)row["athl_FName"]);
                    }

                    foreach (String x in list)
                    {
                        BoxName.Items.Add(x);
                    }

                    conn.Close();
                }

                catch (Exception e1)
                {
                    Console.WriteLine("Error: {0}", e1.ToString());
                }
            }
        }
        private void Clear_Fields()
        {
            BoxMhtrwo.Items.Clear();
            BoxMhtrwo.Text = "";
            BoxSullogos.Items.Clear();
            BoxSullogos.Text = "";
            BoxArOplou.Items.Clear();
            BoxArOplou.Text = "";
            BoxArAdeia.Items.Clear();
            BoxArAdeia.Text = "";
            BoxProvider.Text = "";
        }

        private void BoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear_Fields();
            if (BoxSurname.SelectedItem != null)
            {
                try
                {

                    MySqlConnection conn = new MySqlConnection(ConnString);
                    conn.Open();
                    string query = "SELECT * FROM athl where athl_LName = \'" + BoxSurname.Text + "\' and athl_FName = \'" + BoxName.Text + "\';";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "athl");
                    DataTable dt = ds.Tables["athl"];
                    List<string> list = new List<string>();
                    List<string> list1 = new List<string>();
                    string ar_adeia = "";
                    int athl_ID = (int)dt.Rows[0]["athl_ID"];
                    if (dt.Rows.Count == 0)
                    {
                        Clear_Fields();
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        list.Add((string)row["athl_Mhtrwo"]);
                        list1.Add((string)row["athl_Org"]);
                        ar_adeia = (string)row["athl_ArAdeias"];
                    }

                    foreach (String x in list)
                    {
                        BoxMhtrwo.Items.Add(x);
                    }
                    foreach (String y in list1)
                    {
                        BoxSullogos.Items.Add(y);
                    }
                    if (ar_adeia != null)
                        BoxArAdeia.Items.Add(ar_adeia);
                    if (BoxArAdeia.Items.Count > 0)
                        BoxArAdeia.SelectedIndex = 0;
                    if (BoxMhtrwo.Items.Count > 0)
                        BoxMhtrwo.SelectedIndex = 0;
                    if (BoxSullogos.Items.Count > 0)
                        BoxSullogos.SelectedIndex = 0;
                    if (BoxTupos.Items.Count > 0)
                        BoxTupos.SelectedIndex = 0;
                    query = "select * from weapon where (athl_ID = 0  or athl_ID =" + athl_ID + " );";
                    MySqlDataAdapter db = new MySqlDataAdapter(query, conn);
                    db.Fill(ds, "weapon");
                    DataTable dt1 = ds.Tables["weapon"];
                    List<string> list2 = new List<string>();
                    foreach (DataRow row in dt1.Rows)
                    {
                        list2.Add((string)row["weapon_Arithmos"]);
                    }
                    foreach (String x in list2)
                    {
                        BoxArOplou.Items.Add(x);
                    }
                    if (BoxArOplou.Items.Count > 0)
                        BoxArOplou.SelectedIndex = 0;
                    conn.Close();
                }

                catch (Exception e1)
                {
                    Console.WriteLine("Error: {0}", e1.ToString());
                }
            }
        }

        private void BoxArOplouChanged(object sender, EventArgs e)
        {
            if (BoxArOplou.Items.Count > 0)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnString);
                    conn.Open();
                    string query = "select * from weapon where weapon_Arithmos = \'" + BoxArOplou.SelectedItem.ToString() + "\';";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "weapon");
                    DataTable dt = ds.Tables["weapon"];
                    List<string> list = new List<string>();
                    List<string> list1 = new List<string>();
                    string ar_adeia = "";
                    int athl_ID = (int)dt.Rows[0]["athl_ID"];
                    if (athl_ID == 0)
                    {
                        BoxProvider.Text = "Σωματείο";
                    }
                    else
                    {
                        BoxProvider.Text = "Αθλητής";
                    }
                    conn.Close();
                }
                catch (Exception e1)
                {
                    Console.WriteLine("Error: {0}", e1.ToString());
                }
            }
        }

        private void BoxStr_Changed(object sender, EventArgs e)
        {
            int x = BoxAmmoStr.SelectedIndex;
            if (x == 0)
            {
                AmmoOrg.Enabled = true;
                AmmoAth.Enabled = false;
                AmmoAth.Clear();
            }
            else if (x == 1)
            {
                AmmoOrg.Enabled = false;
                AmmoAth.Enabled = true;
                AmmoOrg.Clear();
            }
            else
            {
                AmmoOrg.Enabled = true;
                AmmoAth.Enabled = true;
            }
        }

        private void BoxActivityType_Index_Changed(object sender, EventArgs e)
        {
            if (BoxActivityType.SelectedIndex == 0)
            {
                EnableEdit();
            }
            else if (BoxActivityType.SelectedIndex == 1)
            {
                DisableEdit();
                clearValues();
            }
            else if (BoxActivityType.SelectedIndex == 2)
            {
                EnableEdit();
            }

        }

        private void Submit(object sender, EventArgs e)
        {
            bool valid = true;
            int type = 0;
            int shells = 0;
            int x1;
            int x2;
            int x3;
            int x4;
            int x5;
            int x6;
            int x7;
            int x8;
            int x9;
            int x10;
            int x11;
            int x12;
            int x13;
            int x14;
            int x15;
            int x16;
            int x17;
            int x18;
            int x19;
            int x20;
            int x21;
            int x22;
            int x23;
            int x24;
            int x25;
            int x26;
            int x27;
            int x28;
            int x29;
            int x30;
            int x31;
            int x32;
            int x33;
            int x34;
            int x35;
            int x36;
            int x37;
            int x38;
            int x39;
            int x40;
            int x41;
            int x42;
            int x43;
            int x44;
            int x45;
            int x46;
            int x47;
            int x48;
            int x49;
            int x50;
            int x51;
            int x52;
            int x53;
            int x54;
            int x55;
            int x56;
            int x57;
            int x58;
            int x59;
            int x60;
            if (BoxActivityType.SelectedIndex == 0 || BoxActivityType.SelectedIndex == 2)
            {
                
                if (BoxActivityType.SelectedIndex == 0) { 
                    type = 1;
                }
                else { 
                    type = 2;
                }
                if (BoxAmmoStr.SelectedIndex == 0)
                {
                    try
                    {
                        shells = Int32.Parse(AmmoOrg.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Οι καταναλωθέντες σφαίρες του σωματείου πρέπει να είναι ακέραιος αριθμός!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                }
                else if (BoxAmmoStr.SelectedIndex == 1)
                {
                    try
                    {
                        shells = Int32.Parse(AmmoAth.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Οι καταναλωθέντες σφαίρες του αθλητή πρέπει να είναι ακέραιος αριθμός!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                }
                else
                {
                    try
                    {
                        int shells_org = Int32.Parse(AmmoOrg.Text);
                        int shells_ath = Int32.Parse(AmmoAth.Text);
                        shells = shells_org + shells_ath;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Για την δήλωση μίξης σφαιρών, απαιτείται η συμπλήρωση και των 2 πεδίων!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                }
                if (valid)
                {
                    if (shells < 60)
                    {
                        MessageBox.Show("Για τα είδη δραστηριότητας 'Αγώνας' ή 'Αγώνας/Προπόνηση', πρέπει ο αριθμός των καταναλωθέντων σφαιρών να είναι μεγαλύτερος από 60.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                    else
                    { 
                        Regex reg_date = new Regex(@"(^0[1-9]|[12][0-9]|3[01])\/(0[1-9]|1[0-2])\/(\d{4}$)");
                        if (!reg_date.IsMatch(BoxDate.Text))
                        {
                            MessageBox.Show("Η ημερομηνία δεν είναι σε σωστή μορφή!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (valuesFilled())
                            {
                                bool completed = false;
                                try
                                {
                                    x1 = Int32.Parse(shoot1.Text);
                                    x2 = Int32.Parse(shoot2.Text);
                                    x3 = Int32.Parse(shoot3.Text);
                                    x4 = Int32.Parse(shoot4.Text);
                                    x5 = Int32.Parse(shoot5.Text);
                                    x6 = Int32.Parse(shoot6.Text);
                                    x7 = Int32.Parse(shoot7.Text);
                                    x8 = Int32.Parse(shoot8.Text);
                                    x9 = Int32.Parse(shoot9.Text);
                                    x10 = Int32.Parse(shoot10.Text);
                                    x11 = Int32.Parse(shoot11.Text);
                                    x12 = Int32.Parse(shoot12.Text);
                                    x13 = Int32.Parse(shoot13.Text);
                                    x14 = Int32.Parse(shoot14.Text);
                                    x15 = Int32.Parse(shoot15.Text);
                                    x16 = Int32.Parse(shoot16.Text);
                                    x17 = Int32.Parse(shoot17.Text);
                                    x18 = Int32.Parse(shoot18.Text);
                                    x19 = Int32.Parse(shoot19.Text);
                                    x20 = Int32.Parse(shoot20.Text);
                                    x21 = Int32.Parse(shoot21.Text);
                                    x22 = Int32.Parse(shoot22.Text);
                                    x23 = Int32.Parse(shoot23.Text);
                                    x24 = Int32.Parse(shoot24.Text);
                                    x25 = Int32.Parse(shoot25.Text);
                                    x26 = Int32.Parse(shoot26.Text);
                                    x27 = Int32.Parse(shoot27.Text);
                                    x28 = Int32.Parse(shoot28.Text);
                                    x29 = Int32.Parse(shoot29.Text);
                                    x30 = Int32.Parse(shoot30.Text);
                                    x31 = Int32.Parse(shoot31.Text);
                                    x32 = Int32.Parse(shoot32.Text);
                                    x33 = Int32.Parse(shoot33.Text);
                                    x34 = Int32.Parse(shoot34.Text);
                                    x35 = Int32.Parse(shoot35.Text);
                                    x36 = Int32.Parse(shoot36.Text);
                                    x37 = Int32.Parse(shoot37.Text);
                                    x38 = Int32.Parse(shoot38.Text);
                                    x39 = Int32.Parse(shoot39.Text);
                                    x40 = Int32.Parse(shoot40.Text);
                                    x41 = Int32.Parse(shoot41.Text);
                                    x42 = Int32.Parse(shoot42.Text);
                                    x43 = Int32.Parse(shoot43.Text);
                                    x44 = Int32.Parse(shoot44.Text);
                                    x45 = Int32.Parse(shoot45.Text);
                                    x46 = Int32.Parse(shoot46.Text);
                                    x47 = Int32.Parse(shoot47.Text);
                                    x48 = Int32.Parse(shoot48.Text);
                                    x49 = Int32.Parse(shoot49.Text);
                                    x50 = Int32.Parse(shoot50.Text);
                                    x51 = Int32.Parse(shoot51.Text);
                                    x52 = Int32.Parse(shoot52.Text);
                                    x53 = Int32.Parse(shoot53.Text);
                                    x54 = Int32.Parse(shoot54.Text);
                                    x55 = Int32.Parse(shoot55.Text);
                                    x56 = Int32.Parse(shoot56.Text);
                                    x57 = Int32.Parse(shoot57.Text);
                                    x58 = Int32.Parse(shoot58.Text);
                                    x59 = Int32.Parse(shoot59.Text);
                                    x60 = Int32.Parse(shoot60.Text);
                                    MySqlConnection conn = new MySqlConnection(ConnString);
                                    conn.Open();
                                    string query = "SELECT athl_ID FROM SHOOT.ATHL WHERE athl_LName = \'" + BoxSurname.Text + "\' AND athl_FName = \'" + BoxName.Text + "\';";
                                    string date = BoxDate.Text;

                                    MySqlDataAdapter d = new MySqlDataAdapter(query, conn);
                                    DataSet ds1 = new DataSet();
                                    d.Fill(ds1, "athl");
                                    DataTable dt1 = ds1.Tables["athl"];
                                    string athlete_ID = (string)dt1.Rows[0]["athl_ID"].ToString();
                                    conn.Close();

                                    DateTime n;
                                    n = DateTime.Parse(BoxDate.Text);
                                    Console.WriteLine(n.ToString("yyyy-MM-dd"));

                                    query = "INSERT INTO SHOTS_A ( athl_ID, Activity_Type, shots_Date, shots_1, shots_2, shots_3, shots_4, shots_5, shots_6, shots_7, shots_8, shots_9, shots_10, shots_10R," +
                                        " shots_11, shots_12, shots_13, shots_14, shots_15, shots_16, shots_17, shots_18, shots_19, shots_20, shots_20R, " +
                                        "shots_21, shots_22, shots_23, shots_24, shots_25, shots_26, shots_27, shots_28, shots_29, shots_30, shots_30R," +
                                        " shots_31, shots_32, shots_33, shots_34, shots_35, shots_36, shots_37, shots_38, shots_39, shots_40, shots_40R," +
                                        " shots_41, shots_42, shots_43, shots_44, shots_45, shots_46, shots_47, shots_48, shots_49, shots_50, shots_50R," +
                                        " shots_51, shots_52, shots_53, shots_54, shots_55, shots_56, shots_57, shots_58, shots_59, shots_60, shots_60R) " +
                                        "VALUES (@athl_ID, @type, @date, @s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8,@s9,@s10,@s10R," +
                                        "@s11,@s12,@s13,@s14,@s15,@s16,@s17,@s18,@s19,@s20,@s20R" +
                                        ",@s21,@s22,@s23,@s24,@s25,@s26,@s27,@s28,@s29,@s30,@s30R" +
                                        ",@s31,@s32,@s33,@s34,@s35,@s36,@s37,@s38,@s39,@s40,@s40R" +
                                        ",@s41,@s42,@s43,@s44,@s45,@s46,@s47,@s48,@s49,@s50,@s50R" +
                                        ",@s51,@s52,@s53,@s54,@s55,@s56,@s57,@s58,@s59,@s60,@s60R)";
                                    MySqlCommand cmd = new MySqlCommand(query, conn);
                                    cmd.Parameters.Add("@athl_ID", DbType.Int32).Value = Int32.Parse(athlete_ID);
                                    cmd.Parameters.Add("@type", DbType.Int32).Value = type;
                                    cmd.Parameters.Add("@date", DbType.Date).Value = n.ToString("yyyy-MM-dd");
                                    cmd.Parameters.Add("@s1", DbType.Int32).Value = x1;
                                    cmd.Parameters.Add("@s2", DbType.Int32).Value = x2;
                                    cmd.Parameters.Add("@s3", DbType.Int32).Value = x3;
                                    cmd.Parameters.Add("@s4", DbType.Int32).Value = x4;
                                    cmd.Parameters.Add("@s5", DbType.Int32).Value = x5;
                                    cmd.Parameters.Add("@s6", DbType.Int32).Value = x6;
                                    cmd.Parameters.Add("@s7", DbType.Int32).Value = x7;
                                    cmd.Parameters.Add("@s8", DbType.Int32).Value = x8;
                                    cmd.Parameters.Add("@s9", DbType.Int32).Value = x9;
                                    cmd.Parameters.Add("@s10", DbType.Int32).Value = x10;
                                    cmd.Parameters.Add("@s11", DbType.Int32).Value = x11;
                                    cmd.Parameters.Add("@s12", DbType.Int32).Value = x12;
                                    cmd.Parameters.Add("@s13", DbType.Int32).Value = x13;
                                    cmd.Parameters.Add("@s14", DbType.Int32).Value = x14;
                                    cmd.Parameters.Add("@s15", DbType.Int32).Value = x15;
                                    cmd.Parameters.Add("@s16", DbType.Int32).Value = x16;
                                    cmd.Parameters.Add("@s17", DbType.Int32).Value = x17;
                                    cmd.Parameters.Add("@s18", DbType.Int32).Value = x18;
                                    cmd.Parameters.Add("@s19", DbType.Int32).Value = x19;
                                    cmd.Parameters.Add("@s20", DbType.Int32).Value = x20;
                                    cmd.Parameters.Add("@s21", DbType.Int32).Value = x21;
                                    cmd.Parameters.Add("@s22", DbType.Int32).Value = x22;
                                    cmd.Parameters.Add("@s23", DbType.Int32).Value = x23;
                                    cmd.Parameters.Add("@s24", DbType.Int32).Value = x24;
                                    cmd.Parameters.Add("@s25", DbType.Int32).Value = x25;
                                    cmd.Parameters.Add("@s26", DbType.Int32).Value = x26;
                                    cmd.Parameters.Add("@s27", DbType.Int32).Value = x27;
                                    cmd.Parameters.Add("@s28", DbType.Int32).Value = x28;
                                    cmd.Parameters.Add("@s29", DbType.Int32).Value = x29;
                                    cmd.Parameters.Add("@s30", DbType.Int32).Value = x30;
                                    cmd.Parameters.Add("@s31", DbType.Int32).Value = x31;
                                    cmd.Parameters.Add("@s32", DbType.Int32).Value = x32;
                                    cmd.Parameters.Add("@s33", DbType.Int32).Value = x33;
                                    cmd.Parameters.Add("@s34", DbType.Int32).Value = x34;
                                    cmd.Parameters.Add("@s35", DbType.Int32).Value = x35;
                                    cmd.Parameters.Add("@s36", DbType.Int32).Value = x36;
                                    cmd.Parameters.Add("@s37", DbType.Int32).Value = x37;
                                    cmd.Parameters.Add("@s38", DbType.Int32).Value = x38;
                                    cmd.Parameters.Add("@s39", DbType.Int32).Value = x39;
                                    cmd.Parameters.Add("@s40", DbType.Int32).Value = x40;
                                    cmd.Parameters.Add("@s41", DbType.Int32).Value = x41;
                                    cmd.Parameters.Add("@s42", DbType.Int32).Value = x42;
                                    cmd.Parameters.Add("@s43", DbType.Int32).Value = x43;
                                    cmd.Parameters.Add("@s44", DbType.Int32).Value = x44;
                                    cmd.Parameters.Add("@s45", DbType.Int32).Value = x45;
                                    cmd.Parameters.Add("@s46", DbType.Int32).Value = x46;
                                    cmd.Parameters.Add("@s47", DbType.Int32).Value = x47;
                                    cmd.Parameters.Add("@s48", DbType.Int32).Value = x48;
                                    cmd.Parameters.Add("@s49", DbType.Int32).Value = x49;
                                    cmd.Parameters.Add("@s50", DbType.Int32).Value = x50;
                                    cmd.Parameters.Add("@s51", DbType.Int32).Value = x51;
                                    cmd.Parameters.Add("@s52", DbType.Int32).Value = x52;
                                    cmd.Parameters.Add("@s53", DbType.Int32).Value = x53;
                                    cmd.Parameters.Add("@s54", DbType.Int32).Value = x54;
                                    cmd.Parameters.Add("@s55", DbType.Int32).Value = x55;
                                    cmd.Parameters.Add("@s56", DbType.Int32).Value = x56;
                                    cmd.Parameters.Add("@s57", DbType.Int32).Value = x57;
                                    cmd.Parameters.Add("@s58", DbType.Int32).Value = x58;
                                    cmd.Parameters.Add("@s59", DbType.Int32).Value = x59;
                                    cmd.Parameters.Add("@s60", DbType.Int32).Value = x60;
                                    cmd.Parameters.Add("@s10R", DbType.Int32).Value = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10;
                                    cmd.Parameters.Add("@s20R", DbType.Int32).Value = x11 + x12 + x13 + x14 + x15 + x16 + x17 + x18 + x19 + x20;
                                    cmd.Parameters.Add("@s30R", DbType.Int32).Value = x21 + x22 + x23 + x24 + x25 + x26 + x27 + x28 + x29 + x30;
                                    cmd.Parameters.Add("@s40R", DbType.Int32).Value = x31 + x32 + x33 + x34 + x35 + x36 + x37 + x38 + x39 + x40;
                                    cmd.Parameters.Add("@s50R", DbType.Int32).Value = x41 + x42 + x43 + x44 + x45 + x46 + x47 + x48 + x49 + x50;
                                    cmd.Parameters.Add("@s60R", DbType.Int32).Value = x51 + x52 + x53 + x54 + x55 + x56 + x57 + x58 + x59 + x60;
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    completed = true;
                                }
                                catch (FormatException exp1)
                                {
                                    valid = false;
                                    MessageBox.Show("Το σκορ από την κάθε βολή πρέπει να είναι ακέραιος αριθμός!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                catch (MySqlException db)
                                {
                                    Console.WriteLine(db);
                                    MessageBox.Show("Πρόβλημα σύνδεσης με την βάση δεδομένων", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (completed)
                                { 
                                    MessageBox.Show("Πραγματοποιήθηκε επιτυχώς η καταγραφή των αποτελεσμάτων", "Επιτυχής καταχώρηση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    base.Close();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                type = 3;
                if (BoxAmmoStr.SelectedIndex == 0)
                {
                    try
                    {
                        shells = Int32.Parse(AmmoOrg.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Οι καταναλωθέντες σφαίρες του σωματείου πρέπει να είναι ακέραιος αριθμός!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                }
                else if (BoxAmmoStr.SelectedIndex == 1)
                {
                    try
                    {
                        shells = Int32.Parse(AmmoAth.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Οι καταναλωθέντες σφαίρες του αθλητή πρέπει να είναι ακέραιος αριθμός!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                }
                else
                {
                    try
                    {
                        int shells_org = Int32.Parse(AmmoOrg.Text);
                        int shells_ath = Int32.Parse(AmmoAth.Text);
                        shells = shells_org + shells_ath;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Για την δήλωση μίξης σφαιρών, απαιτείται η συμπλήρωση και των 2 πεδίων!", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                    }
                }
            }
        }

        private void EnableEdit()
        {
            shoot1.Enabled = true;
            shoot2.Enabled = true;
            shoot3.Enabled = true;
            shoot4.Enabled = true;
            shoot5.Enabled = true;
            shoot6.Enabled = true;
            shoot7.Enabled = true;
            shoot8.Enabled = true;
            shoot9.Enabled = true;
            shoot10.Enabled = true;
            shoot11.Enabled = true;
            shoot12.Enabled = true;
            shoot13.Enabled = true;
            shoot14.Enabled = true;
            shoot15.Enabled = true;
            shoot16.Enabled = true;
            shoot17.Enabled = true;
            shoot18.Enabled = true;
            shoot19.Enabled = true;
            shoot20.Enabled = true;
            shoot21.Enabled = true;
            shoot22.Enabled = true;
            shoot23.Enabled = true;
            shoot24.Enabled = true;
            shoot25.Enabled = true;
            shoot26.Enabled = true;
            shoot27.Enabled = true;
            shoot28.Enabled = true;
            shoot29.Enabled = true;
            shoot30.Enabled = true;
            shoot31.Enabled = true;
            shoot32.Enabled = true;
            shoot33.Enabled = true;
            shoot34.Enabled = true;
            shoot35.Enabled = true;
            shoot36.Enabled = true;
            shoot37.Enabled = true;
            shoot38.Enabled = true;
            shoot39.Enabled = true;
            shoot40.Enabled = true;
            shoot41.Enabled = true;
            shoot42.Enabled = true;
            shoot43.Enabled = true;
            shoot44.Enabled = true;
            shoot45.Enabled = true;
            shoot46.Enabled = true;
            shoot47.Enabled = true;
            shoot48.Enabled = true;
            shoot49.Enabled = true;
            shoot50.Enabled = true;
            shoot51.Enabled = true;
            shoot52.Enabled = true;
            shoot53.Enabled = true;
            shoot54.Enabled = true;
            shoot55.Enabled = true;
            shoot56.Enabled = true;
            shoot57.Enabled = true;
            shoot58.Enabled = true;
            shoot59.Enabled = true;
            shoot60.Enabled = true;
            shoot10Res.Enabled = true;
            shoot20Res.Enabled = true;
            shoot30Res.Enabled = true;
            shoot40Res.Enabled = true;
            shoot50Res.Enabled = true;
            shoot60Res.Enabled = true;
        }

        private void DisableEdit()
        {
            shoot1.Enabled = false;
            shoot2.Enabled = false;
            shoot3.Enabled = false;
            shoot4.Enabled = false;
            shoot5.Enabled = false;
            shoot6.Enabled = false;
            shoot7.Enabled = false;
            shoot8.Enabled = false;
            shoot9.Enabled = false;
            shoot10.Enabled = false;
            shoot11.Enabled = false;
            shoot12.Enabled = false;
            shoot13.Enabled = false;
            shoot14.Enabled = false;
            shoot15.Enabled = false;
            shoot16.Enabled = false;
            shoot17.Enabled = false;
            shoot18.Enabled = false;
            shoot19.Enabled = false;
            shoot20.Enabled = false;
            shoot21.Enabled = false;
            shoot22.Enabled = false;
            shoot23.Enabled = false;
            shoot24.Enabled = false;
            shoot25.Enabled = false;
            shoot26.Enabled = false;
            shoot27.Enabled = false;
            shoot28.Enabled = false;
            shoot29.Enabled = false;
            shoot30.Enabled = false;
            shoot31.Enabled = false;
            shoot32.Enabled = false;
            shoot33.Enabled = false;
            shoot34.Enabled = false;
            shoot35.Enabled = false;
            shoot36.Enabled = false;
            shoot37.Enabled = false;
            shoot38.Enabled = false;
            shoot39.Enabled = false;
            shoot40.Enabled = false;
            shoot41.Enabled = false;
            shoot42.Enabled = false;
            shoot43.Enabled = false;
            shoot44.Enabled = false;
            shoot45.Enabled = false;
            shoot46.Enabled = false;
            shoot47.Enabled = false;
            shoot48.Enabled = false;
            shoot49.Enabled = false;
            shoot50.Enabled = false;
            shoot51.Enabled = false;
            shoot52.Enabled = false;
            shoot53.Enabled = false;
            shoot54.Enabled = false;
            shoot55.Enabled = false;
            shoot56.Enabled = false;
            shoot57.Enabled = false;
            shoot58.Enabled = false;
            shoot59.Enabled = false;
            shoot60.Enabled = false;
            shoot10Res.Enabled = false;
            shoot20Res.Enabled = false;
            shoot30Res.Enabled = false;
            shoot40Res.Enabled = false;
            shoot50Res.Enabled = false;
            shoot60Res.Enabled = false;
        }

        private void rngShots_Click(object sender, EventArgs e)
        {
            if (BoxActivityType.SelectedIndex == 0 || BoxActivityType.SelectedIndex == 2)
            {
                Random rnd = new Random();
                shoot1.Text = rnd.Next(1, 10).ToString();
                shoot2.Text = rnd.Next(1, 10).ToString();
                shoot3.Text = rnd.Next(1, 10).ToString();
                shoot4.Text = rnd.Next(1, 10).ToString();
                shoot5.Text = rnd.Next(1, 10).ToString();
                shoot6.Text = rnd.Next(1, 10).ToString();
                shoot7.Text = rnd.Next(1, 10).ToString();
                shoot8.Text = rnd.Next(1, 10).ToString();
                shoot9.Text = rnd.Next(1, 10).ToString();
                shoot10.Text = rnd.Next(1, 10).ToString();
                shoot11.Text = rnd.Next(1, 10).ToString();
                shoot12.Text = rnd.Next(1, 10).ToString();
                shoot13.Text = rnd.Next(1, 10).ToString();
                shoot14.Text = rnd.Next(1, 10).ToString();
                shoot15.Text = rnd.Next(1, 10).ToString();
                shoot16.Text = rnd.Next(1, 10).ToString();
                shoot17.Text = rnd.Next(1, 10).ToString();
                shoot18.Text = rnd.Next(1, 10).ToString();
                shoot19.Text = rnd.Next(1, 10).ToString();
                shoot20.Text = rnd.Next(1, 10).ToString();
                shoot21.Text = rnd.Next(1, 10).ToString();
                shoot22.Text = rnd.Next(1, 10).ToString();
                shoot23.Text = rnd.Next(1, 10).ToString();
                shoot24.Text = rnd.Next(1, 10).ToString();
                shoot25.Text = rnd.Next(1, 10).ToString();
                shoot26.Text = rnd.Next(1, 10).ToString();
                shoot27.Text = rnd.Next(1, 10).ToString();
                shoot28.Text = rnd.Next(1, 10).ToString();
                shoot29.Text = rnd.Next(1, 10).ToString();
                shoot30.Text = rnd.Next(1, 10).ToString();
                shoot31.Text = rnd.Next(1, 10).ToString();
                shoot32.Text = rnd.Next(1, 10).ToString();
                shoot33.Text = rnd.Next(1, 10).ToString();
                shoot34.Text = rnd.Next(1, 10).ToString();
                shoot35.Text = rnd.Next(1, 10).ToString();
                shoot36.Text = rnd.Next(1, 10).ToString();
                shoot37.Text = rnd.Next(1, 10).ToString();
                shoot38.Text = rnd.Next(1, 10).ToString();
                shoot39.Text = rnd.Next(1, 10).ToString();
                shoot40.Text = rnd.Next(1, 10).ToString();
                shoot41.Text = rnd.Next(1, 10).ToString();
                shoot42.Text = rnd.Next(1, 10).ToString();
                shoot43.Text = rnd.Next(1, 10).ToString();
                shoot44.Text = rnd.Next(1, 10).ToString();
                shoot45.Text = rnd.Next(1, 10).ToString();
                shoot46.Text = rnd.Next(1, 10).ToString();
                shoot47.Text = rnd.Next(1, 10).ToString();
                shoot48.Text = rnd.Next(1, 10).ToString();
                shoot49.Text = rnd.Next(1, 10).ToString();
                shoot50.Text = rnd.Next(1, 10).ToString();
                shoot51.Text = rnd.Next(1, 10).ToString();
                shoot52.Text = rnd.Next(1, 10).ToString();
                shoot53.Text = rnd.Next(1, 10).ToString();
                shoot54.Text = rnd.Next(1, 10).ToString();
                shoot55.Text = rnd.Next(1, 10).ToString();
                shoot56.Text = rnd.Next(1, 10).ToString();
                shoot57.Text = rnd.Next(1, 10).ToString();
                shoot58.Text = rnd.Next(1, 10).ToString();
                shoot59.Text = rnd.Next(1, 10).ToString();
                shoot60.Text = rnd.Next(1, 10).ToString();
                txt1_Leave(sender, e);
                txt2_Leave(sender, e);
                txt3_Leave(sender, e);
                txt4_Leave(sender, e);
                txt5_Leave(sender, e);
                txt6_Leave(sender, e);
                AmmoOrg.Text = "60";
            }
            else
            {
                MessageBox.Show("Δεν μπορούν να δημιουργηθούν τυχαία αποτελέσματα για την προπόνηση καθώς το σκορ δεν προσμετράται στις προπονήσεις. Παρακαλώ, επιλέξτε μια διαφορετική ενέργεια."
                    , "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                if (shoot1.Text != null && shoot1.Text != "")
                {
                    res = res + Int32.Parse(shoot1.Text);
                }
                if (shoot2.Text != null && shoot2.Text != "")
                {
                    res = res + Int32.Parse(shoot2.Text);
                }
                if (shoot3.Text != null && shoot3.Text != "")
                {
                    res = res + Int32.Parse(shoot3.Text);
                }
                if (shoot4.Text != null && shoot4.Text != "")
                {
                    res = res + Int32.Parse(shoot4.Text);
                }
                if (shoot5.Text != null && shoot5.Text != "")
                {
                    res = res + Int32.Parse(shoot5.Text);
                }
                if (shoot6.Text != null && shoot6.Text != "")
                {
                    res = res + Int32.Parse(shoot6.Text);
                }
                if (shoot7.Text != null && shoot7.Text != "")
                {
                    res = res + Int32.Parse(shoot7.Text);
                }
                if (shoot8.Text != null && shoot8.Text != "")
                {
                    res = res + Int32.Parse(shoot8.Text);
                }
                if (shoot9.Text != null && shoot9.Text != "")
                {
                    res = res + Int32.Parse(shoot9.Text);
                }
                if (shoot10.Text != null && shoot10.Text != "")
                {
                    res = res + Int32.Parse(shoot10.Text);
                }
                shoot10Res.Text = res.ToString();
            }
            catch (FormatException)
            {
                shoot10Res.Text = "Λάθος";
            }
        }
        private void txt2_Leave(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                if (shoot11.Text != null && shoot11.Text != "")
                {
                    res = res + Int32.Parse(shoot11.Text);
                }
                if (shoot12.Text != null && shoot12.Text != "")
                {
                    res = res + Int32.Parse(shoot12.Text);
                }
                if (shoot13.Text != null && shoot13.Text != "")
                {
                    res = res + Int32.Parse(shoot13.Text);
                }
                if (shoot14.Text != null && shoot14.Text != "")
                {
                    res = res + Int32.Parse(shoot14.Text);
                }
                if (shoot15.Text != null && shoot15.Text != "")
                {
                    res = res + Int32.Parse(shoot15.Text);
                }
                if (shoot16.Text != null && shoot16.Text != "")
                {
                    res = res + Int32.Parse(shoot16.Text);
                }
                if (shoot17.Text != null && shoot17.Text != "")
                {
                    res = res + Int32.Parse(shoot17.Text);
                }
                if (shoot18.Text != null && shoot18.Text != "")
                {
                    res = res + Int32.Parse(shoot18.Text);
                }
                if (shoot19.Text != null && shoot19.Text != "")
                {
                    res = res + Int32.Parse(shoot19.Text);
                }
                if (shoot20.Text != null && shoot20.Text != "")
                {
                    res = res + Int32.Parse(shoot20.Text);
                }
                shoot20Res.Text = res.ToString();
            }
            catch (FormatException)
            {
               shoot20Res.Text = "Λάθος";
            }
        }
        private void txt3_Leave(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                if (shoot21.Text != null && shoot21.Text != "")
                {
                    res = res + Int32.Parse(shoot21.Text);
                }
                if (shoot22.Text != null && shoot22.Text != "")
                {
                    res = res + Int32.Parse(shoot22.Text);
                }
                if (shoot23.Text != null && shoot23.Text != "")
                {
                    res = res + Int32.Parse(shoot23.Text);
                }
                if (shoot24.Text != null && shoot24.Text != "")
                {
                    res = res + Int32.Parse(shoot24.Text);
                }
                if (shoot25.Text != null && shoot25.Text != "")
                {
                    res = res + Int32.Parse(shoot25.Text);
                }
                if (shoot26.Text != null && shoot26.Text != "")
                {
                    res = res + Int32.Parse(shoot26.Text);
                }
                if (shoot27.Text != null && shoot27.Text != "")
                {
                    res = res + Int32.Parse(shoot27.Text);
                }
                if (shoot28.Text != null && shoot28.Text != "")
                {
                    res = res + Int32.Parse(shoot28.Text);
                }
                if (shoot29.Text != null && shoot29.Text != "")
                {
                    res = res + Int32.Parse(shoot29.Text);
                }
                if (shoot30.Text != null && shoot30.Text != "")
                {
                    res = res + Int32.Parse(shoot30.Text);
                }
                shoot30Res.Text = res.ToString();
            }
            catch (FormatException)
            {
                shoot30Res.Text = "Λάθος";
            }
        }
        private void txt4_Leave(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                if (shoot31.Text != null && shoot31.Text != "")
                {
                    res = res + Int32.Parse(shoot31.Text);
                }
                if (shoot32.Text != null && shoot32.Text != "")
                {
                    res = res + Int32.Parse(shoot32.Text);
                }
                if (shoot33.Text != null && shoot33.Text != "")
                {
                    res = res + Int32.Parse(shoot33.Text);
                }
                if (shoot34.Text != null && shoot34.Text != "")
                {
                    res = res + Int32.Parse(shoot34.Text);
                }
                if (shoot35.Text != null && shoot35.Text != "")
                {
                    res = res + Int32.Parse(shoot35.Text);
                }
                if (shoot36.Text != null && shoot36.Text != "")
                {
                    res = res + Int32.Parse(shoot36.Text);
                }
                if (shoot37.Text != null && shoot37.Text != "")
                {
                    res = res + Int32.Parse(shoot37.Text);
                }
                if (shoot38.Text != null && shoot38.Text != "")
                {
                    res = res + Int32.Parse(shoot38.Text);
                }
                if (shoot39.Text != null && shoot39.Text != "")
                {
                    res = res + Int32.Parse(shoot39.Text);
                }
                if (shoot40.Text != null && shoot40.Text != "")
                {
                    res = res + Int32.Parse(shoot40.Text);
                }
                shoot40Res.Text = res.ToString();
            }
            catch (FormatException)
            {
                shoot40Res.Text = "Λάθος";
            }
        }
        private void txt5_Leave(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                if (shoot41.Text != null && shoot41.Text != "")
                {
                    res = res + Int32.Parse(shoot41.Text);
                }
                if (shoot42.Text != null && shoot42.Text != "")
                {
                    res = res + Int32.Parse(shoot42.Text);
                }
                if (shoot43.Text != null && shoot43.Text != "")
                {
                    res = res + Int32.Parse(shoot43.Text);
                }
                if (shoot44.Text != null && shoot44.Text != "")
                {
                    res = res + Int32.Parse(shoot44.Text);
                }
                if (shoot45.Text != null && shoot45.Text != "")
                {
                    res = res + Int32.Parse(shoot45.Text);
                }
                if (shoot46.Text != null && shoot46.Text != "")
                {
                    res = res + Int32.Parse(shoot46.Text);
                }
                if (shoot47.Text != null && shoot47.Text != "")
                {
                    res = res + Int32.Parse(shoot47.Text);
                }
                if (shoot48.Text != null && shoot48.Text != "")
                {
                    res = res + Int32.Parse(shoot48.Text);
                }
                if (shoot49.Text != null && shoot49.Text != "")
                {
                    res = res + Int32.Parse(shoot49.Text);
                }
                if (shoot50.Text != null && shoot50.Text != "")
                {
                    res = res + Int32.Parse(shoot50.Text);
                }
                shoot50Res.Text = res.ToString();
            }
            catch (FormatException)
            {
                shoot50Res.Text = "Λάθος";
            }
        }

        private void txt6_Leave(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                if (shoot51.Text != null && shoot51.Text != "")
                {
                    res = res + Int32.Parse(shoot51.Text);
                }
                if (shoot52.Text != null && shoot52.Text != "")
                {
                    res = res + Int32.Parse(shoot52.Text);
                }
                if (shoot53.Text != null && shoot53.Text != "")
                {
                    res = res + Int32.Parse(shoot53.Text);
                }
                if (shoot54.Text != null && shoot54.Text != "")
                {
                    res = res + Int32.Parse(shoot54.Text);
                }
                if (shoot55.Text != null && shoot55.Text != "")
                {
                    res = res + Int32.Parse(shoot55.Text);
                }
                if (shoot56.Text != null && shoot56.Text != "")
                {
                    res = res + Int32.Parse(shoot56.Text);
                }
                if (shoot57.Text != null && shoot57.Text != "")
                {
                    res = res + Int32.Parse(shoot57.Text);
                }
                if (shoot58.Text != null && shoot58.Text != "")
                {
                    res = res + Int32.Parse(shoot58.Text);
                }
                if (shoot59.Text != null && shoot59.Text != "")
                {
                    res = res + Int32.Parse(shoot59.Text);
                }
                if (shoot60.Text != null && shoot60.Text != "")
                {
                    res = res + Int32.Parse(shoot60.Text);
                }
                shoot60Res.Text = res.ToString();
            }
            catch (FormatException)
            {
                shoot60Res.Text = "Λάθος";
            }
        }

        private void clearValues()
        {
            shoot1.Text = "";
            shoot2.Text = "";
            shoot3.Text = "";
            shoot4.Text = "";
            shoot5.Text = "";
            shoot6.Text = "";
            shoot7.Text = "";
            shoot8.Text = "";
            shoot9.Text = "";
            shoot10.Text = "";
            shoot11.Text = "";
            shoot12.Text = "";
            shoot13.Text = "";
            shoot14.Text = "";
            shoot15.Text = "";
            shoot16.Text = "";
            shoot17.Text = "";
            shoot18.Text = "";
            shoot19.Text = "";
            shoot20.Text = "";
            shoot21.Text = "";
            shoot22.Text = "";
            shoot23.Text = "";
            shoot24.Text = "";
            shoot25.Text = "";
            shoot26.Text = "";
            shoot27.Text = "";
            shoot28.Text = "";
            shoot29.Text = "";
            shoot30.Text = "";
            shoot31.Text = "";
            shoot32.Text = "";
            shoot33.Text = "";
            shoot34.Text = "";
            shoot35.Text = "";
            shoot36.Text = "";
            shoot37.Text = "";
            shoot38.Text = "";
            shoot39.Text = "";
            shoot40.Text = "";
            shoot41.Text = "";
            shoot42.Text = "";
            shoot43.Text = "";
            shoot44.Text = "";
            shoot45.Text = "";
            shoot46.Text = "";
            shoot47.Text = "";
            shoot48.Text = "";
            shoot49.Text = "";
            shoot50.Text = "";
            shoot51.Text = "";
            shoot52.Text = "";
            shoot53.Text = "";
            shoot54.Text = "";
            shoot55.Text = "";
            shoot56.Text = "";
            shoot57.Text = "";
            shoot58.Text = "";
            shoot59.Text = "";
            shoot60.Text = "";
            shoot10Res.Text = "";
            shoot20Res.Text = "";
            shoot30Res.Text = "";
            shoot40Res.Text = "";
            shoot50Res.Text = "";
            shoot60Res.Text = "";
            AmmoOrg.Text = "";
            AmmoAth.Text = "";
        }

        private bool valuesFilled()
        {
            if (BoxMhtrwo.Text !=null && BoxMhtrwo.Text != "" && BoxSullogos.Text != null && BoxSullogos.Text != "" && BoxTupos.Text != null && BoxTupos.Text != "" && BoxArOplou.Text != null && BoxArOplou.Text != ""
                && BoxArAdeia.Text != null && BoxArAdeia.Text != "" && BoxProvider.Text != null && BoxProvider.Text != "" && BoxTupos.Text != null && BoxTupos.Text != "" && BoxArOplou.Text != null && BoxArOplou.Text != "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
