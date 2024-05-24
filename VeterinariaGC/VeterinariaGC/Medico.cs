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
    public partial class Medico : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Medico()
        {
            InitializeComponent();
        }

        private void btoNuevo_Click(object sender, EventArgs e)
        {

            txtIdMedico.Enabled = true;
            txtNombre.Enabled = true;
            txtCedula.Enabled = true;
            string con;
            int cont = 0;
            comando.CommandText = "Select count(*) as total from Medico";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdMedico.Text = cont.ToString();
        }

        private void Medico_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();
            llenarDtwMedico("");
        }
        private void llenarDtwMedico(string extra)
        {
            dgvMedico.Rows.Clear();
            comando.CommandText = "Select * from Medico"+ extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvMedico.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString());
            }
            lector.Close();
        }

        private void btoGrabar_Click(object sender, EventArgs e)
        {
            comando.CommandText = ("Insert into Medico(IdMedico,Nombre,Cedula)" + "values('" + txtIdMedico.Text + "','" + txtNombre.Text + "','" + txtCedula.Text + "')");
            comando.ExecuteNonQuery();
            llenarDtwMedico("");
        }
       

        private void btoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoConsultar_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDtwMedico(" where IdMedico = " + Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenarDtwMedico("");
            textBox1.Enabled = false;
            button1.Enabled = false;
            textBox1.Text = "";
        }
    }
}
