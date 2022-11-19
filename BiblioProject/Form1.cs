using System.Data;
using MySql.Data.MySqlClient;

namespace BiblioProject
{
    public partial class Form1 : Form
    {
        private readonly Form1 _parent;
        public Form1(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            if(nomBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client name is Empty ( > 3).");
                return;
            }
            if(ajouterBtn.Text == "ajouter")
            {*/
            //  Client c = new Client(nomBox.Text.Trim(), prenomBox.Text.Trim(), cinBox.Text.Trim());
            // Clientdb.AddClient(c);
            // Clear();  
            // }
            //_parent.Display();
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=biblio;uid=\"\";pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}