using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = "INSERT INTO CLIENT VALUES (NULL, @nom, @prenom, @CIN)";
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



        public static void UpdateClient(Client c,int id)
        {
            string sql = "Update CLIENT SET nom=@nom,prenom=@prenom,CIN=@CIN where id=@clientId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = c.Nom;
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = c.Prenom;
            cmd.Parameters.Add("@CIN", MySqlDbType.VarChar).Value = c.Cin;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Client not update. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

           

        }



        public static void DeleteClient(int id)
        {
            string sql = "DELETE from  CLIENT where id=@clientId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@ClientID", MySqlDbType.VarChar).Value = id;


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
            string sql= query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource= tbl;
            con.Close();



        }


    }
}
