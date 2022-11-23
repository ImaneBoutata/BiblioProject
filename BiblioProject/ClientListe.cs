using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioProject
{
    public partial class ClientListe : Form
    {
      //  ClientInterface ClientInterface;

        public ClientListe()
        {
            InitializeComponent();
            clientInterface = new ClientInterface(this);

        }
        public ClientInterface clientInterface;

        public void Display()
        {
            Clientdb.DisplayAndSearch("SELECT  ID,Nom,Prenom,Cin FROM CLIENT", dataGridView1);
        }

        private void ClientListe_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void ClientListe_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clientInterface.Clear();
            clientInterface.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                clientInterface.Clear();
                clientInterface.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                clientInterface.nom = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                clientInterface.prenom = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                clientInterface.CIN = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                clientInterface.UpdateInfo();
                clientInterface.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)

            //Delete
            {
                if (MessageBox.Show("Vous voulez vraiment supprimer ce client ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Clientdb.DeleteClient(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }


                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Clientdb.DisplayAndSearch("SELECT  ID,Nom,Prenom,Cin FROM CLIENT where cin like '%" + textBox1.Text + "%' ", dataGridView1);

        }
    }
}
