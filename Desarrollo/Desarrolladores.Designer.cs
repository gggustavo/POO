namespace Desarrollo
{
    partial class Desarrolladores
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
            this.Info = new System.Windows.Forms.GroupBox();
            this.costoxhora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.dgDesarrolladores = new System.Windows.Forms.DataGridView();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desarrolladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmar = new System.Windows.Forms.Button();
            this.Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesarrolladores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.Controls.Add(this.costoxhora);
            this.Info.Controls.Add(this.label4);
            this.Info.Controls.Add(this.email);
            this.Info.Controls.Add(this.label3);
            this.Info.Controls.Add(this.nombre);
            this.Info.Controls.Add(this.label2);
            this.Info.Controls.Add(this.documento);
            this.Info.Controls.Add(this.label1);
            this.Info.Location = new System.Drawing.Point(12, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(445, 154);
            this.Info.TabIndex = 0;
            this.Info.TabStop = false;
            this.Info.Text = "Información";
            // 
            // costoxhora
            // 
            this.costoxhora.Location = new System.Drawing.Point(114, 110);
            this.costoxhora.Name = "costoxhora";
            this.costoxhora.Size = new System.Drawing.Size(53, 20);
            this.costoxhora.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo Hora";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(114, 84);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(201, 20);
            this.email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(114, 58);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(201, 20);
            this.nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(114, 32);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(201, 20);
            this.documento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Documento";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 172);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 8;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(93, 172);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 9;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(174, 172);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 10;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // dgDesarrolladores
            // 
            this.dgDesarrolladores.AutoGenerateColumns = false;
            this.dgDesarrolladores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDesarrolladores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.costoHoraDataGridViewTextBoxColumn});
            this.dgDesarrolladores.DataSource = this.desarrolladorBindingSource;
            this.dgDesarrolladores.Location = new System.Drawing.Point(12, 201);
            this.dgDesarrolladores.Name = "dgDesarrolladores";
            this.dgDesarrolladores.Size = new System.Drawing.Size(445, 251);
            this.dgDesarrolladores.TabIndex = 11;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // costoHoraDataGridViewTextBoxColumn
            // 
            this.costoHoraDataGridViewTextBoxColumn.DataPropertyName = "CostoHora";
            this.costoHoraDataGridViewTextBoxColumn.HeaderText = "CostoHora";
            this.costoHoraDataGridViewTextBoxColumn.Name = "costoHoraDataGridViewTextBoxColumn";
            // 
            // desarrolladorBindingSource
            // 
            this.desarrolladorBindingSource.DataSource = typeof(Desarrollo.Desarrollador);
            // 
            // confirmar
            // 
            this.confirmar.Enabled = false;
            this.confirmar.Location = new System.Drawing.Point(255, 172);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 12;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // Desarrolladores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 464);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.dgDesarrolladores);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.Info);
            this.Name = "Desarrolladores";
            this.Text = "Desarrolladores";
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesarrolladores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.TextBox costoxhora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.DataGridView dgDesarrolladores;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource desarrolladorBindingSource;
        private System.Windows.Forms.Button confirmar;
    }
}