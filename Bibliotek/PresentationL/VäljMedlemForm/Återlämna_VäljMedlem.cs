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
using System.Data.SqlClient;

namespace BibliotekPL.VäljMedlemForm
{
    public partial class Återlämna_VäljMedlem : Form
    {
        private Bibliotek bibliotek;
        public Återlämna_VäljMedlem(Bibliotek bibliotek)
        {
            InitializeComponent();
            this.bibliotek = bibliotek;
        }
        public string MedlemsNummer { get; private set; }

        private void Återlämna_VäljMedlem_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=sqlutb2.hb.se,56077;Database=osu2314;User Id=osu2314;Password=xy5854;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Medlemar", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Tillbaka_Click(object sender, EventArgs e)
        {
            new Meny(bibliotek).Show();
            this.Hide();
        }
        private void btn_VäljMedlem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    MedlemsNummer = row.Cells[2].Value.ToString();
                }
                new ÅterlämnaBok(bibliotek, Int32.Parse(MedlemsNummer)).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gick ej!", "Du måste välja en medlem först.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
