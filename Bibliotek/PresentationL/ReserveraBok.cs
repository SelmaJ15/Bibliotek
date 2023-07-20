using BibliotekAL;
using BibliotekEntiteter;
using BibliotekPL.VäljMedlemForm;
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
    public partial class ReserveraBok : Form
    {
        private Bibliotek bibliotek;
        private IList<Bok> tillgänglig;
        private int ID = 1;
        private DateTime angettNummer;
        public ReserveraBok(Bibliotek bibliotek, int medlemID, string återTid)
        {
            InitializeComponent();
            this.bibliotek = bibliotek;
            string testDatum = återTid;
            ID = medlemID;
            angettNummer = DateTime.Parse(testDatum);
            tillgänglig = (IList<Bok>)bibliotek.HämtaTillgängligaBöcker();
            foreach (Bok c in tillgänglig) List_TillgängligaBöcker.Items.Add(c.titel);

        }
        private void reserve_Click(object sender, EventArgs e)
        {
            if (List_TillgängligaBöcker.SelectedItems != null)
            {
                Bokning bokning = bibliotek.ReserveraBok(ID, angettNummer);

                for (int x = 0; x < List_TillgängligaBöcker.SelectedItems.Count; x++)
                {
                    bokning = bibliotek.LäggTillBok(tillgänglig[List_TillgängligaBöcker.SelectedIndices[x]], bokning);
                }
                MessageBox.Show("BokningsNr: " + bokning.bokningId + "\nFörväntad återlämningstid är: " + bokning.tilltänktaÅterlämningstid.ToString("yyyy/MM/dd") + "\nEfter 14 dygn tillkommer en förseningsavgift på 10kr/dygn", "Bokning skapad!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new Meny(bibliotek).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gick ej!", "Du måste välja en bok först.",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Reservera_Click(object sender, EventArgs e)
        {
            new Meny(bibliotek).Show();
            this.Close();
        }

        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            new Reservera_VäljMedlem(bibliotek).Show();
            this.Close();
        }
    }
}
