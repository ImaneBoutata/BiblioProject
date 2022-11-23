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
    public partial class ListeLivreInterface : Form
    {
        public LivreInterface livre;
        public ListeLivreInterface()
        {
            InitializeComponent();
            livre =new LivreInterface(this);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            livre.ShowDialog();

        }
        public void Display()
        {
            Livredb.DisplayAndSearch("SELECT  ID,titre,auteur,editeur FROM livre", dataGridView);
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                livre.Clear();
                livre.id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value);
                livre.titre = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                livre.auteur = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                livre.editeur = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                livre.UpdateInfo();
                livre.ShowDialog();




                return;
            }
            if (e.ColumnIndex == 1)

            //Delete
            {
                if (MessageBox.Show("Vous voulez vraiment supprimer ce livre ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CDdb.DeleteCD(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    Display();
                }


                return;
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            Livredb.DisplayAndSearch("SELECT  ID,titre,auteur ,editeur FROM livre where titre like '%" + textSearch.Text + "%' ", dataGridView);

        }

        private void ListeLivreInterface_Load(object sender, EventArgs e)
        {

        }

        private void ListeLivreInterface_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
