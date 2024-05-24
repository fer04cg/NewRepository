namespace VeterinariaGC
{
    partial class gbCitas
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
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbRegistrar = new System.Windows.Forms.GroupBox();
            this.cbRegistrar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtwCitas = new System.Windows.Forms.DataGridView();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCitasPaciente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.gbMedico = new System.Windows.Forms.GroupBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.cboNombreMedico = new System.Windows.Forms.ComboBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCita = new System.Windows.Forms.GroupBox();
            this.btoNuevo = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAtender = new System.Windows.Forms.GroupBox();
            this.cbAtender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbCancelar = new System.Windows.Forms.GroupBox();
            this.cbCancelar = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.atender = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtwCitas)).BeginInit();
            this.gbPaciente.SuspendLayout();
            this.gbMedico.SuspendLayout();
            this.gbCita.SuspendLayout();
            this.gbAtender.SuspendLayout();
            this.gbCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(779, 651);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(466, 651);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbRegistrar
            // 
            this.gbRegistrar.Controls.Add(this.cbRegistrar);
            this.gbRegistrar.Controls.Add(this.label10);
            this.gbRegistrar.Location = new System.Drawing.Point(1066, 321);
            this.gbRegistrar.Name = "gbRegistrar";
            this.gbRegistrar.Size = new System.Drawing.Size(300, 100);
            this.gbRegistrar.TabIndex = 14;
            this.gbRegistrar.TabStop = false;
            this.gbRegistrar.Text = "Registrar";
            // 
            // cbRegistrar
            // 
            this.cbRegistrar.FormattingEnabled = true;
            this.cbRegistrar.Location = new System.Drawing.Point(147, 43);
            this.cbRegistrar.Name = "cbRegistrar";
            this.cbRegistrar.Size = new System.Drawing.Size(121, 24);
            this.cbRegistrar.TabIndex = 13;
            this.cbRegistrar.SelectedIndexChanged += new System.EventHandler(this.cbRegistrar_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Horas Disponibles";
            // 
            // dtwCitas
            // 
            this.dtwCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCita,
            this.Medico,
            this.Paciente,
            this.Fecha,
            this.Hora,
            this.Estado});
            this.dtwCitas.Location = new System.Drawing.Point(59, 427);
            this.dtwCitas.Name = "dtwCitas";
            this.dtwCitas.RowHeadersWidth = 51;
            this.dtwCitas.RowTemplate.Height = 24;
            this.dtwCitas.Size = new System.Drawing.Size(886, 207);
            this.dtwCitas.TabIndex = 13;
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.txtTelefono);
            this.gbPaciente.Controls.Add(this.txtDireccion);
            this.gbPaciente.Controls.Add(this.label9);
            this.gbPaciente.Controls.Add(this.cboCitasPaciente);
            this.gbPaciente.Controls.Add(this.label8);
            this.gbPaciente.Controls.Add(this.label7);
            this.gbPaciente.Controls.Add(this.label6);
            this.gbPaciente.Controls.Add(this.label5);
            this.gbPaciente.Controls.Add(this.txtIdPaciente);
            this.gbPaciente.Controls.Add(this.txtIdCliente);
            this.gbPaciente.Controls.Add(this.txtMascota);
            this.gbPaciente.Controls.Add(this.txtPadecimiento);
            this.gbPaciente.Location = new System.Drawing.Point(403, 57);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Size = new System.Drawing.Size(596, 332);
            this.gbPaciente.TabIndex = 12;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Datos Paciente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(481, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(481, 180);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Paciente";
            // 
            // cboCitasPaciente
            // 
            this.cboCitasPaciente.FormattingEnabled = true;
            this.cboCitasPaciente.Location = new System.Drawing.Point(234, 98);
            this.cboCitasPaciente.Name = "cboCitasPaciente";
            this.cboCitasPaciente.Size = new System.Drawing.Size(121, 24);
            this.cboCitasPaciente.TabIndex = 10;
            this.cboCitasPaciente.SelectedIndexChanged += new System.EventHandler(this.cboCitasPaciente_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Padecimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mascota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Id Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Id Paciente";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(234, 40);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(100, 22);
            this.txtIdPaciente.TabIndex = 5;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(234, 153);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 22);
            this.txtIdCliente.TabIndex = 4;
            // 
            // txtMascota
            // 
            this.txtMascota.Location = new System.Drawing.Point(234, 209);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.Size = new System.Drawing.Size(100, 22);
            this.txtMascota.TabIndex = 3;
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Location = new System.Drawing.Point(230, 264);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(100, 22);
            this.txtPadecimiento.TabIndex = 2;
            // 
            // gbMedico
            // 
            this.gbMedico.Controls.Add(this.txtIdMedico);
            this.gbMedico.Controls.Add(this.cboNombreMedico);
            this.gbMedico.Controls.Add(this.txtCedula);
            this.gbMedico.Controls.Add(this.label4);
            this.gbMedico.Controls.Add(this.label3);
            this.gbMedico.Controls.Add(this.label2);
            this.gbMedico.Location = new System.Drawing.Point(1091, 35);
            this.gbMedico.Name = "gbMedico";
            this.gbMedico.Size = new System.Drawing.Size(275, 224);
            this.gbMedico.TabIndex = 11;
            this.gbMedico.TabStop = false;
            this.gbMedico.Text = "Datos Medico";
            this.gbMedico.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Location = new System.Drawing.Point(105, 39);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(100, 22);
            this.txtIdMedico.TabIndex = 14;
            // 
            // cboNombreMedico
            // 
            this.cboNombreMedico.FormattingEnabled = true;
            this.cboNombreMedico.Location = new System.Drawing.Point(105, 99);
            this.cboNombreMedico.Name = "cboNombreMedico";
            this.cboNombreMedico.Size = new System.Drawing.Size(121, 24);
            this.cboNombreMedico.TabIndex = 11;
            this.cboNombreMedico.SelectedIndexChanged += new System.EventHandler(this.cboNombreCliente_SelectedIndexChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(105, 173);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 22);
            this.txtCedula.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Medico";
            // 
            // gbCita
            // 
            this.gbCita.Controls.Add(this.dateTimePicker1);
            this.gbCita.Controls.Add(this.txtIdCita);
            this.gbCita.Controls.Add(this.label1);
            this.gbCita.Location = new System.Drawing.Point(37, 42);
            this.gbCita.Name = "gbCita";
            this.gbCita.Size = new System.Drawing.Size(309, 190);
            this.gbCita.TabIndex = 10;
            this.gbCita.TabStop = false;
            this.gbCita.Text = "Cita";
            // 
            // btoNuevo
            // 
            this.btoNuevo.Location = new System.Drawing.Point(143, 655);
            this.btoNuevo.Name = "btoNuevo";
            this.btoNuevo.Size = new System.Drawing.Size(75, 23);
            this.btoNuevo.TabIndex = 3;
            this.btoNuevo.Text = "Nuevo";
            this.btoNuevo.UseVisualStyleBackColor = true;
            this.btoNuevo.Click += new System.EventHandler(this.btoNuevo_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtIdCita
            // 
            this.txtIdCita.Location = new System.Drawing.Point(114, 28);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.Size = new System.Drawing.Size(100, 22);
            this.txtIdCita.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Cita";
            // 
            // gbAtender
            // 
            this.gbAtender.Controls.Add(this.button1);
            this.gbAtender.Controls.Add(this.cbAtender);
            this.gbAtender.Controls.Add(this.label11);
            this.gbAtender.Enabled = false;
            this.gbAtender.Location = new System.Drawing.Point(1054, 567);
            this.gbAtender.Name = "gbAtender";
            this.gbAtender.Size = new System.Drawing.Size(312, 113);
            this.gbAtender.TabIndex = 17;
            this.gbAtender.TabStop = false;
            this.gbAtender.Text = "Atender";
            // 
            // cbAtender
            // 
            this.cbAtender.FormattingEnabled = true;
            this.cbAtender.Location = new System.Drawing.Point(147, 43);
            this.cbAtender.Name = "cbAtender";
            this.cbAtender.Size = new System.Drawing.Size(121, 24);
            this.cbAtender.TabIndex = 13;
            this.cbAtender.SelectedIndexChanged += new System.EventHandler(this.cbAtender_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Atender";
            // 
            // gbCancelar
            // 
            this.gbCancelar.Controls.Add(this.cbCancelar);
            this.gbCancelar.Controls.Add(this.button2);
            this.gbCancelar.Controls.Add(this.label12);
            this.gbCancelar.Enabled = false;
            this.gbCancelar.Location = new System.Drawing.Point(1054, 427);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(312, 124);
            this.gbCancelar.TabIndex = 15;
            this.gbCancelar.TabStop = false;
            this.gbCancelar.Text = "Cancelar";
            // 
            // cbCancelar
            // 
            this.cbCancelar.FormattingEnabled = true;
            this.cbCancelar.Location = new System.Drawing.Point(147, 43);
            this.cbCancelar.Name = "cbCancelar";
            this.cbCancelar.Size = new System.Drawing.Size(121, 24);
            this.cbCancelar.TabIndex = 13;
            this.cbCancelar.SelectedIndexChanged += new System.EventHandler(this.cbCancelar_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cancelar";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(973, 446);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 18;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // atender
            // 
            this.atender.Location = new System.Drawing.Point(973, 588);
            this.atender.Name = "atender";
            this.atender.Size = new System.Drawing.Size(75, 23);
            this.atender.TabIndex = 19;
            this.atender.Text = "Atender";
            this.atender.UseVisualStyleBackColor = true;
            this.atender.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Atender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // IdCita
            // 
            this.IdCita.HeaderText = "IdCita";
            this.IdCita.MinimumWidth = 6;
            this.IdCita.Name = "IdCita";
            this.IdCita.Width = 80;
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
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 80;
            // 
            // gbCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1418, 692);
            this.Controls.Add(this.btoNuevo);
            this.Controls.Add(this.atender);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.gbCancelar);
            this.Controls.Add(this.gbAtender);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbRegistrar);
            this.Controls.Add(this.dtwCitas);
            this.Controls.Add(this.gbPaciente);
            this.Controls.Add(this.gbMedico);
            this.Controls.Add(this.gbCita);
            this.Name = "gbCitas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            this.gbRegistrar.ResumeLayout(false);
            this.gbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtwCitas)).EndInit();
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbMedico.ResumeLayout(false);
            this.gbMedico.PerformLayout();
            this.gbCita.ResumeLayout(false);
            this.gbCita.PerformLayout();
            this.gbAtender.ResumeLayout(false);
            this.gbAtender.PerformLayout();
            this.gbCancelar.ResumeLayout(false);
            this.gbCancelar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gbRegistrar;
        private System.Windows.Forms.ComboBox cbRegistrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtwCitas;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCitasPaciente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtMascota;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.GroupBox gbMedico;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.ComboBox cboNombreMedico;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCita;
        private System.Windows.Forms.Button btoNuevo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAtender;
        private System.Windows.Forms.ComboBox cbAtender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbCancelar;
        private System.Windows.Forms.ComboBox cbCancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button atender;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}