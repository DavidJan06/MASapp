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

            string KategorijeStr = "Select ime FROM kategorije_s";
            

            HelperFunctions.GetDataInCB(KategorijeStr, ime_kategorije, 0);
            ime_kategorije.SelectedIndex = 0;
        }

        private void dodaj_surovino_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new
            SQLiteConnection("data source=mas.db");


            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);
            SQLiteCommand command1 = new SQLiteCommand(connection);

            //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();

            string dodajSurovine = "INSERT INTO surovine (ime, kategorija_id) VALUES ('" + ime_surovine.Text + "', (SELECT id FROM kategorije_s WHERE ime LIKE '"+ime_kategorije.SelectedItem.ToString()+"') )";

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

            this.Close();
        }
    }
}
