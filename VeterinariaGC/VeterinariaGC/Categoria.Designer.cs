namespace VeterinariaGC
{
    partial class Categoria
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
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btoNuevo = new System.Windows.Forms.Button();
            this.boSalir = new System.Windows.Forms.Button();
            this.btoGrabar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoConsultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(85, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(195, 124);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(100, 22);
            this.txtConcepto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Concepto";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Enabled = false;
            this.txtIdCategoria.Location = new System.Drawing.Point(195, 39);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(100, 22);
            this.txtIdCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Categoria";
            // 
            // btoNuevo
            // 
            this.btoNuevo.Location = new System.Drawing.Point(85, 333);
            this.btoNuevo.Name = "btoNuevo";
            this.btoNuevo.Size = new System.Drawing.Size(75, 23);
            this.btoNuevo.TabIndex = 1;
            this.btoNuevo.Text = "Nuevo";
            this.btoNuevo.UseVisualStyleBackColor = true;
            this.btoNuevo.Click += new System.EventHandler(this.btoNuevo_Click);
            // 
            // boSalir
            // 
            this.boSalir.Location = new System.Drawing.Point(439, 420);
            this.boSalir.Name = "boSalir";
            this.boSalir.Size = new System.Drawing.Size(75, 23);
            this.boSalir.TabIndex = 2;
            this.boSalir.Text = "Salir";
            this.boSalir.UseVisualStyleBackColor = true;
            this.boSalir.Click += new System.EventHandler(this.boSalir_Click);
            // 
            // btoGrabar
            // 
            this.btoGrabar.Location = new System.Drawing.Point(439, 333);
            this.btoGrabar.Name = "btoGrabar";
            this.btoGrabar.Size = new System.Drawing.Size(75, 23);
            this.btoGrabar.TabIndex = 3;
            this.btoGrabar.Text = "Grabar";
            this.btoGrabar.UseVisualStyleBackColor = true;
            this.btoGrabar.Click += new System.EventHandler(this.btoGrabar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Concepto});
            this.dataGridView1.Location = new System.Drawing.Point(791, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(376, 278);
            this.dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.Width = 125;
            // 
            // btoConsultar
            // 
            this.btoConsultar.Location = new System.Drawing.Point(85, 420);
            this.btoConsultar.Name = "btoConsultar";
            this.btoConsultar.Size = new System.Drawing.Size(75, 23);
            this.btoConsultar.TabIndex = 5;
            this.btoConsultar.Text = "Consultar";
            this.btoConsultar.UseVisualStyleBackColor = true;
            this.btoConsultar.Click += new System.EventHandler(this.btoConsultar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(133, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id Categoria";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(791, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 74);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1205, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1432, 558);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btoConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btoGrabar);
            this.Controls.Add(this.boSalir);
            this.Controls.Add(this.btoNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btoNuevo;
        private System.Windows.Forms.Button boSalir;
        private System.Windows.Forms.Button btoGrabar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btoConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
    }
}