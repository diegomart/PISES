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

        private void aRITMÉTICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aritmetica Arit = new Aritmetica();
            Arit.MdiParent = this;
            Arit.Show();
        }

        

    }
}
