using BibliotekAL;
using BibliotekEntiteter;
using BibliotekPL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PresentationL
{
    public partial class LoggaIn : Form
    {
        public static string ExpeditID = "";
        public static string ExpeditNamn = "";
        private Bibliotek bibliotek;
        public List<Expedit> Expediter { get; set; } = new List<Expedit>();
        public LoggaIn(Bibliotek bibliotek)
        {
            InitializeComponent();
            this.bibliotek = bibliotek;
        }

        private void btn_LoggaIn_Click(object sender, EventArgs e)
        {
            if (bibliotek.LoggaIn((txtBox_Användarnamn.Text), txtBox_Lösenord.Text))
            {
                ExpeditID = txtBox_Användarnamn.Text;
                new Meny(bibliotek).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Inloggningen lyckades ej!", "Ditt expeditID eller lösenord är felaktig!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
