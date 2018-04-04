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
    
    public partial class DodajSurovine : Form
    {

        public DodajSurovine()
        {
            InitializeComponent();
            refresh();
        }

        void refresh()
        {
            string getSurovine = "Select ime FROM surovine";
            HelperFunctions.GetDataInCB(getSurovine, surovineCBds, 0);
        }

        private void dodajBds_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }
    }
}
