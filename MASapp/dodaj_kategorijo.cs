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
    public partial class dodaj_kategorijo : Form
    {
        public dodaj_kategorijo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            SQLiteConnection connection = new
            SQLiteConnection("data source=mas.db");


            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);
            SQLiteCommand command1 = new SQLiteCommand(connection);

            //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();

            string dodajSurovine = "INSERT INTO kategorije (ime, opis) VALUES ('" + ime_kategorije.Text + "', '" + opis_kategorije.Text + "')";

            command1.CommandText = dodajSurovine;

            //adapt.SelectCommand = command;
            //  adapt.Fill(ds, "delavci");
            //   DataRow nrow = ds.Tables["delavci"].NewRow();

            command.CommandText = "SELECT * FROM kategorije WHERE ime LIKE ('" + ime_kategorije.Text + "')";


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



            MessageBox.Show("Uspešno dodana kategorija!");
        }
    }
    }

