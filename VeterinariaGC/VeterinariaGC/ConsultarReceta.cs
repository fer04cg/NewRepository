using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaGC
{
    public partial class ConsultarReceta : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public ConsultarReceta()
        {
            InitializeComponent();
        }

        private void btoConsultar_Click(object sender, EventArgs e)
        {
            llenarDtw("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarDtw(" where r.IdReceta = " + Convert.ToInt32(textBox1.Text));
        }


        private void ConsultarReceta_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand();
            comando.CommandText = "Select * from DetalleReceta";
            lector = comando.ExecuteReader();
            lector.Close();
            llenarDtw("");
        }
        private void llenarDtw(string extra)
        {
            dgvConsultarReceta.Rows.Clear();
            //
            comando.CommandText = "select r.IdReceta, h.IdHistorial, m.Nombre,p.NombreMascota, cl.Nombre, h.Sintomas, h.Tratamiento from receta as r INNER join historial as h on r.IdHistorial = h.IdHistorial INNER JOIN citas as c on h.IdCita = c.IdCita INNER JOIN medico as m on m.IdMedico = c.IdMedico INNER JOIN pacientemascota as p on c.IdPaciente = p.IdPaciente INNER JOIN cliente as cl on cl.IdCliente = p.IdCliente"+extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvConsultarReceta.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString(), lector[5].ToString(), lector[6].ToString());
            }
            lector.Close();
        }

        private void dgvConsultarReceta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = dgvConsultarReceta.CurrentRow.Index;//consulta la posicion
            if(i != -1)//verifica si la posicion es difereente a menos 1 ya que si es menos 1 estas dando click a una celda 
            {
                dataGridView1.Rows.Clear();//limpia el dtw
                int id  = Convert.ToInt32(dgvConsultarReceta.Rows[i].Cells[0].Value);//obtiene la posicione a la cual se le esta dando click a la celda
                comando.CommandText = "Select * from detalleReceta where IdReceta = " + id;//consulta el datalle de la receta depeniendo el id de la receta
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    dataGridView1.Rows.Add(lector[2].ToString(), lector[3].ToString());
                }
                lector.Close();
            }
        }
    }
}
