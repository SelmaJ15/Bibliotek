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
    public partial class ÅterlämnaBok : Form
    {
        private Bibliotek bibliotek;
        private IList<Bokning> tillgänglig;
        private List<Bokning> EjUthämtade;
        private List<Bokning> Uthämtade;
        private Faktura faktura;

        private string ID = "101";
        public ÅterlämnaBok(Bibliotek bibliotek, int medlemsNr)
        {
            InitializeComponent();
            this.bibliotek = bibliotek;
            label_mID.Text = medlemsNr.ToString();
            label_eID.Text = LoggaIn.ExpeditID;
            ID = medlemsNr.ToString();
            Uthämtade = new List<Bokning>();
            EjUthämtade = new List<Bokning>();
            tillgänglig = bibliotek.HämtaBokningar(medlemsNr);
            listBox_Bokningar.Items.Clear();
            foreach (Bokning b in tillgänglig)
            {
                if (b.faktiskaUtlämningstid != DateTime.MinValue && b.tilltänktaÅterlämningstid == DateTime.MinValue)
                {
                    listBox_Bokningar.Items.Add(b.bokningId);
                    EjUthämtade.Add(b);
                }
                else if (b.faktiskaUtlämningstid != DateTime.MinValue && b.tilltänktaÅterlämningstid != DateTime.MinValue)
                {
                    listBox_Återlämnade.Items.Add(b.bokningId);
                    Uthämtade.Add(b);
                }

            }
        }

        private void btn_välj_Click(object sender, EventArgs e)
        {
            if (listBox_Bokningar.SelectedItem != null)
            {
                Bokning valdBokning = EjUthämtade[listBox_Bokningar.SelectedIndex];
                valdBokning.tilltänktaÅterlämningstid = DateTime.Now; 
                foreach (Bok bok in valdBokning.TillhörandeBöcker)
                {
                    bok.ärTillgänglig = true;
                }
                faktura = bibliotek.Återlämning(valdBokning.bokningId);
                MessageBox.Show("BokningsNr: " + valdBokning.bokningId + "\nLämnades in vid: " + tillgänglig[listBox_Bokningar.SelectedIndex].tilltänktaÅterlämningstid.ToString("yyyy/MM/dd") + "\nDet blir faktura på: " + faktura.totalpris + " Kr", "Bokning uthämtad", MessageBoxButtons.OK, MessageBoxIcon.Information);


                listBox_Bokningar.ClearSelected();
                new Meny(bibliotek).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Du valde ingen bokning.", "Inget hände!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBox_Bokningar.ClearSelected();
                new Meny(bibliotek).Show();
                this.Close();
            }
        }

        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            new Återlämna_VäljMedlem(bibliotek).Show();
            this.Close();
        }
    }
}
