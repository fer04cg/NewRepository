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

namespace VeterinariaGC
{
    public partial class Contribuyente : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Contribuyente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btoNuevo_Click(object sender, EventArgs e)
        {
            
            txtIdContribuyente.Enabled = true;
            txtNombre.Enabled = true;
            txtRFC.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;

            string con;
            int cont = 0;
            comando.CommandText = "Select count(*) as total from contribuyente";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdContribuyente.Text = cont.ToString();

        }

        private void btoGrabar_Click(object sender, EventArgs e)
        {
            
            comando.CommandText = ("Insert into Contribuyente(IdContribuyente,Nombre,RFC,Telefono,Email)" + "values('" + txtIdContribuyente.Text + "','" + txtNombre.Text + "','" + txtRFC.Text + "','" + txtTelefono.Text + "','" + txtEmail.Text + "')");
            comando.ExecuteNonQuery();
            llenarDtwContribuyente("");
        }

        private void Contribuyente_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();
            llenarDtwContribuyente("");
        }

        private void llenarDtwContribuyente(string extra)
        {
            dgvContribuyente.Rows.Clear();
            comando.CommandText = "Select * from Contribuyente"+ extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvContribuyente.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString());
            }
            lector.Close();
        }

        private void btoModificar_Click(object sender, EventArgs e)
        {

        }

        private void btoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDtwContribuyente(" where IdContribuyente = " + Convert.ToInt32(textBox1.Text));
        }

        private void btoConsultar_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenarDtwContribuyente("");
            textBox1.Enabled = false;
            button1.Enabled = false;
            textBox1.Text = "";
        }
    }
}
