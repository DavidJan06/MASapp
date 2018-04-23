using System.Collections.Generic;
using System.Data.SQLite;
namespace MASapp

{
    class Izdelki
    {
        public string imeIzdelka { get; set; }

        List<Surovina> Surovine = new List<Surovina>();

        public Izdelki(string ime, List<Surovina> surovine)

        {
            imeIzdelka = ime;
            Surovine = surovine;
        }
    }
}
