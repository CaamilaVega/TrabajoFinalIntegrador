using Negocio;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalIntegrador1
{
    public partial class FrmEditar : Form
    {
        string url = ConfigurationManager.AppSettings["urlApi"];
        private readonly FrmPrincipal formProductos;
        private ErrorProvider errorProvider = new ErrorProvider();

        public FrmEditar(int id, FrmPrincipal form)
        {
            InitializeComponent();
            formProductos = form;
            CargarProducto(id);
        }

        private void CargarProducto(int id)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{id}", Method.Get);
                var response = client.Execute<ProductosAPI>(request);
                if (response.IsSuccessful && response.Data != null)
                {
                    tbID.Text = response.Data.Id.ToString();
                    tbPrice.Text = response.Data.Price.ToString();
                    tbTitle.Text = response.Data.Title;
                    tbDescription.Text = response.Data.Description;
                    tbCategory.Text = response.Data.Category;
                }
                else
                {
                    MostrarError("Error al cargar el producto", response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MostrarError("Ocurrió un error al cargar el producto", ex.Message);
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarCampos())
            {
                var productoActualizado = new ProductosAPI
                {
                    Id = int.Parse(tbID.Text),
                    Price = decimal.Parse(tbPrice.Text),
                    Title = tbTitle.Text,
                    Description = tbDescription.Text,
                    Category = tbCategory.Text
                };
                GuarProducto(productoActualizado);
            }
            else
            {
                DialogResult result = MessageBox.Show("Algunos campos obligatorios están vacíos o no cumplen con los requisitos. ¿Querés cancelar la edición de producto?", "Error de validación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void GuarProducto(ProductosAPI producto)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{producto.Id}", Method.Put).AddJsonBody(producto);
                var response = client.Put(request);
                if (response.IsSuccessful)
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                    formProductos.ActualizarProductoEnGrilla(producto);
                    this.Close();
                }
                else
                {
                    MostrarError("Error al actualizar el producto", response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MostrarError("Ocurrió un error al intentar actualizar el producto", ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                errorProvider.SetError(tbTitle, "El título es obligatorio.");
                isValid = false;
            }
            if (!decimal.TryParse(tbPrice.Text, out decimal price) || price <= 0)
            {
                errorProvider.SetError(tbPrice, "El precio es obligatorio y debe ser mayor que 0.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(tbID.Text) || !int.TryParse(tbID.Text, out _))
            {
                errorProvider.SetError(tbID, "El ID es obligatorio y debe ser un número válido.");
                isValid = false;
            }
            return isValid;
        }

        private void MostrarError(string mensaje, string detalle)
        {
            MessageBox.Show($"{mensaje}: {detalle}");
            this.Close();
        }
    }
}