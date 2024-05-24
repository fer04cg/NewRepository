namespace VeterinariaGC
{
    partial class Recetas
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdReceta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btoSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIndicaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPadecimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTratamientos = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvRecetasRegistrar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRegistrar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetasRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtIdReceta);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(243, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 127);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Id Receta";
            // 
            // txtIdReceta
            // 
            this.txtIdReceta.Location = new System.Drawing.Point(129, 27);
            this.txtIdReceta.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdReceta.Name = "txtIdReceta";
            this.txtIdReceta.Size = new System.Drawing.Size(132, 22);
            this.txtIdReceta.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 36;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btoSalir
            // 
            this.btoSalir.Location = new System.Drawing.Point(607, 677);
            this.btoSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btoSalir.Name = "btoSalir";
            this.btoSalir.Size = new System.Drawing.Size(100, 28);
            this.btoSalir.TabIndex = 37;
            this.btoSalir.Text = "Salir";
            this.btoSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMedicamentos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtIndicaciones);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(581, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(770, 221);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Medicamento";
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.Location = new System.Drawing.Point(125, 23);
            this.txtMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicamentos.Multiline = true;
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(436, 88);
            this.txtMedicamentos.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medicamento";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIndicaciones
            // 
            this.txtIndicaciones.Location = new System.Drawing.Point(125, 132);
            this.txtIndicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndicaciones.Multiline = true;
            this.txtIndicaciones.Name = "txtIndicaciones";
            this.txtIndicaciones.Size = new System.Drawing.Size(594, 72);
            this.txtIndicaciones.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Indicaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtPadecimiento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIdCita);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSintomas);
            this.groupBox1.Controls.Add(this.cboPaciente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTratamientos);
            this.groupBox1.Location = new System.Drawing.Point(967, 308);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(309, 369);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Paciente";
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(134, 319);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(132, 22);
            this.txtHora.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(61, 325);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Hora";
            // 
            // txtPadecimiento
            // 
            this.txtPadecimiento.Enabled = false;
            this.txtPadecimiento.Location = new System.Drawing.Point(134, 259);
            this.txtPadecimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtPadecimiento.Name = "txtPadecimiento";
            this.txtPadecimiento.Size = new System.Drawing.Size(132, 22);
            this.txtPadecimiento.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Padecimiento";
            // 
            // txtIdCita
            // 
            this.txtIdCita.Location = new System.Drawing.Point(134, 73);
            this.txtIdCita.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.Size = new System.Drawing.Size(132, 22);
            this.txtIdCita.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tramientos";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Enabled = false;
            this.txtSintomas.Location = new System.Drawing.Point(134, 197);
            this.txtSintomas.Margin = new System.Windows.Forms.Padding(4);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(132, 22);
            this.txtSintomas.TabIndex = 41;
            // 
            // cboPaciente
            // 
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(134, 23);
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(121, 24);
            this.cboPaciente.TabIndex = 12;
            this.cboPaciente.SelectedIndexChanged += new System.EventHandler(this.cboPaciente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Historial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Id Cita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sintomas";
            // 
            // txtTratamientos
            // 
            this.txtTratamientos.Location = new System.Drawing.Point(134, 127);
            this.txtTratamientos.Margin = new System.Windows.Forms.Padding(4);
            this.txtTratamientos.Name = "txtTratamientos";
            this.txtTratamientos.Size = new System.Drawing.Size(132, 22);
            this.txtTratamientos.TabIndex = 23;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(1086, 14);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 33;
            // 
            // dgvRecetasRegistrar
            // 
            this.dgvRecetasRegistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetasRegistrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicamento,
            this.Indicaciones});
            this.dgvRecetasRegistrar.Location = new System.Drawing.Point(94, 283);
            this.dgvRecetasRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecetasRegistrar.Name = "dgvRecetasRegistrar";
            this.dgvRecetasRegistrar.RowHeadersWidth = 51;
            this.dgvRecetasRegistrar.Size = new System.Drawing.Size(777, 341);
            this.dgvRecetasRegistrar.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Recetas";
            // 
            // Medicamento
            // 
            this.Medicamento.HeaderText = "Medicamento";
            this.Medicamento.MinimumWidth = 6;
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.Width = 250;
            // 
            // Indicaciones
            // 
            this.Indicaciones.HeaderText = "Indicaciones";
            this.Indicaciones.MinimumWidth = 6;
            this.Indicaciones.Name = "Indicaciones";
            this.Indicaciones.Width = 250;
            // 
            // txtRegistrar
            // 
            this.txtRegistrar.Location = new System.Drawing.Point(243, 677);
            this.txtRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.Size = new System.Drawing.Size(100, 28);
            this.txtRegistrar.TabIndex = 18;
            this.txtRegistrar.Text = "Registrar";
            this.txtRegistrar.UseVisualStyleBackColor = true;
            this.txtRegistrar.Click += new System.EventHandler(this.txtRegistrar_Click);
            // 
            // Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1413, 719);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btoSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvRecetasRegistrar);
            this.Controls.Add(this.label1);
            this.Name = "Recetas";
            this.Text = "Recetas";
            this.Load += new System.EventHandler(this.Recetas_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetasRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdReceta;
        private System.Windows.Forms.Button btoSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvRecetasRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.TextBox txtTratamientos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPadecimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicaciones;
        private System.Windows.Forms.Button txtRegistrar;
    }
}