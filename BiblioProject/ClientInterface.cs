using MySql.Data.MySqlClient;

namespace BiblioProject
{
    public partial class ClientInterface : Form
    {

        private readonly Home _parent;
        string m;

        public ClientInterface(Home parent)
        {
            InitializeComponent();
            _parent = parent;
            //_parent = parent;
        }

        public void Display()
        {
            //Clientdb.DisplayAndSearch("SELECT  ID,Nom,Prenom,Cin FROM CLIENT", dataGridView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        public void Clear()
        {
            nomBox.Text=prenomBox.Text=cinBox.Text=String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (nomBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client name is Empty ( > 3).");
                return;
            }
            if (ajouterBtn.Text == "ajouter")
            {

                Client c = new Client(nomBox.Text.Trim(), prenomBox.Text.Trim(), cinBox.Text.Trim());
                Clientdb.AddClient(c);
                Clear();  
            }
            //_parent.Display();








            /* string connetionString = null;
             MySqlConnection cnn;
             connetionString = "server=localhost;database=bibl;uid=root;pwd=\"\";";
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
}*/
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            if (nomBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Client name is Empty ( > 3).");
                return;
            }
            if (ajouterBtn.Text == "Ajouter")
            {

                Client c = new Client(nomBox.Text.Trim(), prenomBox.Text.Trim(), cinBox.Text.Trim());
                Clientdb.AddClient(c);
                Clear();  
            }
            Display();
        }
    }
}