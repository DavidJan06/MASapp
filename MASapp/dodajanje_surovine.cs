﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASapp
{
    
    public partial class dodajanje_surovine : Form
    {
        Surovine sur = new Surovine();

        public dodajanje_surovine()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kolicina = Int32.Parse(kolicina_surovine.Text); 

            string ime = ime_surovine.Text;

            sur.dodajSurovino(ime, kolicina);
            
        }
    }
}
