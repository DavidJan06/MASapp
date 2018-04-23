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
        List<Surovina> Surovine = new List<Surovina>();

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

            string KategorijeIStr = "Select ime FROM kategorije_i";
            HelperFunctions.GetDataInDGV(KategorijeIStr, kategorijeDGVi);

            HelperFunctions.GetDataInCB(KategorijeIStr, kategorijeCBv, 0);
            kategorijeCBv.SelectedIndex = 0;

            string KategorijeSStr = "Select ime FROM kategorije_s";
            zalogaCBp.Items.Insert(0, "All");
            HelperFunctions.GetDataInCB(KategorijeSStr, zalogaCBp, 0);
            zalogaCBp.SelectedIndex = 0;

            HelperFunctions.GetDataInCB(KategorijeSStr, surovineCBv, 0);
            surovineCBv.SelectedIndex = 0;
        }

        public void CLS()
        {
            zalogaDGVp.DataSource = null;
            surovineDGVv.DataSource = null;
            kategorijeDGVi.DataSource = null;
            kategorijeCBv.Items.Clear();
            zalogaCBp.Items.Clear();
            surovineCBv.Items.Clear();
        }

        #region Pregled

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new DodajSurovine().ShowDialog();
        }

        private void dodajBTp_Click(object sender, EventArgs e)
        {
            new SurovineKategorije().ShowDialog();

            CLS();
            refresh();
        }

        private void zalogaCBp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(zalogaCBp.SelectedIndex == 0)
            {
                string ZalogaStr = "Select ime, kolicina FROM surovine";
                HelperFunctions.GetDataInDGV(ZalogaStr, zalogaDGVp);
            }
            else
            {
                string ZalogaStr = "Select ime, kolicina FROM surovine WHERE kategorija_id LIKE(SELECT id FROM kategorije_s WHERE ime LIKE '"+ zalogaCBp.SelectedItem.ToString() + "')";
                HelperFunctions.GetDataInDGV(ZalogaStr, zalogaDGVp);
            }
        }

        #endregion

        #region Vnos

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Meni = "SELECT ime FROM izdelki WHERE kategorija_id = (SELECT id FROM kategorije_i WHERE ime = '" + kategorijeCBv.SelectedItem.ToString() + "')";
            HelperFunctions.GetDataInDGV(Meni, izdelkiDGVv);
        }

        private void surovineCBv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ZalogaStr = "Select ime, kolicina FROM surovine WHERE kategorija_id LIKE(SELECT id FROM kategorije_s WHERE ime LIKE '" + surovineCBv.SelectedItem.ToString() + "')";
            HelperFunctions.GetDataInDGV(ZalogaStr, surovineDGVv);
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
                float n;
                if (float.TryParse(kolicinaBv.Text, out n))
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
            string Izdelki = "SELECT ime FROM izdelki WHERE kategorija_id = (SELECT id FROM kategorije_i WHERE ime = '" + kategorijeDGVi.SelectedCells[0].Value.ToString() + "')";
            HelperFunctions.GetDataInDGV(Izdelki, izdelkiDGVi);
        }

        private void izdelkiDGVi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new UrediZbrisi().ShowDialog();
        }

        private void dodajKategorijeBi_Click(object sender, EventArgs e)
        {
            new dodaj_kategorijo(1).ShowDialog();

            CLS();
            refresh();
        }


        #endregion


    }
}
