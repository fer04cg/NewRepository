namespace VeterinariaGC
{
    partial class Medico
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
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedico = new System.Windows.Forms.DataGridView();
            this.IdMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoSalir = new System.Windows.Forms.Button();
            this.btoGrabar = new System.Windows.Forms.Button();
            this.btoConsultar = new System.Windows.Forms.Button();
            this.btoNuevo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtIdMedico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(133, 212);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 22);
            this.txtCedula.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtIdMedico
            // 
            this.txtIdMedico.Enabled = false;
            this.txtIdMedico.Location = new System.Drawing.Point(133, 48);
            this.txtIdMedico.Name = "txtIdMedico";
            this.txtIdMedico.Size = new System.Drawing.Size(100, 22);
            this.txtIdMedico.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Medico";
            // 
            // dgvMedico
            // 
            this.dgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedico,
            this.Nombre,
            this.Cedula});
            this.dgvMedico.Location = new System.Drawing.Point(747, 65);
            this.dgvMedico.Name = "dgvMedico";
            this.dgvMedico.RowHeadersWidth = 51;
            this.dgvMedico.RowTemplate.Height = 24;
            this.dgvMedico.Size = new System.Drawing.Size(578, 223);
            this.dgvMedico.TabIndex = 1;
            // 
            // IdMedico
            // 
            this.IdMedico.HeaderText = "IdMedico";
            this.IdMedico.MinimumWidth = 6;
            this.IdMedico.Name = "IdMedico";
            this.IdMedico.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 125;
            // 
            // btoSalir
            // 
            this.btoSalir.Location = new System.Drawing.Point(486, 353);
            this.btoSalir.Name = "btoSalir";
            this.btoSalir.Size = new System.Drawing.Size(105, 23);
            this.btoSalir.TabIndex = 11;
            this.btoSalir.Text = "Salir";
            this.btoSalir.UseVisualStyleBackColor = true;
            this.btoSalir.Click += new System.EventHandler(this.btoSalir_Click);
            // 
            // btoGrabar
            // 
            this.btoGrabar.Location = new System.Drawing.Point(219, 449);
            this.btoGrabar.Name = "btoGrabar";
            this.btoGrabar.Size = new System.Drawing.Size(105, 23);
            this.btoGrabar.TabIndex = 9;
            this.btoGrabar.Text = "Grabar";
            this.btoGrabar.UseVisualStyleBackColor = true;
            this.btoGrabar.Click += new System.EventHandler(this.btoGrabar_Click);
            // 
            // btoConsultar
            // 
            this.btoConsultar.Location = new System.Drawing.Point(486, 449);
            this.btoConsultar.Name = "btoConsultar";
            this.btoConsultar.Size = new System.Drawing.Size(105, 23);
            this.btoConsultar.TabIndex = 8;
            this.btoConsultar.Text = "Consultar";
            this.btoConsultar.UseVisualStyleBackColor = true;
            this.btoConsultar.Click += new System.EventHandler(this.btoConsultar_Click);
            // 
            // btoNuevo
            // 
            this.btoNuevo.Location = new System.Drawing.Point(219, 353);
            this.btoNuevo.Name = "btoNuevo";
            this.btoNuevo.Size = new System.Drawing.Size(105, 23);
            this.btoNuevo.TabIndex = 7;
            this.btoNuevo.Text = "Nuevo";
            this.btoNuevo.UseVisualStyleBackColor = true;
            this.btoNuevo.Click += new System.EventHandler(this.btoNuevo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1273, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(896, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 74);
            this.groupBox2.TabIndex = 12;
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
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1403, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btoSalir);
            this.Controls.Add(this.btoGrabar);
            this.Controls.Add(this.btoConsultar);
            this.Controls.Add(this.btoNuevo);
            this.Controls.Add(this.dgvMedico);
            this.Controls.Add(this.groupBox1);
            this.Name = "Medico";
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.Medico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedico;
        private System.Windows.Forms.Button btoSalir;
        private System.Windows.Forms.Button btoGrabar;
        private System.Windows.Forms.Button btoConsultar;
        private System.Windows.Forms.Button btoNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}