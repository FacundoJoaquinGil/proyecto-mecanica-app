using System;
using System.Windows.Forms;
using app_taller_mecanica_cln;


namespace app_taller_mecanica
{
    public partial class Form1 : Form
    {

        private ClienteCLN clienteCLN = new ClienteCLN();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clienteCLN.ObtenerClientes();
        }

        private void GuardarCliente()
        {
            string nombreYApellido = txtTitular.Text;
            string telefono = "123456789"; /* falta el input */ 
            string domicilio = "Bella Vista"; /* falta el input */


        }

        private void GuardarVehiculo()
        {

        }

        private void GuardarPresupuesto()
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            GuardarVehiculo();
            GuardarPresupuesto();
        }
    }
}
