namespace TrabajoFinalIntegrador1
{
    partial class FrmCrear
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
            this.btCrearNuevo = new System.Windows.Forms.Button();
            this.lbTitleCrear = new System.Windows.Forms.Label();
            this.lbPriceCrear = new System.Windows.Forms.Label();
            this.lbCategoryCrear = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbTitleCrear = new System.Windows.Forms.TextBox();
            this.tbPriceCrear = new System.Windows.Forms.TextBox();
            this.tbCategoryCrear = new System.Windows.Forms.TextBox();
            this.tbDescriptionCrear = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIDCrear = new System.Windows.Forms.Label();
            this.tbIdCrear = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCrearNuevo
            // 
            this.btCrearNuevo.Location = new System.Drawing.Point(136, 14);
            this.btCrearNuevo.Name = "btCrearNuevo";
            this.btCrearNuevo.Size = new System.Drawing.Size(135, 33);
            this.btCrearNuevo.TabIndex = 0;
            this.btCrearNuevo.Text = "Crear";
            this.btCrearNuevo.UseVisualStyleBackColor = true;
            this.btCrearNuevo.Click += new System.EventHandler(this.btCrearNuevo_Click);
            // 
            // lbTitleCrear
            // 
            this.lbTitleCrear.AutoSize = true;
            this.lbTitleCrear.Location = new System.Drawing.Point(62, 93);
            this.lbTitleCrear.Name = "lbTitleCrear";
            this.lbTitleCrear.Size = new System.Drawing.Size(27, 13);
            this.lbTitleCrear.TabIndex = 2;
            this.lbTitleCrear.Text = "Title";
            // 
            // lbPriceCrear
            // 
            this.lbPriceCrear.AutoSize = true;
            this.lbPriceCrear.Location = new System.Drawing.Point(55, 119);
            this.lbPriceCrear.Name = "lbPriceCrear";
            this.lbPriceCrear.Size = new System.Drawing.Size(31, 13);
            this.lbPriceCrear.TabIndex = 3;
            this.lbPriceCrear.Text = "Price";
            // 
            // lbCategoryCrear
            // 
            this.lbCategoryCrear.AutoSize = true;
            this.lbCategoryCrear.Location = new System.Drawing.Point(55, 142);
            this.lbCategoryCrear.Name = "lbCategoryCrear";
            this.lbCategoryCrear.Size = new System.Drawing.Size(49, 13);
            this.lbCategoryCrear.TabIndex = 4;
            this.lbCategoryCrear.Text = "Category";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(55, 173);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 5;
            this.lbDescription.Text = "Description";
            // 
            // tbTitleCrear
            // 
            this.tbTitleCrear.Location = new System.Drawing.Point(121, 86);
            this.tbTitleCrear.Name = "tbTitleCrear";
            this.tbTitleCrear.Size = new System.Drawing.Size(180, 20);
            this.tbTitleCrear.TabIndex = 7;
            // 
            // tbPriceCrear
            // 
            this.tbPriceCrear.Location = new System.Drawing.Point(121, 112);
            this.tbPriceCrear.Name = "tbPriceCrear";
            this.tbPriceCrear.Size = new System.Drawing.Size(180, 20);
            this.tbPriceCrear.TabIndex = 8;
            // 
            // tbCategoryCrear
            // 
            this.tbCategoryCrear.Location = new System.Drawing.Point(121, 139);
            this.tbCategoryCrear.Name = "tbCategoryCrear";
            this.tbCategoryCrear.Size = new System.Drawing.Size(180, 20);
            this.tbCategoryCrear.TabIndex = 9;
            // 
            // tbDescriptionCrear
            // 
            this.tbDescriptionCrear.Location = new System.Drawing.Point(121, 170);
            this.tbDescriptionCrear.Name = "tbDescriptionCrear";
            this.tbDescriptionCrear.Size = new System.Drawing.Size(180, 20);
            this.tbDescriptionCrear.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDescriptionCrear);
            this.groupBox1.Controls.Add(this.tbCategoryCrear);
            this.groupBox1.Controls.Add(this.tbPriceCrear);
            this.groupBox1.Controls.Add(this.tbTitleCrear);
            this.groupBox1.Controls.Add(this.tbIdCrear);
            this.groupBox1.Controls.Add(this.lbDescription);
            this.groupBox1.Controls.Add(this.lbCategoryCrear);
            this.groupBox1.Controls.Add(this.lbPriceCrear);
            this.groupBox1.Controls.Add(this.lbTitleCrear);
            this.groupBox1.Controls.Add(this.lbIDCrear);
            this.groupBox1.Controls.Add(this.btCrearNuevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 238);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Producto";
            // 
            // lbIDCrear
            // 
            this.lbIDCrear.AutoSize = true;
            this.lbIDCrear.Location = new System.Drawing.Point(62, 67);
            this.lbIDCrear.Name = "lbIDCrear";
            this.lbIDCrear.Size = new System.Drawing.Size(16, 13);
            this.lbIDCrear.TabIndex = 1;
            this.lbIDCrear.Text = "Id";
            // 
            // tbIdCrear
            // 
            this.tbIdCrear.Location = new System.Drawing.Point(121, 60);
            this.tbIdCrear.Name = "tbIdCrear";
            this.tbIdCrear.Size = new System.Drawing.Size(180, 20);
            this.tbIdCrear.TabIndex = 6;
            // 
            // FormCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCrear";
            this.Text = "FormCrear";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCrearNuevo;
        private System.Windows.Forms.Label lbTitleCrear;
        private System.Windows.Forms.Label lbPriceCrear;
        private System.Windows.Forms.Label lbCategoryCrear;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbTitleCrear;
        private System.Windows.Forms.TextBox tbPriceCrear;
        private System.Windows.Forms.TextBox tbCategoryCrear;
        private System.Windows.Forms.TextBox tbDescriptionCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIdCrear;
        private System.Windows.Forms.Label lbIDCrear;
    }
}