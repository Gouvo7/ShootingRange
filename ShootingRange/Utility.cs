using System;
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
        Regex reg_bday = new Regex(@"\d{2}(\/|-)\d{2}(\/|-)\d{4}");
        Regex tk_regex = new Regex(@"\d{3}\s?\d{2}|\d{2}\s?\d{3}");
        public int checker(string surname, string name, string fname, string mname,
            string adt, string amka, string bday, string address, string address_num,
            string tk, string region, string stathero, string kinhto,
            string email, string mhtrwo, string sullogos)
        {
            bool values_ok = true;
            if (!reg_bday.IsMatch(bday))
            {
                //Console.WriteLine("Η ημερομηνία γέννησης δεν είναι σωστή!");
                MessageBox.Show("Λάθος μορφοποίηση ημερομηνίας γέννησης. Η ημερομηνία θα πρέπει να είναι της μορφής: " +
                    "01/01/2000 ή 01-01-2000", "Μήνυμα Λάθους", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
