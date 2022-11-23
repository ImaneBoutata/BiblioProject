using MySql.Data.MySqlClient;

namespace BiblioProject
{
    public partial class ClientInterface : Form
    {

        private readonly ClientListe _parent;
       public string id, nom, prenom, CIN;

        public ClientInterface(ClientListe parent)
        {
            InitializeComponent();
            _parent = parent;
        }
      

       public void UpdateInfo()
        {
            textForm.Text = "Modifier un client ";
            ajouterBtn.Text = "Modifier";
            nomBox.Text = nom;
            prenomBox.Text = prenom;
            cinBox.Text=CIN;


        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        public void Clear()
        {
            nomBox.Text=prenomBox.Text=cinBox.Text=String.Empty;
        }

       /* private void button1_Click(object sender, EventArgs e)
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
            _parent.Display();
     
        }

         }
}
        }*/

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void annulerBtn_Click(object sender, EventArgs e)
        {
            Close();
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
                MessageBox.Show("le nom de client est  > 3");
                return;
            }
            if (ajouterBtn.Text == "Ajouter")
            {
               
                Client c = new Client(nomBox.Text.Trim(), prenomBox.Text.Trim(), cinBox.Text.Trim());
                textForm.Text = "Ajouter un client ";
                ajouterBtn.Text = "Ajouter";
                nomBox.Text = nom;
                prenomBox.Text = prenom;
                cinBox.Text = CIN;
                Clientdb.AddClient(c);
                Clear();
                
            }
            if (ajouterBtn.Text == "Modifier")
            {

                Client c = new Client(nomBox.Text.Trim(), prenomBox.Text.Trim(), cinBox.Text.Trim());
                Clientdb.UpdateClient(c,id);
                Clear();
               
            }
           // _parent.Display();
        }
    }
}