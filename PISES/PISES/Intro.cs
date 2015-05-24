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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
            Timeintro.Enabled = true;
            Timeintro.Interval = 5000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Timeintro.Stop();

            Frase Frase = new Frase();
            Frase.Show();
            this.Hide();
            
        }
    }
}
