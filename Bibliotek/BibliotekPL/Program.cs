using System;
using BibliotekAL;
using System.Collections.Generic;
using BibliotekEntiteter;
using System.Linq;
using BibliotekDL;
using BibliotekDL.Contex;
using BibliotekDL.Seed;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace BibliotekPL
{
    public class Program
    {
        internal static ApplikationContext applikationContext;
        [STAThread]


        static void Main()
        {
            applikationContext = new ApplikationContext();
            applikationContext.Reset();
            applikationContext.Database.EnsureCreated();
            DataSeed.Populate(applikationContext);


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main = new LogginForm(new BL());
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }
    }
}
       