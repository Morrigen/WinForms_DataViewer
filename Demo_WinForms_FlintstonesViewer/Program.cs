using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_DataViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Let the mystery begin
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListForm());
        }
    }
}
//STUCK - can't get image to show