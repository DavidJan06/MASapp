using System.Data.SQLite;
namespace MASapp
    
{
    class Izdelki : Surovine
    {
        public string imeIzdelka { get; set; }
        

        public Izdelki()

        {
            imeIzdelka = "Neznan izdelek";
            

        }

        public Izdelki(string ime_izdelka, string Ime_surovine, int Kolicina) : base (Ime_surovine, Kolicina)

        {
            imeIzdelka = ime_izdelka;
            
        }

        public void DodajIzdelek(string ime_izdelka, string ime_surovine, int kolicina_surovine) 

        {
            SQLiteConnection connection = new
           SQLiteConnection("data source=mas.sqlite");

           
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);

            //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();

            //adapt.SelectCommand = command;
            //  adapt.Fill(ds, "delavci");
            //   DataRow nrow = ds.Tables["delavci"].NewRow();
            SQLiteDataReader reader = command.ExecuteReader();

                command.CommandText = "INSERT INTO izdelki_surovine ('surovina_id, izdelek_id', 'kolicina') " +
                    "VALUES ('SELECT id FROM surovine WHERE ime LIKE " + ime_surovine + "', 'SELECT id FROM surovine WHERE ime LIKE " + ime_izdelka + "', '" + kolicina_surovine + "')";
            
                connection.Close();

        }



    }
}
