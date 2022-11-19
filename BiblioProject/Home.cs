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
        public Home()
        {
            InitializeComponent();
        }


        int t1 = 45;
        

        
        private void button1_Click(object sender, EventArgs e)
        {

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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.panelImane.Size = panel5.Size;

            t1 = 45;
        }
    }
}
