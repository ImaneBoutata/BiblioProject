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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string m;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
             string login = loginBox.Text;
           string password = MotdepasseBox.Text;
           if (login != "" && password != "")
           {
               if (login == "Admin" && password == "1234")
               {
                   Home home = new Home();
                   
                   home.Show();
                   this.Hide();
               }
               else
               {
                   label1.Visible = true;
                   //label1.BackColor = Color.Aqua;
                   label1.Text = "Mot de passe/ Login est incorrect";
               }

           }
           else
           {
               label1.Visible = true;

               label1.Text = "Veuillez saisir les champs obligatoires";
              // textBox1.BackColor = Color.Red;
               //textBox2.BackColor = Color.Red;
           }


        }
    }
}
