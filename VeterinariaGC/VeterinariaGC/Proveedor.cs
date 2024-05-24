using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeterinariaGC
{
    public partial class Proveedor : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Proveedor()
        {
            InitializeComponent();
        }

        private void btoNuevo_Click(object sender, EventArgs e)
        {
            txtIdProveedor.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtCiudad.Enabled = true;
            txtEstado.Enabled = true;
            txtCodigoPostal.Enabled = true;
            txtColonia.Enabled = true;
            string con;
            int cont = 0;
            comando.CommandText = "Select count(*) as total from proveedor";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdProveedor.Text = cont.ToString();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();
            llenarDtwProveedor("");
        }

        private void btoGrabar_Click(object sender, EventArgs e)
        {
            comando.CommandText = ("Insert into Proveedor(IdProveedor,Nombre,Direccion,Telefono,Ciudad,Estado,CodigoPostal,Colonia,Email)" + "values('" + txtIdProveedor.Text + "','" + txtNombre.Text + "','" +txtDireccion.Text + "','" +txtTelefono.Text+"','"+ txtCiudad.Text+"','"+ txtEstado.Text+ "','"+ txtCodigoPostal.Text+ "','"+txtColonia.Text+ "','" + txtEmail.Text + "')");
            comando.ExecuteNonQuery();
            llenarDtwProveedor("");
            limpiar();
        }

        private void btoConsultar_Click(object sender, EventArgs e)
        {
            txtProveedor.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDtwProveedor(" where IdProveedor = " + Convert.ToInt32(txtProveedor.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenarDtwProveedor("");
            txtProveedor.Enabled = false;
            button1.Enabled = false;
            txtProveedor.Text = "";
        }
        private void limpiar()
        {
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtIdProveedor.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
            txtEstado.Text = "";
            txtCodigoPostal.Text = "";
            txtColonia.Text = "";

        }
        private void llenarDtwProveedor(string extra)
        {
            dgvProveedor.Rows.Clear();
            comando.CommandText = "Select * from proveedor" + extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvProveedor.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString(), lector[5].ToString(), lector[6].ToString(), lector[7].ToString(), lector[8].ToString());
            }
            lector.Close();
        }
    }
}
