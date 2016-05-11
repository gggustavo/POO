namespace Concesionaria
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.agregar = new System.Windows.Forms.Button();
            this.marca = new System.Windows.Forms.TextBox();
            this.modelo = new System.Windows.Forms.TextBox();
            this.patente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.capacidadTanque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rendimiento = new System.Windows.Forms.TextBox();
            this.combustibleActual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadTanqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendimientoLitroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantCombActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilomentrosConCapacidadActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilomentroTanqueLlenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actualizar = new System.Windows.Forms.Button();
            this.rbdescontar = new System.Windows.Forms.RadioButton();
            this.rbrecargar = new System.Windows.Forms.RadioButton();
            this.ingresoValor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 232);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(107, 29);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(114, 18);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(100, 20);
            this.marca.TabIndex = 1;
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(114, 51);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(100, 20);
            this.modelo.TabIndex = 2;
            // 
            // patente
            // 
            this.patente.Location = new System.Drawing.Point(114, 86);
            this.patente.Name = "patente";
            this.patente.Size = new System.Drawing.Size(100, 20);
            this.patente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pantente";
            // 
            // capacidadTanque
            // 
            this.capacidadTanque.Location = new System.Drawing.Point(114, 120);
            this.capacidadTanque.Name = "capacidadTanque";
            this.capacidadTanque.Size = new System.Drawing.Size(100, 20);
            this.capacidadTanque.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capacidad Tanque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rendimiento";
            // 
            // rendimiento
            // 
            this.rendimiento.Location = new System.Drawing.Point(114, 150);
            this.rendimiento.Name = "rendimiento";
            this.rendimiento.Size = new System.Drawing.Size(100, 20);
            this.rendimiento.TabIndex = 9;
            // 
            // combustibleActual
            // 
            this.combustibleActual.Location = new System.Drawing.Point(114, 180);
            this.combustibleActual.Name = "combustibleActual";
            this.combustibleActual.Size = new System.Drawing.Size(100, 20);
            this.combustibleActual.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Combustible";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combustibleActual);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.marca);
            this.groupBox1.Controls.Add(this.modelo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.patente);
            this.groupBox1.Controls.Add(this.rendimiento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.capacidadTanque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.patenteDataGridViewTextBoxColumn,
            this.capacidadTanqueDataGridViewTextBoxColumn,
            this.rendimientoLitroDataGridViewTextBoxColumn,
            this.cantCombActualDataGridViewTextBoxColumn,
            this.kilomentrosConCapacidadActualDataGridViewTextBoxColumn,
            this.kilomentroTanqueLlenoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(261, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 325);
            this.dataGridView1.TabIndex = 14;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            this.patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            this.patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            this.patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            // 
            // capacidadTanqueDataGridViewTextBoxColumn
            // 
            this.capacidadTanqueDataGridViewTextBoxColumn.DataPropertyName = "CapacidadTanque";
            this.capacidadTanqueDataGridViewTextBoxColumn.HeaderText = "CapacidadTanque";
            this.capacidadTanqueDataGridViewTextBoxColumn.Name = "capacidadTanqueDataGridViewTextBoxColumn";
            // 
            // rendimientoLitroDataGridViewTextBoxColumn
            // 
            this.rendimientoLitroDataGridViewTextBoxColumn.DataPropertyName = "RendimientoLitro";
            this.rendimientoLitroDataGridViewTextBoxColumn.HeaderText = "RendimientoLitro";
            this.rendimientoLitroDataGridViewTextBoxColumn.Name = "rendimientoLitroDataGridViewTextBoxColumn";
            // 
            // cantCombActualDataGridViewTextBoxColumn
            // 
            this.cantCombActualDataGridViewTextBoxColumn.DataPropertyName = "CantCombActual";
            this.cantCombActualDataGridViewTextBoxColumn.HeaderText = "CantCombActual";
            this.cantCombActualDataGridViewTextBoxColumn.Name = "cantCombActualDataGridViewTextBoxColumn";
            // 
            // kilomentrosConCapacidadActualDataGridViewTextBoxColumn
            // 
            this.kilomentrosConCapacidadActualDataGridViewTextBoxColumn.DataPropertyName = "KilomentrosConCapacidadActual";
            this.kilomentrosConCapacidadActualDataGridViewTextBoxColumn.HeaderText = "KilomentrosConCapacidadActual";
            this.kilomentrosConCapacidadActualDataGridViewTextBoxColumn.Name = "kilomentrosConCapacidadActualDataGridViewTextBoxColumn";
            this.kilomentrosConCapacidadActualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kilomentroTanqueLlenoDataGridViewTextBoxColumn
            // 
            this.kilomentroTanqueLlenoDataGridViewTextBoxColumn.DataPropertyName = "KilomentroTanqueLleno";
            this.kilomentroTanqueLlenoDataGridViewTextBoxColumn.HeaderText = "KilomentroTanqueLleno";
            this.kilomentroTanqueLlenoDataGridViewTextBoxColumn.Name = "kilomentroTanqueLlenoDataGridViewTextBoxColumn";
            this.kilomentroTanqueLlenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataSource = typeof(Auto);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(104, 295);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(137, 28);
            this.actualizar.TabIndex = 15;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // rbdescontar
            // 
            this.rbdescontar.AutoSize = true;
            this.rbdescontar.Location = new System.Drawing.Point(21, 300);
            this.rbdescontar.Name = "rbdescontar";
            this.rbdescontar.Size = new System.Drawing.Size(74, 17);
            this.rbdescontar.TabIndex = 16;
            this.rbdescontar.TabStop = true;
            this.rbdescontar.Text = "Descontar";
            this.rbdescontar.UseVisualStyleBackColor = true;
            // 
            // rbrecargar
            // 
            this.rbrecargar.AutoSize = true;
            this.rbrecargar.Location = new System.Drawing.Point(21, 329);
            this.rbrecargar.Name = "rbrecargar";
            this.rbrecargar.Size = new System.Drawing.Size(69, 17);
            this.rbrecargar.TabIndex = 17;
            this.rbrecargar.TabStop = true;
            this.rbrecargar.Text = "Recargar";
            this.rbrecargar.UseVisualStyleBackColor = true;
            // 
            // ingresoValor
            // 
            this.ingresoValor.Location = new System.Drawing.Point(105, 326);
            this.ingresoValor.Name = "ingresoValor";
            this.ingresoValor.Size = new System.Drawing.Size(136, 20);
            this.ingresoValor.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(15, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 3);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(126, 233);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(115, 29);
            this.eliminar.TabIndex = 20;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 363);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ingresoValor);
            this.Controls.Add(this.rbrecargar);
            this.Controls.Add(this.rbdescontar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.agregar);
            this.Name = "Main";
            this.Text = "Concesionaria";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.TextBox patente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox capacidadTanque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rendimiento;
        private System.Windows.Forms.TextBox combustibleActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.RadioButton rbdescontar;
        private System.Windows.Forms.RadioButton rbrecargar;
        private System.Windows.Forms.TextBox ingresoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadTanqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendimientoLitroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantCombActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilomentrosConCapacidadActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilomentroTanqueLlenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button eliminar;
    }
}

