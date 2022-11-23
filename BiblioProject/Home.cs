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
    public partial class Home : Form
    {
        //ClientInterface ClientInterface;
       // CdInterface cdInterface;


        public Home()
        {
            InitializeComponent();
            clientInterface = new ClientInterface(this);
           listecd = new ListeCdInterface();
           listelivre = new ListeLivreInterface();
            listeper=new ListePeriodiqueInterface();    
            //cd = new CdInterface(this);
        }

         public   ClientInterface clientInterface;
     public   ListeCdInterface listecd;
     public ListeLivreInterface listelivre;
     public ListePeriodiqueInterface listeper;
        //   public CdInterface cd; 
        int t1 = 45;
        

        
        private void button1_Click(object sender, EventArgs e)
        {
            panelClient.Visible = true;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.panelImane.Size = new Size(this.panelImane.Size.Width, t1);
            timer1.Start();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t1 > 325)
            {
                timer1.Stop();
            } else
            {
                this.panelImane.Size = new Size(this.panelImane.Size.Width, t1);
                t1 += 55;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



            //panelClient.Visible = false;
            //listecd.ShowDialog();
            //cd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelClient_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Home_Shown(object sender, EventArgs e)
        {
            //Display();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //ClientInterface clientInterface = new ClientInterface(this);
            clientInterface.Clear();
            clientInterface.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.panelImane.Size = panel5.Size;

            t1 = 45;
        }

        private void Home_Shown_1(object sender, EventArgs e)
        {
           // Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Clientdb.DisplayAndSearch("SELECT  ID,Nom,Prenom,Cin FROM CLIENT where cin like '%"+  textSearch.Text+ "%' ", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //Edit
                clientInterface.Clear();
                clientInterface.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                clientInterface.nom = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                clientInterface.prenom = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                clientInterface.CIN = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                clientInterface.UpdateInfo();
                clientInterface.ShowDialog();




                return;
            }
            if(e.ColumnIndex == 1)

                //Delete
            {
               if( MessageBox.Show("Vous voulez vraiment supprimer ce client ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Clientdb.DeleteClient(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                  //  Display();
                }


                return;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panelImane_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listelivre.Visible = false;
            listeper.Visible = false;
            ListeCdInterface liste = new ListeCdInterface();
            liste.TopLevel = false;
            panel7.Controls.Add(liste);
            liste.BringToFront();
            liste.Show();

            //liste.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listecd.Visible = false;
            listelivre.Visible = false;
            ListePeriodiqueInterface liste = new ListePeriodiqueInterface();
            liste.TopLevel = false;
            panel7.Controls.Add(liste);
            liste.BringToFront();
            liste.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listecd.Visible=false;
            listeper.Visible = false;
            ListeLivreInterface liste = new ListeLivreInterface();
            liste.TopLevel = false;
            panel7.Controls.Add(liste);
            liste.BringToFront();
            liste.Show();
        }
    }
}
