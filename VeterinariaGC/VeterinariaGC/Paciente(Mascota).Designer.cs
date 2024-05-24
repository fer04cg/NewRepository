namespace VeterinariaGC
{
    partial class Paciente_Mascota_
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboIdCliente = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btoNuevo = new System.Windows.Forms.Button();
            this.btoGrabar = new System.Windows.Forms.Button();
            this.btoConsultar = new System.Windows.Forms.Button();
            this.dgvPacienteMascota = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoSalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteMascota)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGenero);
            this.groupBox1.Controls.Add(this.cboIdCliente);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtRaza);
            this.groupBox1.Controls.Add(this.txtNombreMascota);
            this.groupBox1.Controls.Add(this.txtPadecimiento);
            this.groupBox1.Controls.Add(this.txtIdPaciente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(72, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Paciente";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cboGenero.Location = new System.Drawing.Point(391, 99);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 24);
            this.cboGenero.TabIndex = 15;
            // 
            // cboIdCliente
            // 
            this.cboIdCliente.FormattingEnabled = true;
            this.cboIdCliente.Location = new System.Drawing.Point(133, 87);
            this.cboIdCliente.Name = "cboIdCliente";
            this.cboIdCliente.Size = new System.Drawing.Size(121, 24);
            this.cboIdCliente.TabIndex = 14;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(391, 151);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 13;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(391, 39);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 22);
            this.txtRaza.TabIndex = 12;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(154, 154);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(100, 22);
            this.txtNombreMascota.TabIndex = 10;
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Location = new System.Drawing.Point(144, 219);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(100, 22);
            this.txtPadecimiento.TabIndex = 9;
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Enabled = false;
            this.txtIdPaciente.Location = new System.Drawing.Point(127, 36);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(100, 22);
            this.txtIdPaciente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Padecimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NombreCliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Paciente";
            // 
            // btoNuevo
            // 
            this.btoNuevo.Location = new System.Drawing.Point(72, 362);
            this.btoNuevo.Name = "btoNuevo";
            this.btoNuevo.Size = new System.Drawing.Size(75, 23);
            this.btoNuevo.TabIndex = 1;
            this.btoNuevo.Text = "Nuevo";
            this.btoNuevo.UseVisualStyleBackColor = true;
            this.btoNuevo.Click += new System.EventHandler(this.btoNuevo_Click);
            // 
            // btoGrabar
            // 
            this.btoGrabar.Location = new System.Drawing.Point(72, 440);
            this.btoGrabar.Name = "btoGrabar";
            this.btoGrabar.Size = new System.Drawing.Size(75, 23);
            this.btoGrabar.TabIndex = 2;
            this.btoGrabar.Text = "Grabar";
            this.btoGrabar.UseVisualStyleBackColor = true;
            this.btoGrabar.Click += new System.EventHandler(this.btoGrabar_Click);
            // 
            // btoConsultar
            // 
            this.btoConsultar.Location = new System.Drawing.Point(271, 362);
            this.btoConsultar.Name = "btoConsultar";
            this.btoConsultar.Size = new System.Drawing.Size(75, 23);
            this.btoConsultar.TabIndex = 4;
            this.btoConsultar.Text = "Consultar";
            this.btoConsultar.UseVisualStyleBackColor = true;
            this.btoConsultar.Click += new System.EventHandler(this.btoConsultar_Click);
            // 
            // dgvPacienteMascota
            // 
            this.dgvPacienteMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienteMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.NombreCliente,
            this.NombreMascota,
            this.Raza,
            this.Genero,
            this.Edad});
            this.dgvPacienteMascota.Location = new System.Drawing.Point(717, 76);
            this.dgvPacienteMascota.Name = "dgvPacienteMascota";
            this.dgvPacienteMascota.RowHeadersWidth = 51;
            this.dgvPacienteMascota.RowTemplate.Height = 24;
            this.dgvPacienteMascota.Size = new System.Drawing.Size(654, 264);
            this.dgvPacienteMascota.TabIndex = 6;
            this.dgvPacienteMascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacienteMascota_CellContentClick);
            // 
            // IdPaciente
            // 
            this.IdPaciente.HeaderText = "IdPaciente";
            this.IdPaciente.MinimumWidth = 6;
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.Width = 125;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "NombreCliente";
            this.NombreCliente.MinimumWidth = 6;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Width = 125;
            // 
            // NombreMascota
            // 
            this.NombreMascota.HeaderText = "NombreMascota";
            this.NombreMascota.MinimumWidth = 6;
            this.NombreMascota.Name = "NombreMascota";
            this.NombreMascota.Width = 125;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.MinimumWidth = 6;
            this.Raza.Name = "Raza";
            this.Raza.Width = 125;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 125;
            // 
            // btoSalir
            // 
            this.btoSalir.Location = new System.Drawing.Point(271, 440);
            this.btoSalir.Name = "btoSalir";
            this.btoSalir.Size = new System.Drawing.Size(75, 23);
            this.btoSalir.TabIndex = 7;
            this.btoSalir.Text = "Salir";
            this.btoSalir.UseVisualStyleBackColor = true;
            this.btoSalir.Click += new System.EventHandler(this.btoSalir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1164, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(787, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 74);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Id Categoria";
            // 
            // button1
            // 
            this.button1.Enabled = false;
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
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(133, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Paciente_Mascota_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1413, 610);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btoSalir);
            this.Controls.Add(this.dgvPacienteMascota);
            this.Controls.Add(this.btoConsultar);
            this.Controls.Add(this.btoGrabar);
            this.Controls.Add(this.btoNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Paciente_Mascota_";
            this.Text = "Paciente_Mascota_";
            this.Load += new System.EventHandler(this.Paciente_Mascota__Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteMascota)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btoNuevo;
        private System.Windows.Forms.Button btoGrabar;
        private System.Windows.Forms.Button btoConsultar;
        private System.Windows.Forms.DataGridView dgvPacienteMascota;
        private System.Windows.Forms.Button btoSalir;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.ComboBox cboIdCliente;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}