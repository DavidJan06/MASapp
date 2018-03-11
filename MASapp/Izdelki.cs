using System.Data.SQLite;
namespace MASapp

{
    class Izdelki : Kategorije
    {
        public string imeIzdelka { get; set; }


        public Izdelki()

        {
            imeIzdelka = "Neznan izdelek";


        }

        public Izdelki(string ime_izdelka, string Ime_kategorije) : base(Ime_kategorije)

        {
            imeIzdelka = ime_izdelka;

        }

        public bool DodajIzdelek()

        {

            bool error;
            SQLiteConnection connection = new
           SQLiteConnection("data source=mas.sqlite");


            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);




            //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();

            command.CommandText = "SELECT * FROM izdelki " +
                            "WHERE (ime LIKE '" + imeIzdelka + "')";

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

                /*command.CommandText = "INSERT INTO izdelki ('ime, kategorija_id) " +
                    "VALUES ('" + imeIzdelka + "', 'SELECT id FROM kategorije WHERE ime LIKE " + Ime_kategorije + "'')";*/

                connection.Close();

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
