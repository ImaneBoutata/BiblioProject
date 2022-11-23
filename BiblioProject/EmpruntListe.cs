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
    public partial class EmpruntListe : Form
    {
        public EmpruntListe()
        {
            InitializeComponent();
            empruntView = new EmpruntView(this);

        }
        public EmpruntView empruntView;

        public void Display()
        {
            Clientdb.DisplayAndSearch("SELECT  ID,DATEEMPRUNT,DATERETOUR,CINCLIENT,TITRELIVRE,TITRECD,NOMPERIODIQUE FROM EMPRUNT", dataGridView1);
        }
        private void EmpruntListe_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                empruntView.Clear();
                empruntView.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                empruntView.dateEmprunt = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                empruntView.dateRetour = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                empruntView.cinClient = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                empruntView.titreLivre = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                empruntView.titreCd = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                empruntView.nomPeriodique = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                //empruntView.UpdateInfo();
                empruntView.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)

            //Delete
            {
                if (MessageBox.Show("Vous voulez vraiment supprimer cet emprunt ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Empruntdb.DeleteEmprunt(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    Display();
                }


                return;
            }
        }

        private void EmpruntListe_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            empruntView.Clear();
            empruntView.ShowDialog();
        }
    }
}
