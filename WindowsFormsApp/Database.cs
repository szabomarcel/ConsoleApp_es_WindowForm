using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Mysqlx.Notice.Warning.Types;

namespace WindowsFormsApp
{
    internal class Database
    {
        MySqlCommand sqlCommand;
        MySqlConnection connection;

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "dolgozok";
            connection = new MySqlConnection(builder.ConnectionString);
            sqlCommand = connection.CreateCommand();
            try
            {
                kapcsolatnyit();
                kapcsolatzar();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private void kapcsolatzar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void kapcsolatnyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public List<Database> getModify()
        {
            
            List<Database> dolgozok = new List<Database>();
            sqlCommand.CommandText = "INSERT INTO `dolgozok`(`dolgozoid`, `nev`, `neme`, `reszleg`, `belepesev`, `ber`) VALUES (?, ?, ?, ?, ?, ?)";
            kapcsolatnyit();
            using (MySqlDataReader dr = sqlCommand.ExecuteReader())
            {
                while (dr.Read())
                {
                    //Database dolgozo = new Database(dr.GetInt32("dolgozoid"), dr.GetString("nev"), dr.GetString("neme"), dr.GetString("reszleg"), dr.GetInt32("belepesev"), dr.GetInt32("ber"));
                    //dolgozok.Add(dolgozo);
                }
            }
            kapcsolatzar();
            return dolgozok;
        }
    }
}
