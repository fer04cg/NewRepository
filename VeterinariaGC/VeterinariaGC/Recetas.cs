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
    public partial class Recetas : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Recetas()
        {
            InitializeComponent();
        }

        private void Recetas_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();

            comando.CommandText = " select * from Historial";
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                cboPaciente.Items.Add(lector[0].ToString());
            }

            lector.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtIdReceta.Enabled = true;
            cboPaciente.Enabled = true;
            txtMedicamentos.Enabled = true;
            txtIndicaciones.Enabled = true;
            txtIdCita.Enabled = true;
            txtPadecimiento.Enabled = true;
            txtTratamientos.Enabled = true;
            txtSintomas.Enabled = true;
            txtPadecimiento.Enabled = true;
            txtHora.Enabled = true;


            string con;
            int cont;
            comando.CommandText = "Select count(*) as total from Receta";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdReceta.Text = cont.ToString();
        }

        private void cboPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = " select * from historial where IdHistorial='" + cboPaciente.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();

            txtIdCita.Text = lector[1].ToString();
            txtTratamientos.Text = lector[5].ToString();
            txtSintomas.Text = lector[4].ToString();
            txtPadecimiento.Text = lector[3].ToString();
            txtHora.Text = lector[2].ToString();
            lector.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*comando.CommandText = ("Insert into Receta(IdReceta,IdHistorial)" + "values('" + txtIdReceta.Text + "','" + cboPaciente.Text + "')");
            comando.CommandText += ("Insert into DetalleReceta(IdDetalleReceta,IdReceta,Indicaciones,Medicamento)" + "values('" + txtIdReceta.Text + "','" + txtIndicaciones.Text + "','" + txtMedicamentos.Text + "')");
            comando.ExecuteNonQuery();
            llenarDtwReceta("");*/
            if (txtMedicamentos.Text != "" && txtIndicaciones.Text != "")
            {
                dgvRecetasRegistrar.Rows.Add(txtMedicamentos.Text, txtIndicaciones.Text);
                txtMedicamentos.Text = "";
                txtIndicaciones.Text = "";
            }
        }
        private void llenarDtwReceta(string extra)
        {
            dgvRecetasRegistrar.Rows.Clear();
            comando.CommandText = "Select * from Receta" + extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvRecetasRegistrar.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString(), lector[5].ToString());
            }
            lector.Close();
        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {
            comando.CommandText = ("Insert into Receta(IdReceta,IdHistorial) values(" + Convert.ToInt32(txtIdReceta.Text) + "," + Convert.ToInt32(cboPaciente.Text) + ")");
            comando.ExecuteNonQuery();
            int t = dgvRecetasRegistrar.Rows.Count - 2;
            if (t != -1)
            {
                for (int i = 0; i <= t; i++)
                {
                    string medicamento  = dgvRecetasRegistrar.Rows[i].Cells[0].Value.ToString();
                    string indicaciones = dgvRecetasRegistrar.Rows[i].Cells[1].Value.ToString();
                    comando.CommandText = ("Insert into detallereceta(IdReceta,Indicaciones,Medicamento) values(" + Convert.ToInt32(txtIdReceta.Text) + ",'" + indicaciones + "','" + medicamento + "')");
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
