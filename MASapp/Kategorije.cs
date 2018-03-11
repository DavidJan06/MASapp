using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MASapp
{
    class Kategorije
    {
        string Ime_kategorije;
        string Opis_kategorije; 

        public Kategorije()
        {
            Ime_kategorije = "";
            Opis_kategorije = "";
        }

        public Kategorije(string ime) : this()
        {
            Ime_kategorije = ime;

        }

        public Kategorije(string ime, string opis) : this(ime)
        {
            Opis_kategorije = opis;
        }

        public bool dodajKategorijo(string Ime, string Opis)

        {
            SQLiteConnection connection = new
           SQLiteConnection("data source=mas.sqlite");

            bool error;
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);

            //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();

            command.CommandText = "SELECT * FROM kategorije " +
                            "WHERE (ime LIKE '" + Ime + "')";

            //adapt.SelectCommand = command;
            //  adapt.Fill(ds, "delavci");
            //   DataRow nrow = ds.Tables["delavci"].NewRow();
            SQLiteDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }

            if (count == 0)
            {

                reader.Close();

                command.CommandText = "INSERT INTO kategorije ('ime', 'opis') " +
                    "VALUES ('" + Ime + "', '" + Opis + "')";

                command.ExecuteNonQuery();

                connection.Close();

                return error = false;

            }

            else
            {
                return error = true;



            }

        }
    }
}
