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
        SQLiteConnection conn = new SQLiteConnection("data source=mas.sqlite");

        public Main()
        {
            InitializeComponent();
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

        private void Main_Load(object sender, EventArgs e)
        {
            string str = "Select ime, kolicina FROM surovine";

            using (conn){ 
                using (SQLiteCommand comm = new SQLiteCommand(str, conn)){
                    comm.CommandType = CommandType.Text;
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter(comm)){
                        using (DataTable dt = new DataTable()){
                            try
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                            catch
                            {
                                MessageBox.Show("DataGridView error!");
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}
