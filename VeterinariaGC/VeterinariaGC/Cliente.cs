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
    public partial class Cliente : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Cliente()
        {
            InitializeComponent();
        }

        private void btoNuevo_Click(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = true;
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            string con;
            int cont = 0;
            comando.CommandText = "Select count(*) as total from cliente";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdCliente.Text = cont.ToString();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();
            llenarDtwCliente("");
        }

        private void llenarDtwCliente(string extra)
        {
            dgvCliente.Rows.Clear();
            comando.CommandText = "Select * from Cliente"+ extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvCliente.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString());
            }
            lector.Close();
        }

        private void btoGrabar_Click(object sender, EventArgs e)
        {
            
            comando.CommandText = ("Insert into Cliente(IdCliente,Nombre,Telefono,Direccion,Email)" + "values('" + txtIdCliente.Text + "','" + txtNombre.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "','" + txtEmail.Text + "')");
            comando.ExecuteNonQuery();
            llenarDtwCliente("");
            limpiar();
            
        }
        

        private void btoConsultar_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void btoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDtwCliente(" where IdCliente = " + Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenarDtwCliente("");
            textBox1.Enabled = false;
            button1.Enabled = false;
            textBox1.Text = "";
        }
        private void limpiar()
        {
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }
    }
}
