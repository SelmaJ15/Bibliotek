using BibliotekAL;
using BibliotekEntiteter;
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
    public partial class HämtaBok : Form
    {
        private Bibliotek bibliotek;
        private IList<Bokning> tillgänglig;
        private List<Bokning> EjUtlämnade;
        private string ID = "101";
        public HämtaBok(Bibliotek bibliotek, int medlemID)
        {
            InitializeComponent();
            this.bibliotek = bibliotek;
            label_mID.Text = medlemID.ToString();
            label_eID.Text = LoggaIn.ExpeditID;
            ID = medlemID.ToString();
            EjUtlämnade = new List<Bokning>();

            tillgänglig = bibliotek.HämtaBokningar(medlemID);

            foreach (Bokning c in tillgänglig)
            {
                if (c.faktiskaUtlämningstid == DateTime.MinValue)
                {
                    listBox_Bokningar.Items.Add(c.bokningId);
                    EjUtlämnade.Add(c);
                }
            }
        }

        private void btn_Välj_Click(object sender, EventArgs e)
        {
            if (listBox_Bokningar.SelectedItem != null)
            {
                Bokning bokningTest = bibliotek.HämtaBokningen(EjUtlämnade[listBox_Bokningar.SelectedIndex]);
                MessageBox.Show("BokningsNr: " + bokningTest.bokningId + "\nHämtades ut vid: " + bokningTest.tilltänktaÅterlämningstid.ToString("yyyy/MM/dd"), "Bokning uthämtad!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Meny(bibliotek).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Du måste välja en bokning först.", "Gick ej!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            new Hämta_VäljMedlem(bibliotek).Show();
            this.Close();
        }
    }
}
