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
            int selectedIndex = surovineCBds.SelectedIndex;
            Object selectedValue = surovineCBds.SelectedItem;

            MessageBox.Show(selectedValue.ToString());


            string dodajSurovine = "UPDATE surovine SET kolicina = kolicina + ('" + steviloTBds.Text + "') WHERE ime LIKE  '" + selectedValue.ToString() + "'";

            SQLiteConnection connection = new
            SQLiteConnection("data source=mas.db");


            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);

            //SQLiteDataAdapter adapt = new SQLiteDataAdapter();
            //DataSet ds = new DataSet();

            command.CommandText = dodajSurovine;

            //adapt.SelectCommand = command;
            //  adapt.Fill(ds, "delavci");
            //   DataRow nrow = ds.Tables["delavci"].NewRow();
          
               

                command.ExecuteNonQuery();

                connection.Close();
            


            MessageBox.Show("Uspešno dodano!");
        }

        private void DodajSurovine_Load(object sender, EventArgs e)
        {

        }
    }
}
