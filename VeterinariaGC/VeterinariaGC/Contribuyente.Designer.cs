namespace VeterinariaGC
{
    partial class Contribuyente
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtIdContribuyente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btoNuevo = new System.Windows.Forms.Button();
            this.btoConsultar = new System.Windows.Forms.Button();
            this.btoGrabar = new System.Windows.Forms.Button();
            this.btoSalir = new System.Windows.Forms.Button();
            this.dgvContribuyente = new System.Windows.Forms.DataGridView();
            this.IdContribuyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtRFC);
            this.groupBox1.Controls.Add(this.txtIdContribuyente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(440, 51);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(440, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(156, 185);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(100, 22);
            this.txtRFC.TabIndex = 6;
            // 
            // txtIdContribuyente
            // 
            this.txtIdContribuyente.Enabled = false;
            this.txtIdContribuyente.Location = new System.Drawing.Point(156, 51);
            this.txtIdContribuyente.Name = "txtIdContribuyente";
            this.txtIdContribuyente.Size = new System.Drawing.Size(100, 22);
            this.txtIdContribuyente.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Contribuyente";
            // 
            // btoNuevo
            // 
            this.btoNuevo.Location = new System.Drawing.Point(82, 391);
            this.btoNuevo.Name = "btoNuevo";
            this.btoNuevo.Size = new System.Drawing.Size(75, 23);
            this.btoNuevo.TabIndex = 1;
            this.btoNuevo.Text = "Nuevo";
            this.btoNuevo.UseVisualStyleBackColor = true;
            this.btoNuevo.Click += new System.EventHandler(this.btoNuevo_Click);
            // 
            // btoConsultar
            // 
            this.btoConsultar.Location = new System.Drawing.Point(349, 487);
            this.btoConsultar.Name = "btoConsultar";
            this.btoConsultar.Size = new System.Drawing.Size(75, 23);
            this.btoConsultar.TabIndex = 3;
            this.btoConsultar.Text = "Consultar";
            this.btoConsultar.UseVisualStyleBackColor = true;
            this.btoConsultar.Click += new System.EventHandler(this.btoConsultar_Click);
            // 
            // btoGrabar
            // 
            this.btoGrabar.Location = new System.Drawing.Point(82, 487);
            this.btoGrabar.Name = "btoGrabar";
            this.btoGrabar.Size = new System.Drawing.Size(75, 23);
            this.btoGrabar.TabIndex = 4;
            this.btoGrabar.Text = "Grabar";
            this.btoGrabar.UseVisualStyleBackColor = true;
            this.btoGrabar.Click += new System.EventHandler(this.btoGrabar_Click);
            // 
            // btoSalir
            // 
            this.btoSalir.Location = new System.Drawing.Point(349, 391);
            this.btoSalir.Name = "btoSalir";
            this.btoSalir.Size = new System.Drawing.Size(75, 23);
            this.btoSalir.TabIndex = 6;
            this.btoSalir.Text = "Salir";
            this.btoSalir.UseVisualStyleBackColor = true;
            this.btoSalir.Click += new System.EventHandler(this.btoSalir_Click);
            // 
            // dgvContribuyente
            // 
            this.dgvContribuyente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContribuyente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdContribuyente,
            this.Nombre,
            this.RFC,
            this.Telefono,
            this.Email});
            this.dgvContribuyente.Location = new System.Drawing.Point(716, 65);
            this.dgvContribuyente.Name = "dgvContribuyente";
            this.dgvContribuyente.RowHeadersWidth = 51;
            this.dgvContribuyente.RowTemplate.Height = 24;
            this.dgvContribuyente.Size = new System.Drawing.Size(652, 297);
            this.dgvContribuyente.TabIndex = 7;
            // 
            // IdContribuyente
            // 
            this.IdContribuyente.HeaderText = "IdContribuyente";
            this.IdContribuyente.MinimumWidth = 6;
            this.IdContribuyente.Name = "IdContribuyente";
            this.IdContribuyente.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.MinimumWidth = 6;
            this.RFC.Name = "RFC";
            this.RFC.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1205, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(828, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 74);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Id Categoria";
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
            // Contribuyente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1399, 638);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvContribuyente);
            this.Controls.Add(this.btoSalir);
            this.Controls.Add(this.btoGrabar);
            this.Controls.Add(this.btoConsultar);
            this.Controls.Add(this.btoNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Contribuyente";
            this.Text = "Contribuyente";
            this.Load += new System.EventHandler(this.Contribuyente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContribuyente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btoNuevo;
        private System.Windows.Forms.Button btoConsultar;
        private System.Windows.Forms.Button btoGrabar;
        private System.Windows.Forms.Button btoSalir;
        private System.Windows.Forms.DataGridView dgvContribuyente;
        private System.Windows.Forms.TextBox txtIdContribuyente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}