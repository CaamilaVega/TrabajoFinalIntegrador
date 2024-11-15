namespace TrabajoFinalIntegrador1
{
    partial class FormProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrillaProductos = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.btCrear = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btConsumirApi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaProductos
            // 
            this.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProductos.Location = new System.Drawing.Point(189, 64);
            this.GrillaProductos.Name = "GrillaProductos";
            this.GrillaProductos.Size = new System.Drawing.Size(364, 188);
            this.GrillaProductos.TabIndex = 0;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(189, 37);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 1;
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Location = new System.Drawing.Point(432, 37);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cbOrdenar.TabIndex = 2;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(186, 21);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(80, 13);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = "Filtrar Categoria";
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Location = new System.Drawing.Point(429, 21);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(45, 13);
            this.labelOrdenar.TabIndex = 4;
            this.labelOrdenar.Text = "Ordenar";
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(12, 54);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(121, 23);
            this.btCrear.TabIndex = 5;
            this.btCrear.Text = "Crear Producto";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(12, 83);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(121, 23);
            this.btActualizar.TabIndex = 6;
            this.btActualizar.Text = "Actualizar Producto";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btConsumirApi
            // 
            this.btConsumirApi.Location = new System.Drawing.Point(310, 269);
            this.btConsumirApi.Name = "btConsumirApi";
            this.btConsumirApi.Size = new System.Drawing.Size(113, 23);
            this.btConsumirApi.TabIndex = 7;
            this.btConsumirApi.Text = "Mostrar Productos";
            this.btConsumirApi.UseVisualStyleBackColor = true;
            this.btConsumirApi.Click += new System.EventHandler(this.btConsumirApi_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btConsumirApi);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.cbOrdenar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.GrillaProductos);
            this.Name = "FormProductos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaProductos;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btConsumirApi;
    }
}

