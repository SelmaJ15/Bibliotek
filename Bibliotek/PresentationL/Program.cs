using BibliotekAL;
using BibliotekDL;
using PresentationL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BibliotekPL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        internal static BibliotekContext bibliotekContext;

        [STAThread]
        static void Main()
        {
            
                bibliotekContext = new BibliotekContext();
                bibliotekContext.resetSeed();

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                
                Bibliotek bibliotek = new Bibliotek();
                Application.Run(new LoggaIn(bibliotek));
            
        }
        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }

    }
}
