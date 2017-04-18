namespace Inmobiliaria
{
    partial class Localidades
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
            this.confirmar = new System.Windows.Forms.Button();
            this.dgLocalidades = new System.Windows.Forms.DataGridView();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.GroupBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalidades)).BeginInit();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmar
            // 
            this.confirmar.Enabled = false;
            this.confirmar.Location = new System.Drawing.Point(252, 107);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 18;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            // 
            // dgLocalidades
            // 
            this.dgLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocalidades.Location = new System.Drawing.Point(12, 156);
            this.dgLocalidades.Name = "dgLocalidades";
            this.dgLocalidades.Size = new System.Drawing.Size(445, 285);
            this.dgLocalidades.TabIndex = 17;
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(171, 107);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 16;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(90, 107);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 15;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(9, 107);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 14;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.nombre);
            this.Info.Controls.Add(this.label2);
            this.Info.Controls.Add(this.documento);
            this.Info.Controls.Add(this.label1);
            this.Info.Location = new System.Drawing.Point(12, 10);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(445, 91);
            this.Info.TabIndex = 13;
            this.Info.TabStop = false;
            this.Info.Text = "Información";
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
            this.documento.Size = new System.Drawing.Size(83, 20);
            this.documento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Postal";
            // 
            // Localidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.dgLocalidades);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.Info);
            this.Name = "Localidades";
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.Localidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocalidades)).EndInit();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.DataGridView dgLocalidades;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label label1;
    }
}