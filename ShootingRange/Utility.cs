﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingRange
{
    internal class Utility : Form
    {
        Regex reg_bday = new Regex(@"(^0[1-9]|[12][0-9]|3[01])\/(0[1-9]|1[0-2])\/(\d{4}$)");
        Regex tk_regex = new Regex(@"\d{3}\s?\d{2}|\d{2}\s?\d{3}");
        public int checker(string surname, string name, string fname, string mname,
            string adt, string amka, string bday, string address, string address_num,
            string tk, string region, string stathero, string kinhto,
            string email, string mhtrwo, string sullogos)
        {
            bool values_ok = true;
            if (surname.Equals("") || surname == null || name.Equals("") || name == null)
            {
                MessageBox.Show("Το ονοματεπώνυμο δεν μπορεί να είναι κενό!", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if (adt.Equals("") || adt == null)
            {
                MessageBox.Show("Το πεδίου του Αριθμού Δελτίου Ταυτότητας (ΑΔΤ) δεν μπορεί να είναι κενό!", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if (amka.Equals("") || amka == null)
            {
                MessageBox.Show("Το πεδίο του ΑΜΚΑ δεν μπορεί να είναι κενό!", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if (!reg_bday.IsMatch(bday))
            {
                //Console.WriteLine("Η ημερομηνία γέννησης δεν είναι σωστή!");
                MessageBox.Show("Λάθος μορφοποίηση ημερομηνίας γέννησης. Η ημερομηνία θα πρέπει να είναι της μορφής: " +
                    "01/01/2000 ή 01-01-2000 (ηη/μμ/εεεε).", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if (!tk_regex.IsMatch(tk))
            {
                //Console.WriteLine("Ο αριθμός της διεύθυνσης δεν δεν είναι σωστή!");
                MessageBox.Show("Λάθος μορφοποίηση του ΤΚ. Επιτρέπονται μόνο αριθμοί.", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if (values_ok)
                return 0;
            else
                return -1;
        }

        public int checker(string surname, string name, string fname, string mname,
            string adt, string amka, string bday, string address, string address_num,
            string tk, string region, string stathero, string kinhto,
            string email, string mhtrwo, string sullogos, string ar_oplou, string ar_adeia)
        {
            bool values_ok = true;
            if (surname.Equals("") || surname == null || name.Equals("") || name == null)
            {
                MessageBox.Show("Το ονοματεπώνυμο δεν μπορεί να είναι κενό!", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if (adt.Equals("") || adt == null)
            {
                MessageBox.Show("Το πεδίου του Αριθμού Δελτίου Ταυτότητας (ΑΔΤ) δεν μπορεί να είναι κενό!", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if(amka.Equals("") || amka == null)
            {
                MessageBox.Show("Το πεδίο του ΑΜΚΑ δεν μπορεί να είναι κενό!", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if(!reg_bday.IsMatch(bday))
            {
                //Console.WriteLine("Η ημερομηνία γέννησης δεν είναι σωστή!");
                MessageBox.Show("Λάθος μορφοποίηση ημερομηνίας γέννησης. Η ημερομηνία θα πρέπει να είναι της μορφής: " +
                    "01/01/2000 ή 01-01-2000", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if(!tk_regex.IsMatch(tk))
            {
                //Console.WriteLine("Ο αριθμός της διεύθυνσης δεν δεν είναι σωστή!");
                MessageBox.Show("Λάθος μορφοποίηση του ΤΚ. Επιτρέπονται μόνο αριθμοί.", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }
            if(ar_oplou.Equals("") || ar_oplou == null || ar_adeia.Equals("") || ar_adeia == null)
            {
                MessageBox.Show("Τα στοιχεία του όπλου δεν μπορούν να είναι κενά! Εάν δεν επιθυμείτε να καταχωρήσετε στοιχεία " +
                    "για όπλο, αφαιρέστε την επιλογή \"Καταχώρηση όπλου\".", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
                values_ok = false;
            }

            if (values_ok)
                return 0;
            else
                return -1;
        }
    }
}
