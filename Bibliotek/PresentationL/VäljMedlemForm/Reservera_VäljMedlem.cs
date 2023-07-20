using BibliotekAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekPL.VäljMedlemForm
{
    public partial class Reservera_VäljMedlem : Form
    {
        private Bibliotek bibliotek;
        public Reservera_VäljMedlem(Bibliotek bibliotek)
        {
            InitializeComponent();
            this.bibliotek = bibliotek;
        }
        public string MedlemsNummer { get; private set; }

        private void Reservera_VäljMedlem_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=sqlutb2.hb.se,56077;Database=osu2314;User Id=osu2314;Password=xy5854;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Medlemar", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1_Medlemar.DataSource = dt;
        }

        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            new Meny(bibliotek).Show();
            this.Hide();
        }
        private void btn_test_Click(object sender, EventArgs e)
        {
            if (dataGridView1_Medlemar.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1_Medlemar.SelectedRows)
                {
                    MedlemsNummer = row.Cells[2].Value.ToString();
                }
                new ReserveraBok(bibliotek, Int32.Parse(MedlemsNummer), textBox_Återlämningstid.Text).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Du måste välja en medlem först.", "Gick ej!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}