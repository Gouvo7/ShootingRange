using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ShootingRange
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.Run(new LoginForm()); 
            Application.Run(new ShootingApp());
        }

        public static void Agonas()
        {
            Application.Run(new Shooting());
        }
    }
}
