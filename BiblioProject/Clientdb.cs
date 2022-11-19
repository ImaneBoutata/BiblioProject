using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BiblioProject
{
     class Clientdb
    {
        public static MySqlConnection GetConnection()
        {
            // string sql = "datasource=localhost;port=3306;username=root;password=;database=biblio";
            string sql = "datasource=localhost;port=3306;username=root;password=;database=biblio";
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
            string sql = "INSERT INTO client VALUES (1, @nom, @prenom, @CIN)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = c.Nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = c.Prenom;
            cmd.Parameters.Add("@CIN", MySqlDbType.VarChar).Value = c.Cin;

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
