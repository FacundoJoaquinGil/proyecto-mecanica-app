using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_taller_mecanica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hidePanel();
        }

        //desde aqui 

        private void hidePanel()
        {
            panelPresupuesto.Visible = false;
            panelRegistro.Visible = false;
        }

        //metodo para los paneles

        private void showPaneles(Panel Paneles)
        {
            if (Paneles.Visible == false)
            {
                hidePanel();
                Paneles.Visible = true;
            }
            else
                Paneles.Visible = false;
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            showPaneles(panelPresupuesto);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            showPaneles(panelRegistro);
        }

        private void btnVolverRegistro_Click(object sender, EventArgs e)
        {
            hidePanel();
        }

        private void btnVolverPresupuesto_Click(object sender, EventArgs e)
        {
            hidePanel();
        }

       
    }
}
