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
    public partial class Historial : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();

            comando.CommandText = " select * from Citas";
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                cboIdCita.Items.Add(lector[0].ToString());
            }
            
            lector.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdHistorial.Enabled = true;
            cboIdCita.Enabled = true;
            txtHora.Enabled = true;
            txtPadecimiento.Enabled = true;
            txtSintomas.Enabled = true;
            txtTratamientos.Enabled = true;


            string con;
            int cont;
            comando.CommandText = "Select count(*) as total from Historial";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdHistorial.Text = cont.ToString();
        }

        private void cboIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "Select C.IdCita,C.Hora,P.Padecimiento FROM Citas as C Inner Join Pacientemascota as P on P.IdPaciente = C.IdPaciente where C.IdCita = '" + cboIdCita.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtHora.Text = lector[1].ToString();
            txtPadecimiento.Text = lector[2].ToString();
            /*.Text = lector[4].ToString();
            txtMascota.Text = lector[1].ToString();
            txtPadecimiento.Text = lector[2].ToString();
            txtIdCliente.Text = lector[0].ToString();*/
            lector.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comando.CommandText = ("Insert into Historial(IdHistorial,IdCita,Hora,Padecimiento,Sintomas,Tratamiento)" + "values('" + txtIdHistorial.Text + "','" + cboIdCita.Text + "','" + txtHora.Text +"','" + txtPadecimiento.Text+ "','"+ txtSintomas.Text+ "','"+ txtTratamientos.Text+ "')");
            comando.ExecuteNonQuery();
            llenarDtwHistorial("");

            /* comando.CommandText = "insert into Historial values (0," +
                 cboIdCita.Text + ",'" +
                 txtHora.Text + "','" +
                 txtPadecimiento.Text + "','" +
                 txtSintomas.Text + "','" +
                 txtTratamientos.Text + "','" +
                 ")";*/
        }
        private void llenarDtwHistorial(string extra)
        {
            dgvHistorial.Rows.Clear();
            comando.CommandText = "Select * from Historial" + extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvHistorial.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(),lector[4].ToString(),lector[5].ToString());
            }
            lector.Close();
        }
    }
}
