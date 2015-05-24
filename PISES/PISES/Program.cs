using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PISES
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
            Presentacion P = new Presentacion();

            if (P.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Intro());
            }

            
        }
    }
}
