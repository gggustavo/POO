namespace Inmobiliaria
{
    partial class Departamentos
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
            this.dgDepartamentos = new System.Windows.Forms.DataGridView();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.GroupBox();
            this.superficie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.piso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.habitaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cochera = new System.Windows.Forms.CheckBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartamentos)).BeginInit();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDepartamentos
            // 
            this.dgDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartamentos.Location = new System.Drawing.Point(12, 192);
            this.dgDepartamentos.Name = "dgDepartamentos";
            this.dgDepartamentos.Size = new System.Drawing.Size(650, 251);
            this.dgDepartamentos.TabIndex = 4;
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(174, 163);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 2;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(93, 163);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 1;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 163);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.superficie);
            this.Info.Controls.Add(this.label5);
            this.Info.Controls.Add(this.piso);
            this.Info.Controls.Add(this.label4);
            this.Info.Controls.Add(this.numero);
            this.Info.Controls.Add(this.label3);
            this.Info.Controls.Add(this.habitaciones);
            this.Info.Controls.Add(this.label1);
            this.Info.Controls.Add(this.cochera);
            this.Info.Controls.Add(this.domicilio);
            this.Info.Controls.Add(this.label2);
            this.Info.Location = new System.Drawing.Point(12, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(650, 145);
            this.Info.TabIndex = 18;
            this.Info.TabStop = false;
            this.Info.Text = "Información";
            // 
            // superficie
            // 
            this.superficie.Location = new System.Drawing.Point(410, 87);
            this.superficie.Name = "superficie";
            this.superficie.Size = new System.Drawing.Size(53, 20);
            this.superficie.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Superficie";
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(410, 61);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(53, 20);
            this.piso.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Piso";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(111, 87);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(53, 20);
            this.numero.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero";
            // 
            // habitaciones
            // 
            this.habitaciones.Location = new System.Drawing.Point(111, 61);
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.Size = new System.Drawing.Size(53, 20);
            this.habitaciones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Habitaciones";
            // 
            // cochera
            // 
            this.cochera.AutoSize = true;
            this.cochera.Location = new System.Drawing.Point(111, 113);
            this.cochera.Name = "cochera";
            this.cochera.Size = new System.Drawing.Size(66, 17);
            this.cochera.TabIndex = 5;
            this.cochera.Text = "Cochera";
            this.cochera.UseVisualStyleBackColor = true;
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(111, 35);
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(352, 20);
            this.domicilio.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domicilio";
            // 
            // confirmar
            // 
            this.confirmar.Enabled = false;
            this.confirmar.Location = new System.Drawing.Point(255, 163);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 3;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 453);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.dgDepartamentos);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.Info);
            this.Name = "Departamentos";
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartamentos)).EndInit();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDepartamentos;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cochera;
        private System.Windows.Forms.TextBox superficie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox habitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmar;
    }
}