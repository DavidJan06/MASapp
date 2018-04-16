using System;
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
    public partial class SurovineKategorije : Form
    {
        public SurovineKategorije()
        {
            InitializeComponent();
        }

        private void Surovine_Click(object sender, EventArgs e)
        {
            new dodaja_surovine().ShowDialog();
        }

        private void Kategorije_Click(object sender, EventArgs e)
        {
            new dodaj_kategorijo().ShowDialog();
        }
    }
}
