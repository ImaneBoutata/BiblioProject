using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BiblioProject
{
     class Empruntdb
    {
        public static MySqlConnection GetConnection()
        {
            //string sql = "datasource=localhost;port=3306;username=root;password=;database=biblio";
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


        public static void AddEmprunt(Emprunt e)
        {
            string sql = "INSERT INTO EMPRUNT VALUES (NULL, @dateEmprunt, @dateRetour, @client,@ouvrage)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@dateEmprunt", MySqlDbType.VarChar).Value = e.DateEmprunt;
            cmd.Parameters.Add("@dateRetour", MySqlDbType.VarChar).Value = e.DateRetour;
            cmd.Parameters.Add("@client", MySqlDbType.VarChar).Value = e.Client;
            cmd.Parameters.Add("@ouvrage", MySqlDbType.VarChar).Value = e.Ouvrage;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Emprunt not insert. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }



        public static void UpdateEmprunt(Emprunt e, int id)
        {
            string sql = "Update EMPRUNT SET dateEmprunt=@dateEmprunt,dateRetour=@dateRetour,client=@client,ouvrage=@ouvrage where id=@clientId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@dateEmprunt", MySqlDbType.VarChar).Value = e.DateEmprunt;
            cmd.Parameters.Add("@dateRetour", MySqlDbType.VarChar).Value = e.DateRetour;
            cmd.Parameters.Add("@client", MySqlDbType.VarChar).Value = e.Client;
            cmd.Parameters.Add("@ouvrage", MySqlDbType.VarChar).Value = e.Ouvrage;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Emprunt not update. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();



        }


        public static void DeleteEmprunt(int id)
        {
            string sql = "DELETE from  EMPRUNT where id=@empruntId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@EmpruntID", MySqlDbType.VarChar).Value = id;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete it  Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Emprunt not delete. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();



        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();



        }



    }
}
