using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaGC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void pacienteMacotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paciente_Mascota_ paciente_Mascota = new Paciente_Mascota_();
            paciente_Mascota.Show();
        }

        private void contribuyenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contribuyente contribuyente = new Contribuyente();
            contribuyente.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbCitas citas = new gbCitas();  
            citas.Show();   
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Recetas recetas = new Recetas();
            recetas.Show(); 
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.Show(); 
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Show();
        }

        private void registrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas();
            facturas.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCitas consultarCitas = new ConsultarCitas();
            consultarCitas.Show();
            
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ConsultarHistorial consultarHistorial = new ConsultarHistorial();
            consultarHistorial.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarReceta consultarReceta = new ConsultarReceta();
            consultarReceta.Show();
        }
    }
}
