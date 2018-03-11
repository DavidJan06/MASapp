using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace MASapp
{
    public class HelperFunctions
    {
        static string ConStr = "data source=mas.db";

        public static void GetDataInDGV(string SqlCommand, DataGridView DGV)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConStr))
            {
                using (SQLiteCommand comm = new SQLiteCommand(SqlCommand, conn))
                {
                    comm.CommandType = CommandType.Text;
                    using (SQLiteDataAdapter sda = new SQLiteDataAdapter(comm))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            try
                            {
                                sda.Fill(dt);
                                DGV.DataSource = dt;
                            }
                            catch
                            {
                                MessageBox.Show(DGV.Name + " error!");
                            }
                        }
                    }
                }
            }
        }

        public static void GetDataInCB(string SqlCommand, ComboBox CB, int num)
        {
            ArrayList List = new ArrayList();

            using (SQLiteConnection conn = new SQLiteConnection(ConStr))
            {
                using (SQLiteCommand comm = new SQLiteCommand(SqlCommand, conn))
                {
                    comm.CommandType = CommandType.Text;
                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                List.Add(reader.GetValue(num));
                            }
                            catch
                            {
                                MessageBox.Show("List error!");
                            }
                        }

                        foreach (string y in List)
                        {
                            CB.Items.Insert(List.IndexOf(y), y);
                        }
                        List.Clear();
                    }
                }
            }
        }

    }
}
