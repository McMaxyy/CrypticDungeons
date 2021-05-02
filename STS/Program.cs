using System;
using System.Windows.Forms;

namespace STS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Creating a new set of player data, stored in Podatki
            Podatki p = new Podatki();           
            Application.Run(new Start(ref p));
        }
    }
}
