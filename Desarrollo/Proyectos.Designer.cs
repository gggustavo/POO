namespace Desarrollo
{
    partial class Proyectos
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.desarrolladores = new System.Windows.Forms.ComboBox();
            this.desarrolladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadhora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.internacionales = new System.Windows.Forms.RadioButton();
            this.locales = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desarrolladorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agregar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.confirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.desarrolladores);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cantidadhora);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.internacionales);
            this.groupBox1.Controls.Add(this.locales);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // desarrolladores
            // 
            this.desarrolladores.DataSource = this.desarrolladorBindingSource;
            this.desarrolladores.DisplayMember = "Nombre";
            this.desarrolladores.FormattingEnabled = true;
            this.desarrolladores.Location = new System.Drawing.Point(99, 113);
            this.desarrolladores.Name = "desarrolladores";
            this.desarrolladores.Size = new System.Drawing.Size(276, 21);
            this.desarrolladores.TabIndex = 7;
            this.desarrolladores.ValueMember = "Documento";
            // 
            // desarrolladorBindingSource
            // 
            this.desarrolladorBindingSource.DataSource = typeof(Desarrollo.Desarrollador);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desarrollador";
            // 
            // cantidadhora
            // 
            this.cantidadhora.Location = new System.Drawing.Point(99, 87);
            this.cantidadhora.Name = "cantidadhora";
            this.cantidadhora.Size = new System.Drawing.Size(68, 20);
            this.cantidadhora.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad Horas";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(99, 58);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(276, 20);
            this.nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // internacionales
            // 
            this.internacionales.AutoSize = true;
            this.internacionales.Location = new System.Drawing.Point(99, 19);
            this.internacionales.Name = "internacionales";
            this.internacionales.Size = new System.Drawing.Size(97, 17);
            this.internacionales.TabIndex = 1;
            this.internacionales.TabStop = true;
            this.internacionales.Text = "Internacionales";
            this.internacionales.UseVisualStyleBackColor = true;
            // 
            // locales
            // 
            this.locales.AutoSize = true;
            this.locales.Location = new System.Drawing.Point(16, 19);
            this.locales.Name = "locales";
            this.locales.Size = new System.Drawing.Size(62, 17);
            this.locales.TabIndex = 0;
            this.locales.TabStop = true;
            this.locales.Text = "Locales";
            this.locales.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadHorasDataGridViewTextBoxColumn,
            this.desarrolladorDataGridViewTextBoxColumn,
            this.costoProyectoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proyectoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // cantidadHorasDataGridViewTextBoxColumn
            // 
            this.cantidadHorasDataGridViewTextBoxColumn.DataPropertyName = "CantidadHoras";
            this.cantidadHorasDataGridViewTextBoxColumn.HeaderText = "CantidadHoras";
            this.cantidadHorasDataGridViewTextBoxColumn.Name = "cantidadHorasDataGridViewTextBoxColumn";
            // 
            // desarrolladorDataGridViewTextBoxColumn
            // 
            this.desarrolladorDataGridViewTextBoxColumn.DataPropertyName = "Desarrollador";
            this.desarrolladorDataGridViewTextBoxColumn.HeaderText = "Desarrollador";
            this.desarrolladorDataGridViewTextBoxColumn.Name = "desarrolladorDataGridViewTextBoxColumn";
            // 
            // costoProyectoDataGridViewTextBoxColumn
            // 
            this.costoProyectoDataGridViewTextBoxColumn.DataPropertyName = "CostoProyecto";
            this.costoProyectoDataGridViewTextBoxColumn.HeaderText = "CostoProyecto";
            this.costoProyectoDataGridViewTextBoxColumn.Name = "costoProyectoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataSource = typeof(Desarrollo.Proyecto);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 165);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 2;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(104, 165);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(195, 165);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 4;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // confirmar
            // 
            this.confirmar.Enabled = false;
            this.confirmar.Location = new System.Drawing.Point(286, 165);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 5;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 467);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Proyectos";
            this.Text = "Proyectos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton internacionales;
        private System.Windows.Forms.RadioButton locales;
        private System.Windows.Forms.ComboBox desarrolladores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidadhora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.BindingSource desarrolladorBindingSource;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desarrolladorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
    }
}