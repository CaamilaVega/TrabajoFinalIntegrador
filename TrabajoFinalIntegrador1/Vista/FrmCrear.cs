using Negocio;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalIntegrador1
{ 
    public partial class FrmCrear : Form
    {
        string url = ConfigurationManager.AppSettings["urlApi"];
        public ProductosAPI ProductoNuevo;
        public FrmCrear()
        {
            InitializeComponent();
            tbIdCrear.Enabled = false;
            GenerarNuevoId();
        }
        private void GenerarNuevoId()
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products", Method.Get);
                var response = client.Execute<List<ProductosAPI>>(request);
                if (response.IsSuccessful && response.Data != null)
                {
                    int nuevoId = response.Data.Max(p => p.Id) + 1;
                    tbIdCrear.Text = nuevoId.ToString();
                }
                else
                {
                    MessageBox.Show("Error al obtener el Id, intente nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al obtener el Id: {ex.Message}");
            }
        }
        private void btCrearNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                var productoNuevo = new ProductosAPI
                {
                    Id = int.Parse(tbIdCrear.Text),
                    Title = tbTitleCrear.Text,
                    Price = decimal.Parse(tbPriceCrear.Text),
                    Category = tbCategoryCrear.Text,
                    Description = tbDescriptionCrear.Text,
                };
                ProductoNuevo = new ProductosAPI().CrearProducto(productoNuevo, url);
                MessageBox.Show("Producto agregado correctamente.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }
        }
        private bool ValidarCampos()
        {
            var campos = new Dictionary<string, TextBox>
            {
                { "Título", tbTitleCrear },
                { "Categoría", tbCategoryCrear },
                { "Descripción", tbDescriptionCrear }
            };
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Value.Text))
                {
                    MessageBox.Show($"Por favor, complete todos los campos.");
                    return false;
                }
            }
            if (string.IsNullOrWhiteSpace(tbPriceCrear.Text) || !decimal.TryParse(tbPriceCrear.Text, out decimal price))
            {
                MessageBox.Show("Por favor, ingrese un valor de precio mayor a cero.");
                return false;
            }
            if (price <= 0)
            {
                MessageBox.Show("Precio debe ser mayor a cero.");
                return false;
            }
            return true;
        }
    }
}
