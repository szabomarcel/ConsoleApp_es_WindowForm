using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Feltoltes_Click(object sender, EventArgs e)
        {
            int dolgozoid = Convert.ToInt32(textBox_DolgozoID);
            string nev = textBox_Nev.Text;
            string neme = textBox_Neme.Text;
            string reszleg = textBox_Reszleg.Text;
            int belepesev = Convert.ToInt32(textBox_Belepesev);
            int ber = Convert.ToInt32(textBox_Ber);
            using (SqlConnection connection = new SqlConnection())
            {
                string query = "INSERT INTO `dolgozok`(`dolgozoid`, `nev`, `neme`, `reszleg`, `belepesev`, `ber`) VALUES (@dolgozoid, @nev, @neme, @reszleg, @belepesev, @ber)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dolgozoid", dolgozoid);
                    command.Parameters.AddWithValue("@nev", nev);
                    command.Parameters.AddWithValue("@neme", neme);
                    command.Parameters.AddWithValue("@reszleg", reszleg);
                    command.Parameters.AddWithValue("@belepesev", belepesev);
                    command.Parameters.AddWithValue("@ber", ber);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Ellenőrizd, hogy sikerült-e hozzáadni az adatot
                    if (result == 1)
                    {
                        MessageBox.Show("Adat feltöltve az adatbázisba!");
                    }
                    else
                    {
                        MessageBox.Show("Hiba történt az adatfeltöltés során!");
                    }
                }
            }
        }
    }
}
