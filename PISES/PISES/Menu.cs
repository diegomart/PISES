using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PISES
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir del Sistema",
                                                    MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //MessageBox.Show("Hola"); 
                Application.Exit();
                //this.Close();               
                
            }
            else if (result == DialogResult.No)
            {
            }
            

          
        }

      
        private void aritmeticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aritmetica Arit = new Aritmetica();
            Arit.MdiParent = this;
            Arit.Show();

        }

        private void comparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Naturales Natu = new Naturales();
            Natu.MdiParent = this;
            Natu.Show();
        }

        private void raicezYPotenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaizPotencia RP = new RaizPotencia();
            RP.MdiParent = this;
            RP.Show();
        }

        private void áLGEBRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algebra ALG = new Algebra();
            ALG.MdiParent = this;
            ALG.Show();
        }

        private void figurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figuras Fig = new Figuras();
            Fig.MdiParent = this;
            Fig.Show();
        }

        private void triángulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangulos TANG = new Triangulos();
            TANG.MdiParent = this;
            TANG.Show();
        }

        private void graficasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graficas GR = new Graficas();
            GR.MdiParent = this;
            GR.Show();
        }

        private void probabilidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Probabilidad PB = new Probabilidad();
            PB.MdiParent = this;
            PB.Show();
        }

        

    }
}
