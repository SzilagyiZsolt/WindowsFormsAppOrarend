using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orarend";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                nyit();

                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public List<Orak> getOrak(string nap)
        {
            nyit();
            List<Orak> orak = new List<Orak>();
            command.CommandText = $"SELECT `oraid`,`tantargy`,`sorszam`,`hetnapja` FROM `orak` WHERE hetnapja=\"{nap}\" ORDER BY `orak`.`sorszam` ASC";
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    orak.Add(new Orak(dr.GetInt32("oraid"), dr.GetString("tantargy"), dr.GetInt32("sorszam"), dr.GetString("hetnapja")));
                }
            }
            zar();
            return orak;

        }
        public int validUser(string name, string pass)
        {
            int userid = -1;
            nyit();
            command.CommandText = "SELECT tanarok.jelszo, tanarok.tanarid FROM tanarok WHERE tanarok.tanarnev=@nev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", name);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                if (taroltJelszo.Equals(pass))
                {
                    userid = reader.GetInt32("tanarid");
                }
            }
            zar();
            return userid;
        }
        public void Torles(int oraid)
        {
            nyit();
            command.CommandText =$"DELETE FROM orak WHERE `orak`.`oraid` = {oraid};";
            command.ExecuteNonQuery();
            zar();
        }
        public void Modositas(string tantargy, decimal sorszam, int oraid)
        {
            nyit();
            command.CommandText = $"UPDATE `orak` SET `tantargy`='{tantargy}', `sorszam`='{sorszam}' WHERE orak.oraid={oraid}";
            command.ExecuteNonQuery();
            zar();
        }
        public void Beszuras(string tantargy, decimal sorszam)
        {
            nyit();
            command.CommandText = $"INSERT INTO `orak` (`tantargy`, `sorszam`) VALUES ('{tantargy}', '{sorszam}');";
            command.ExecuteNonQuery();
            zar();
        }
    }
}
