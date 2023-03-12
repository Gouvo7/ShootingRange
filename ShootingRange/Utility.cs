using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ShootingRange
{
    internal class Utility
    {
        public int checker(string surname, string name, string fname, string mname,
            string adt, string amka, string bday, string address, string address_num,
            string tk, string region, string stathero, string kinhto,
            string email, string mhtrwo, string sullogos)
        {
            string reg_date = "\\d{2}-\\d{2}-\\d{4}|\\d{2}\\/\\d{2}\\/\\d{4}";
            if (Regex.Match(bday, reg_date).Success)
            {
                Console.WriteLine("MPRAVO");
            }
            else
            {
                Console.WriteLine("MPRAVO MALAKA");
            }
            Console.WriteLine("Ladia");
            return 0;
        }
    }
}
