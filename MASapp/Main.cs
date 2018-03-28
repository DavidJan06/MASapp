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
            Refresh();
        }

        void Refresh() {

            string ZalogaStr = "Select ime, kolicina FROM surovine";
            HelperFunctions.GetDataInDGV(ZalogaStr, zalogaDGVp);

            string KategorijeStr = "Select ime, opis FROM Kategorije";
            HelperFunctions.GetDataInDGV(KategorijeStr, kategorijeDGVi);

            HelperFunctions.GetDataInCB(KategorijeStr, kategorijeCBv, 0);
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
            string Meni = "SELECT ime FROM Izdelki WHERE id_kategorija = (SELECT id_kategorija FROM Kategorije WHERE ime = '" + kategorijeCBv.SelectedItem.ToString() + "')";
            HelperFunctions.GetDataInDGV(Meni, izdelkiDGVv);
        }

        #endregion

        #region Izdelki

        private void kategorijeDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string Izdelki = "SELECT ime FROM Izdelki WHERE id_kategorija = (SELECT id_kategorija FROM Kategorije WHERE ime = '" + kategorijeDGVi.SelectedCells[0].Value.ToString() + "')";
            HelperFunctions.GetDataInDGV(Izdelki, izdelkiDGVi);
        }

        #endregion
    }
}
