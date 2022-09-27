using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            wbNavegar.GoBack();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            wbNavegar.Navigate(txtURL.Text);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            wbNavegar.Refresh();
        }

        private void btnAlto_Click(object sender, EventArgs e)
        {
            wbNavegar.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            wbNavegar.GoHome();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            wbNavegar.GoForward();
        }
    }
}
