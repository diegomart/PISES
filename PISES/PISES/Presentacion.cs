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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
            Tiempo.Enabled = true;
            Tiempo.Interval = 4000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Tiempo.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        
    }
}
