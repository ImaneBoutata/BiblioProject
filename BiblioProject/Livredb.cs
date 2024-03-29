﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BiblioProject
{
     class Livredb 
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

        public static void AddLivre(Livre l)
        {
            string sql = "INSERT INTO LIVRE VALUES (NULL, @auteur, @titre, @editeur)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@auteur", MySqlDbType.VarChar).Value = l.Auteur;
            cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = l.Titre;
            cmd.Parameters.Add("@editeur", MySqlDbType.VarChar).Value = l.Editeur;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Client not insert. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }


        public static void UpdateLivre(Livre l, int id)
        {
            string sql = "Update LIVRE SET auteur=@auteur,titre=@titre,editeur=@editeur where id=@livreId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@auteur", MySqlDbType.VarChar).Value = l.Auteur;
            cmd.Parameters.Add("@titre", MySqlDbType.VarChar).Value = l.Titre;
            cmd.Parameters.Add("@editeur", MySqlDbType.VarChar).Value = l.Editeur;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Livre not update. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }


        public static void DeleteLivre(int id)
        {
            string sql = "DELETE from  LIVRE where id=@livreId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@LivreID", MySqlDbType.VarChar).Value = id;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete it  Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Livre not delete. " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            dgv.DataSource = tbl;
            con.Close();


        }


    }
}
