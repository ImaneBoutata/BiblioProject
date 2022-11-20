using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BiblioProject
{
    public partial class EmpruntView : Form
    {
        public EmpruntView()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EmpruntView_Load(object sender, EventArgs e)
        {
            Empruntdb.DisplayComboBox("SELECT CIN FROM CLIENT", comboBox1);

        }
    }
}
