namespace Final
{
    partial class Products
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
            this.calcular = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.SuspendLayout();
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(382, 335);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 0;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // product
            // 
            this.product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre});
            this.product.Location = new System.Drawing.Point(12, 12);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(445, 299);
            this.product.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "Key";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Value";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 300;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 381);
            this.Controls.Add(this.product);
            this.Controls.Add(this.calcular);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.DataGridView product;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}