using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BiblioProject
{
     class Clientdb
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=bilio";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("MySql connection !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return conn;
        }


        public static void AddClient(Client c)
        {
            string sql = "INSERT INTO CLIENT VALUES (NULL, nom, prenom, age)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("nom", MySqlDbType.VarChar).Value = c.Nom;
            cmd.Parameters.Add("prenom", MySqlDbType.VarChar).Value = c.Prenom;
            cmd.Parameters.Add("cin", MySqlDbType.VarChar).Value = c.Cin;
            string m;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }catch (MySqlException ex)
            {
                MessageBox.Show("Client not insert. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
    }
}
