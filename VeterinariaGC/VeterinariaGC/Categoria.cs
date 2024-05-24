using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VeterinariaGC
{
    public partial class Categoria : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=Veterinariagc; uid= root;password=");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader lector;
        public Categoria()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            conn.Open();
            comando = conn.CreateCommand(); // Crea un comando asociado a la conexión
            llenarDtw(""); // Llama a la función llenarDtw para mostrar todos los registros
        }
        private void llenarDtw(string extra)
        {
            dataGridView1.Rows.Clear();// Limpia las filas existentes en el DataGridView
            comando.CommandText = "Select * from Categoria"+extra;
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dataGridView1.Rows.Add(lector[0].ToString(), lector[1].ToString());
            }
            lector.Close();
        }

        private void btoNuevo_Click(object sender, EventArgs e)
        {
            txtIdCategoria.Enabled = true;
            txtConcepto.Enabled = true;

            string con;
            int cont = 0;
            comando.CommandText = "Select count(*) as total from categoria";
            con = comando.ExecuteScalar().ToString();
            cont = (int)Convert.ToInt32(con) + 1;
            txtIdCategoria.Text = cont.ToString();
            
        }

        private void btoGrabar_Click(object sender, EventArgs e)
        {
            comando.CommandText = ("Insert into Categoria(IdCategoria,Concepto)" + "values('" + txtIdCategoria.Text + "','" + txtConcepto.Text + "')");
            comando.ExecuteNonQuery();
            llenarDtw("");
        }


        private void boSalir_Click(object sender, EventArgs e)
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
            llenarDtw(" where IdCategoria = " + Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenarDtw("");
            textBox1.Enabled = false;
            button1.Enabled = false;
            textBox1.Text = "";
        }
    }
}
