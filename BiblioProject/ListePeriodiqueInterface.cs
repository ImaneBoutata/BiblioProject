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
    public partial class ListePeriodiqueInterface : Form
    {
        public ListePeriodiqueInterface()
        {
            InitializeComponent();
            per = new PeriodiqueInterface(this);
        }
        public PeriodiqueInterface per;
        private void addBtn_Click(object sender, EventArgs e)
        {
            per.ShowDialog();
        }
        public void Display()
        {
            Periodiquedb.DisplayAndSearch("SELECT  ID,Nom,numero,periodicite FROM Periodique", dataGridView);
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                per.Clear();
                per.id = Convert.ToInt32( dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                per.nom = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                per.numero = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                per.periodicite = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                per.UpdateInfo();
                per.ShowDialog();




                return;
            }
            if (e.ColumnIndex == 1)

            //Delete
            {
                if (MessageBox.Show("Vous voulez vraiment supprimer cette periodique ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Periodiquedb.DeletePeriodique(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    Display();
                }


                return;
            }
        }

        private void ListePeriodiqueInterface_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void ListePeriodiqueInterface_Load(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            Periodiquedb.DisplayAndSearch("SELECT  ID,nom,numero,periodicite FROM periodique where nom like '%" + textSearch.Text + "%' ", dataGridView);
        }
    }
}
