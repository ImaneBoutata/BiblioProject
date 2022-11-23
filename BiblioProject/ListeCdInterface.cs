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
    public partial class ListeCdInterface : Form
    {
        public ListeCdInterface()
        {
            InitializeComponent();
            cd = new CdInterface(this);
        }
        public CdInterface cd;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Display()
        {
            CDdb.DisplayAndSearch("SELECT  ID,titre,auteur FROM CD", dataGridView);
        }
        private void ListeCdInterface_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void panelClient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            CDdb.DisplayAndSearch("SELECT  ID,titre,auteur FROM CD where titre like '%" + textSearch.Text + "%' ", dataGridView);

        }

        private void ListeCdInterface_Load(object sender, EventArgs e)
        {

        }
       
        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                cd.Clear();
                cd.id = Convert.ToInt32( dataGridView.Rows[e.RowIndex].Cells[2].Value);
                cd.titre = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                cd.auteur = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                cd.UpdateInfo();
                cd.ShowDialog();




                return;
            }
            if (e.ColumnIndex == 1)

            //Delete
            {
                if (MessageBox.Show("Vous voulez vraiment supprimer ce cd ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CDdb.DeleteCD(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    Display();
                }


                return;
            }
        }
    }
}
