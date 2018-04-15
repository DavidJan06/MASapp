using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MASapp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh() {

            string ZalogaStr = "Select ime, kolicina FROM surovine";
            HelperFunctions.GetDataInDGV(ZalogaStr, zalogaDGVp);

            string SurovineStr = "Select ime FROM surovine";
            HelperFunctions.GetDataInDGV(SurovineStr, surovineDGVv);

            string KategorijeStr = "Select ime FROM kategorije";
            HelperFunctions.GetDataInDGV(KategorijeStr, kategorijeDGVi);

            HelperFunctions.GetDataInCB(KategorijeStr, kategorijeCBv, 0);
            kategorijeCBv.SelectedIndex = 0;

            zalogaCBp.Items.Insert(0, "All");
            HelperFunctions.GetDataInCB(KategorijeStr, zalogaCBp, 0);
            zalogaCBp.SelectedIndex = 0;
            
        }

        #region Pregled

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DodajSurovine dodaj = new DodajSurovine();
            dodaj.Show();
        }

        #endregion

        #region Vnos

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Meni = "SELECT ime FROM izdelki WHERE kategorija_id = (SELECT id FROM kategorije WHERE ime = '" + kategorijeCBv.SelectedItem.ToString() + "')";
            HelperFunctions.GetDataInDGV(Meni, izdelkiDGVv);
        }

        private void izdelkiDGVv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Izdelki = "SELECT s.ime AS 'Surovina', k.kolicina AS 'Količina' FROM izdelki_surovine k INNER JOIN surovine s ON s.id = k.surovina_id WHERE izdelek_id = (SELECT id FROM izdelki WHERE ime LIKE '" + izdelkiDGVv.SelectedCells[0].Value.ToString() + "')";
            HelperFunctions.GetDataInDGV(Izdelki, sestavineIzdelkaDGVv);
        }

        private void dodajSurovineBv_Click(object sender, EventArgs e)
        {
            if (kolicinaBv.Text != "")
            {
                if (float.TryParse(kolicinaBv.Text, out float n))
                {
                    /*var index = sestavineIzdelkaDGVv.Rows.Add();
                    sestavineIzdelkaDGVv.Rows[index].Cells[0].Value = surovineDGVv.SelectedCells[0].Value.ToString();
                    sestavineIzdelkaDGVv.Rows[index].Cells[1].Value = n.ToString();

                    /*DataGridViewRow row = (DataGridViewRow)sestavineIzdelkaDGVv.Rows[0].Clone();
                    row.Cells[0].Value = surovineDGVv.SelectedCells[0].Value.ToString();
                    row.Cells[1].Value = n.ToString();
                    sestavineIzdelkaDGVv.Rows.Add(row);*/
                }
                else
                {
                    MessageBox.Show("Vnesite število!");
                }
            }
            else
            {
                MessageBox.Show("Vnesite količino!");
            }
        }

        #endregion

        #region Izdelki

        private void kategorijeDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new UrediZbrisi().ShowDialog();
        }

        private void kategorijeDGVi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Izdelki = "SELECT ime FROM izdelki WHERE kategorija_id = (SELECT id FROM kategorije WHERE ime = '" + kategorijeDGVi.SelectedCells[0].Value.ToString() + "')";
            HelperFunctions.GetDataInDGV(Izdelki, izdelkiDGVi);
        }

        private void izdelkiDGVi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new UrediZbrisi().ShowDialog();
        }

        #endregion

        private void button1_Click_2(object sender, EventArgs e)
        {
            dodaja_surovine novo = new dodaja_surovine();
            novo.Show();
        }
    }
}
