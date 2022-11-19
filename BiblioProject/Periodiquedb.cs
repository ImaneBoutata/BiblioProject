using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BiblioProject
{
     class Periodiquedb
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

        public static void AddPeriodicite(Periodique p)
        {
            string sql = "INSERT INTO PERIODIQUE VALUES (NULL, @nom, @numero, @periodicite)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = p.Nom;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = p.Numero;
            cmd.Parameters.Add("@periodicite", MySqlDbType.VarChar).Value = p.Periodicite;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Periodique not insert. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }


        public static void UpdatePeriodicite(Periodique p, int id)
        {
            string sql = "Update PERIODIQUE SET nom=@nom,numero=@numero,periodicite=@periodicite where id=@periodiqueId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = p.Nom;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = p.Numero;
            cmd.Parameters.Add("@periodicite", MySqlDbType.VarChar).Value = p.Periodicite;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Periodique not update. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }


        public static void DeletePeriodique(int id)
        {
            string sql = "DELETE from  PERIODIQUE where id=@periodiqueId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@PeriodiqueID", MySqlDbType.VarChar).Value = id;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete it  Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Client not delete. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
