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
    public partial class Frase : Form
    {
        public Frase()
        {
            InitializeComponent();
            TimeFrase.Enabled = true;
            TimeFrase.Interval = 3000;
        }

        private void TimeFrase_Tick(object sender, EventArgs e)
        {

            TimeFrase.Stop();

            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}
