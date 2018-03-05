using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MASapp
{
        public class Surovine
    {
        public string Ime_surovine { get; set; }
        public int Kolicina { get; set; }



        public Surovine()
        {
            Ime_surovine = "";
            Kolicina = 0;
        }

        public Surovine(string ime) : this()
        {
            Ime_surovine = ime;
            
        }

        public Surovine(string ime, int kolicina) : this(ime)
        {
            Kolicina = kolicina;
        }

        public void dodajSurovino(string Ime, int Kolicina)

        {
            SQLiteConnection connection = new
           SQLiteConnection("data source=mas.sqlite");

            int error = 0;
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);

            //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();

            command.CommandText = "SELECT * FROM surovine " +
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

                command.CommandText = "INSERT INTO surovine ('ime', 'kolicina') " +
                    "VALUES ('" + Ime + "', '" + Kolicina + "')";

                command.ExecuteNonQuery();

                connection.Close();
                
            }

            else
            {
                reader.Close();

                command.CommandText = "UPDATE surovine SET kolicina = kolicina + '" + Kolicina + "' WHERE ime LIKE '" + Ime + "'";

                command.ExecuteNonQuery();

                connection.Close();
                
               

            }

        }

        //public void dodajKolicino(int Kolicina, string Ime)

        //{
        //    SQLiteConnection connection = new
        //  SQLiteConnection("data source=mas.sqlite");

        //    SQLiteCommand command = new SQLiteCommand(connection);
        //    connection.Open();

        //    //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
        //    //DataSet ds = new DataSet();

        //    command.CommandText = "INSERT INTO surovine ('kolicina', 'ime') " +
        //            "VALUES ('" + Kolicina + "', '" + Ime + "')";

        //    command.ExecuteNonQuery();

        //    //adapt.SelectCommand = command;
        //    //  adapt.Fill(ds, "delavci");
        //    //   DataRow nrow = ds.Tables["delavci"].NewRow();

        //    connection.Close();

        //}





    }

    

}
