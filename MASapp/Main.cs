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

            string ZalogaStr = "Select ime, kolicina FROM Izdelki WHERE id_kategorija = 1";
            HelperFunctions.GetDataInDGV(ZalogaStr, dataGridView1);

            string KategorijeStr = "Select ime, opis FROM Kategorije";
            HelperFunctions.GetDataInDGV(KategorijeStr, dataGridView7);

            HelperFunctions.GetDataInCB(KategorijeStr, comboBox2, 0);
        }

        #region Pregled

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dodajanje_surovine dodaj = new dodajanje_surovine();
            dodaj.Show();
        }

        #endregion

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Meni = "SELECT ime FROM Izdelki WHERE id_kategorija = (SELECT id_kategorija FROM Kategorije WHERE ime = '"+ comboBox2.SelectedItem.ToString() +"')";
            HelperFunctions.GetDataInDGV(Meni, dataGridView9);
        }

        private void dataGridView7_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(dataGridView7.SelectedCells[0].Value.ToString());
            string Izdelki = "SELECT ime FROM Izdelki WHERE id_kategorija = (SELECT id_kategorija FROM Kategorije WHERE ime = '" + dataGridView7.SelectedCells[0].Value.ToString() + "')";
            HelperFunctions.GetDataInDGV(Izdelki, dataGridView8);
        }
    }
}
