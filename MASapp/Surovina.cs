using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MASapp
{
    class Surovina
    {
        string Ime_Surovine { get; set; }
        float Kolicina { get; set; }

        public Surovina(string ime, float x)
        {
            Ime_Surovine = ime;
            Kolicina = x;
        }
    }
}
