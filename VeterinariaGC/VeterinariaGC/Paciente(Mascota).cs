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

    public partial class Paciente_Mascota_ : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Paciente_Mascota_()
        {
            InitializeComponent();
        }

        private void btoNuevo_Click(object sender, EventArgs e)
        {
            cboIdCliente.Enabled = true;
            txtIdPaciente.Enabled = true;
            txtNombreMascota.Enabled = true;
            txtPadecimiento.Enabled = true;


            string con;
            int cont;
            comando.CommandText = "Select count(*) as total from pacientemascota";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdPaciente.Text = cont.ToString();
        }

        private void Paciente_Mascota__Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();

            comando.CommandText = "Select * from Cliente";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboIdCliente.Items.Add(lector[1].ToString());

            }
            lector.Close();
            llenarDtwPaciente("");
        }
        private void llenarDtwPaciente(string extra)
        {
            dgvPacienteMascota.Rows.Clear();
            comando.CommandText = "select p.IdPaciente,c.Nombre,p.NombreMascota,p.Padecimiento,p.Raza,p.Genero,p.Edad from pacientemascota as p INNER JOIN cliente as c on p.IdCliente = c.IdCliente" + extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvPacienteMascota.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString(), lector[5].ToString(), lector[6].ToString());
            }
            lector.Close();
        }

        private void btoGrabar_Click(object sender, EventArgs e)
        {

            comando.CommandText = ("Insert into PacienteMascota(IdPaciente,IdCliente,NombreMascota,Padecimiento,Raza,Genero,Edad)" + "values('" + cboIdCliente.Text + "','" + txtIdPaciente.Text + "','" + txtNombreMascota.Text + "','" + txtPadecimiento.Text + "','" + txtRaza.Text + "','" + cboGenero.Text + "','" + txtEdad.Text + "')");
            comando.ExecuteNonQuery();
            llenarDtwPaciente("");
            

        }
        
        
        private void btoConsultar_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void btoSalir_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDtwPaciente(" where IdPaciente = " + Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenarDtwPaciente("");
            textBox1.Enabled = false;
            button1.Enabled = false;
            textBox1.Text = "";
        }

        private void dgvPacienteMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
