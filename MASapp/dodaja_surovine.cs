using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MASapp
{
    public partial class dodaja_surovine : Form
    {

        public dodaja_surovine()
        {
            InitializeComponent();

            string KategorijeStr = "Select ime FROM kategorije";
            

            HelperFunctions.GetDataInCB(KategorijeStr, ime_kategorije, 0);
            ime_kategorije.SelectedIndex = 0;
        }

        private void dodaj_surovino_Click(object sender, EventArgs e)
        {
            int selectedIndex = ime_kategorije.SelectedIndex;
            Object selectedValue = ime_kategorije.SelectedItem;


            SQLiteConnection connection = new
            SQLiteConnection("data source=mas.db");


            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);
            SQLiteCommand command1 = new SQLiteCommand(connection);

            //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();

            string dodajSurovine = "INSERT INTO surovine (ime) VALUES ('" + ime_surovine.Text + "') WHERE kategorija_id = (SELECT id FROM kategorije WHERE ime LIKE '" + selectedValue.ToString() + "')";

            command1.CommandText = dodajSurovine;

            //adapt.SelectCommand = command;
            //  adapt.Fill(ds, "delavci");
            //   DataRow nrow = ds.Tables["delavci"].NewRow();

            command.CommandText = "SELECT * FROM surovine WHERE ime LIKE ('" + ime_surovine.Text + "')";


            SQLiteDataReader reader = command.ExecuteReader();
            
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }

            if (count == 0)
            {

                reader.Close();

                command1.CommandText = dodajSurovine;

                command1.ExecuteNonQuery();

                connection.Close();

            }

            else
            {

                connection.Close();

            }



            MessageBox.Show("Uspešno dodana surovina!");
        }

        private void dodaja_surovine_Load(object sender, EventArgs e)
        {

        }
    }
}
