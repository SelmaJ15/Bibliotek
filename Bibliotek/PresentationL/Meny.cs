using BibliotekAL;
using BibliotekPL.VäljMedlemForm;
using PresentationL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekPL
{
    public partial class Meny : Form
    {
        private Bibliotek bibliotek;
        public Meny(Bibliotek bibliotek)
        {
            InitializeComponent();
            this.bibliotek = bibliotek;

        }

        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            new LoggaIn(bibliotek).Show();
            this.Close();
        }

        private void btn_Reservera_Click(object sender, EventArgs e)
        {
            new Reservera_VäljMedlem(bibliotek).Show();
            this.Close();
        }

        private void btn_Uthämtning_Click(object sender, EventArgs e)
        {
            new Hämta_VäljMedlem(bibliotek).Show();
            this.Close();
        }

        private void btn_Återlämning_Click(object sender, EventArgs e)
        {
            new Återlämna_VäljMedlem(bibliotek).Show();
            this.Close();
        }
    }
}
