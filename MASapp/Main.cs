using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MASapp
{
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dodajanje_surovine dodaj = new dodajanje_surovine();
            dodaj.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //SQLiteConnection conn = new
            //  SQLiteConnection("data source=mas.sqlite");


            //conn.Open();

            //SQLiteCommand comm = new SQLiteCommand("Select * FROM surovine", conn);
            //using (SQLiteDataReader read = comm.ExecuteReader())
            //{
            //    while (read.Read())
            //    {
            //        dataGridView1.AutoGenerateColumns = true;
                   
            //       this.dataGridView1.Rows.Add(read.GetString(1));
            //    }
            //}
        }
    }
}
