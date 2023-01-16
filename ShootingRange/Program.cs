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
            //Application.Run(new Shooting());

            Application.Run(new LoginForm()); 
            Application.Exit();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //while (true)
            //{
            //Thread s = new Thread(new ShootingApp());
            Application.Run(new ShootingApp());
            
            //}
            
        }

        public static void Agonas()
        {
            Application.Run(new Shooting());
        }
    }
}
