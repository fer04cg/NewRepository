namespace VeterinariaGC
{
    partial class ConsultarReceta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvConsultarReceta = new System.Windows.Forms.DataGridView();
            this.IdReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoConsultar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Indicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarReceta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultarReceta
            // 
            this.dgvConsultarReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReceta,
            this.IdHistorial,
            this.Medico,
            this.Paciente,
            this.Cliente,
            this.Sintomas,
            this.Tratamiento});
            this.dgvConsultarReceta.Location = new System.Drawing.Point(75, 30);
            this.dgvConsultarReceta.Name = "dgvConsultarReceta";
            this.dgvConsultarReceta.RowHeadersWidth = 51;
            this.dgvConsultarReceta.RowTemplate.Height = 24;
            this.dgvConsultarReceta.Size = new System.Drawing.Size(1202, 183);
            this.dgvConsultarReceta.TabIndex = 0;
            this.dgvConsultarReceta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarReceta_CellClick);
            // 
            // IdReceta
            // 
            this.IdReceta.HeaderText = "IdReceta";
            this.IdReceta.MinimumWidth = 6;
            this.IdReceta.Name = "IdReceta";
            this.IdReceta.Width = 125;
            // 
            // IdHistorial
            // 
            this.IdHistorial.HeaderText = "IdHistorial";
            this.IdHistorial.MinimumWidth = 6;
            this.IdHistorial.Name = "IdHistorial";
            this.IdHistorial.Width = 125;
            // 
            // Medico
            // 
            this.Medico.HeaderText = "Medico";
            this.Medico.MinimumWidth = 6;
            this.Medico.Name = "Medico";
            this.Medico.Width = 125;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.MinimumWidth = 6;
            this.Paciente.Name = "Paciente";
            this.Paciente.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 125;
            // 
            // Sintomas
            // 
            this.Sintomas.HeaderText = "Sintomas";
            this.Sintomas.MinimumWidth = 6;
            this.Sintomas.Name = "Sintomas";
            this.Sintomas.Width = 125;
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.MinimumWidth = 6;
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.Width = 125;
            // 
            // btoConsultar
            // 
            this.btoConsultar.Location = new System.Drawing.Point(164, 509);
            this.btoConsultar.Name = "btoConsultar";
            this.btoConsultar.Size = new System.Drawing.Size(75, 23);
            this.btoConsultar.TabIndex = 1;
            this.btoConsultar.Text = "Consultar";
            this.btoConsultar.UseVisualStyleBackColor = true;
            this.btoConsultar.Click += new System.EventHandler(this.btoConsultar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1084, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(650, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 74);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Categoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indicaciones,
            this.Medicamentos});
            this.dataGridView1.Location = new System.Drawing.Point(75, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(397, 166);
            this.dataGridView1.TabIndex = 16;
            // 
            // Indicaciones
            // 
            this.Indicaciones.HeaderText = "Indicaciones";
            this.Indicaciones.MinimumWidth = 6;
            this.Indicaciones.Name = "Indicaciones";
            this.Indicaciones.Width = 125;
            // 
            // Medicamentos
            // 
            this.Medicamentos.HeaderText = "Medicamentos";
            this.Medicamentos.MinimumWidth = 6;
            this.Medicamentos.Name = "Medicamentos";
            this.Medicamentos.Width = 125;
            // 
            // ConsultarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btoConsultar);
            this.Controls.Add(this.dgvConsultarReceta);
            this.Name = "ConsultarReceta";
            this.Text = "ConsultarReceta";
            this.Load += new System.EventHandler(this.ConsultarReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarReceta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarReceta;
        private System.Windows.Forms.Button btoConsultar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamentos;
    }
}