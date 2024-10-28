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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.GrillaProductos = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.btCrear = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btConsumirApi = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscarID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEliminar = new System.Windows.Forms.Button();
            this.lbNombrePagina = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaProductos
            // 
            this.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaProductos.Location = new System.Drawing.Point(0, 159);
            this.GrillaProductos.Name = "GrillaProductos";
            this.GrillaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaProductos.Size = new System.Drawing.Size(800, 291);
            this.GrillaProductos.TabIndex = 0;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Todas las categorias",
            "Electronics",
            "Jewelery",
            "Men\'s clothing",
            "Women\'s clothing"});
            this.cbCategoria.Location = new System.Drawing.Point(3, 19);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 1;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cbOrdenar.Location = new System.Drawing.Point(676, 19);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cbOrdenar.TabIndex = 2;
            this.cbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cbOrdenar_SelectedIndexChanged_1);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(25, 3);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(80, 13);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = "Filtrar Categoria";
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Location = new System.Drawing.Point(713, 3);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(45, 13);
            this.labelOrdenar.TabIndex = 4;
            this.labelOrdenar.Text = "Ordenar";
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.SystemColors.Window;
            this.btCrear.Image = ((System.Drawing.Image)(resources.GetObject("btCrear.Image")));
            this.btCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCrear.Location = new System.Drawing.Point(3, 49);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(91, 58);
            this.btCrear.TabIndex = 5;
            this.btCrear.Text = "         Crear ";
            this.btCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCrear.UseVisualStyleBackColor = false;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.BackColor = System.Drawing.SystemColors.Window;
            this.btActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btActualizar.Image")));
            this.btActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btActualizar.Location = new System.Drawing.Point(100, 51);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(90, 55);
            this.btActualizar.TabIndex = 6;
            this.btActualizar.Text = "Editar";
            this.btActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btConsumirApi
            // 
            this.btConsumirApi.Location = new System.Drawing.Point(637, 22);
            this.btConsumirApi.Name = "btConsumirApi";
            this.btConsumirApi.Size = new System.Drawing.Size(151, 55);
            this.btConsumirApi.TabIndex = 7;
            this.btConsumirApi.Text = "Mostrar Productos";
            this.btConsumirApi.UseVisualStyleBackColor = true;
            this.btConsumirApi.Click += new System.EventHandler(this.btConsumirApi_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(353, 14);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 37);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbBuscarID
            // 
            this.tbBuscarID.Location = new System.Drawing.Point(326, 69);
            this.tbBuscarID.Name = "tbBuscarID";
            this.tbBuscarID.Size = new System.Drawing.Size(153, 20);
            this.tbBuscarID.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEliminar);
            this.panel1.Controls.Add(this.btActualizar);
            this.panel1.Controls.Add(this.lbNombrePagina);
            this.panel1.Controls.Add(this.btCrear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btConsumirApi);
            this.panel1.Controls.Add(this.tbBuscarID);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 159);
            this.panel1.TabIndex = 10;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btEliminar.Image")));
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminar.Location = new System.Drawing.Point(196, 52);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(90, 55);
            this.btEliminar.TabIndex = 12;
            this.btEliminar.Text = "Borrar";
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lbNombrePagina
            // 
            this.lbNombrePagina.AutoSize = true;
            this.lbNombrePagina.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePagina.Location = new System.Drawing.Point(3, 8);
            this.lbNombrePagina.Name = "lbNombrePagina";
            this.lbNombrePagina.Size = new System.Drawing.Size(168, 43);
            this.lbNombrePagina.TabIndex = 11;
            this.lbNombrePagina.Text = "MVC Store";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCategoria);
            this.panel2.Controls.Add(this.cbCategoria);
            this.panel2.Controls.Add(this.cbOrdenar);
            this.panel2.Controls.Add(this.labelOrdenar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 10;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrillaProductos);
            this.Controls.Add(this.panel1);
            this.Name = "FormProductos";
            this.Text = "Trabajo Final Integrador";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscarID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNombrePagina;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btEliminar;
    }
}

