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
            }
            else if (result == DialogResult.No)
            {
            }
            

          
        }

        

    }
}
