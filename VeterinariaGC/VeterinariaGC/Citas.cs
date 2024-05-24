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
    public partial class gbCitas : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public gbCitas()
        {
            InitializeComponent();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();

            comando.CommandText = "Select * from PacienteMascota ";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboCitasPaciente.Items.Add(lector["NombreMascota"].ToString());
            }
            lector.Close();

            comando.CommandText = "Select * from Medico";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cboNombreMedico.Items.Add(lector["Nombre"].ToString());
            }
            lector.Close();

            cbRegistrar.Items.Clear();

            lector.Close();

            llenarDtw();

        }

        private void llenarCbo()
        {
            cbRegistrar.Items.Clear();
            Boolean existe;
            int t = dtwCitas.Rows.Count - 2;
            for (int i  =  8; i <= 20; i++)
            {
                existe = false;
                int idcita = 0;
                for(int j = 0; j <= t; j++)
                {
                    string hora = dtwCitas.Rows[j].Cells[4].Value.ToString();
                    char e = Convert.ToChar(dtwCitas.Rows[j].Cells[5].Value.ToString());
                    if(i == Convert.ToInt32(hora) && e == 'A')
                    {
                        existe =  true;
                    }
                    if (i == Convert.ToInt32(hora) && e == 'R')
                    {
                        existe = true;
                        idcita = int.Parse(dtwCitas.Rows[j].Cells[0].Value.ToString());
                    }
                }
                if(15 == i || 14 == i)
                {
                    existe = true;
                }
                if(existe == false)
                {
                    cbRegistrar.Items.Add(i);
                }
            }
        }

        private void btoNuevo_Click(object sender, EventArgs e)
        {
            txtIdPaciente.Enabled = true;
            cboCitasPaciente.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            gbCita.Enabled = true;
            gbMedico.Enabled = true;
            gbRegistrar.Enabled = true;


            string con;
            int cont;
            comando.CommandText = "Select count(*) as total from Citas";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdCita.Text = cont.ToString();
            llenarCbo();
        }

        private void cboCitasPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = "Select PM.IdPaciente,PM.NombreMascota,PM.Padecimiento, C.Telefono, C.Direccion FROM Cliente as C Inner Join Pacientemascota as PM on C.IdCliente = PM.IdCliente where PM.NombreMascota = '" + cboCitasPaciente.Text + "'";
            lector = comando.ExecuteReader();
            lector.Read();
            txtIdPaciente.Text = lector[0].ToString();
            txtTelefono.Text = lector[3].ToString();
            txtDireccion.Text = lector[4].ToString();
            txtMascota.Text = lector[1].ToString();
            txtPadecimiento.Text = lector[2].ToString();
            txtIdCliente.Text = lector[0].ToString();
            lector.Close();
        }

        private void cboNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comando.CommandText = " select * from medico where Nombre='" + cboNombreMedico.Text + "'";
            lector= comando.ExecuteReader();
            lector.Read() ;

            txtIdMedico.Text = lector[0].ToString();
            txtCedula.Text = lector[2].ToString();
            lector.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year;
            comando.CommandText = ("Insert into citas(IdCita,IdMedico,IdPaciente,Fecha,Hora,Estado)" + "values('" + txtIdCita.Text + "','" + txtIdMedico.Text+ "','" + txtIdPaciente.Text + "','"+fecha+ "','" + cbRegistrar.Text + "','R')");
            comando.ExecuteNonQuery();
            llenarDtw();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbAtender.Enabled = true;
            dateTimePicker1.Enabled = true;
            string fecha = dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year;
            MessageBox.Show(fecha);
            comando.CommandText = "Select * from citas where Estado = 'R' and Fecha = '"+fecha+"'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cbAtender.Items.Add(lector[0].ToString());
            }
            lector.Close();
            gbAtender.Enabled = true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            gbCancelar.Enabled = true;
            dateTimePicker1.Enabled = true;
            string fecha = dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year;
            comando.CommandText = "Select * from citas where Estado = 'R' and Fecha  = '" + fecha + "'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                cbCancelar.Items.Add(lector[0].ToString());
            }
            lector.Close();
            gbCancelar.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbCancelar_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;

        }

        private void cbAtender_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comando.CommandText = "Update citas set Estado = 'C' where IdCita = " + Convert.ToInt32(cbCancelar.Text);
            comando.ExecuteNonQuery();
            button2.Visible = false;
            cbCancelar.Text = "";
            gbCancelar.Enabled = false;
            llenarDtw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comando.CommandText = "Update citas set Estado = 'A' where IdCita = " + Convert.ToInt32(cbAtender.Text);
            comando.ExecuteNonQuery();
            button1.Visible = false;
            cbAtender.Text = "";
            gbAtender.Enabled = false;
            llenarDtw();
        }

        private void llenarDtw()
        {
            dtwCitas.Rows.Clear();
            string fecha = dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Year;
            comando.CommandText = "select c.IdCita, m.Nombre, p.NombreMascota, c.Fecha, c.Hora, c.Estado from citas as c INNER JOIN medico as m on c.IdMedico  = m.IdMedico INNER JOIN pacientemascota as p  on c.IdPaciente = p.IdPaciente where Fecha = '"+fecha+"'";
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dtwCitas.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString(), lector[5].ToString());
            }
            lector.Close();
        }

        private void cbRegistrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            llenarDtw();
            llenarCbo();
        }
        private void limpiar()
        {
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtIdCita.Text = "";
            txtIdCliente.Text = "";
            txtIdMedico.Text = "";
            txtIdPaciente.Text = "";
            txtMascota.Text = "";
            txtPadecimiento.Text = "";
            txtTelefono.Text = "";
            cboNombreMedico.Text = "";
            cboCitasPaciente.Text = "";
            cbRegistrar.Text = "";
        }
    }
    
}
