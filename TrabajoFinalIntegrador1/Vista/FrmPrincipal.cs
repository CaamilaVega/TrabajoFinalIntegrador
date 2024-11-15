using Negocio;
using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalIntegrador1
{
    public partial class FrmPrincipal : Form
    {
        string url = ConfigurationManager.AppSettings["urlApi"];
        private ProductosAPI _prodAPI;
        public FrmPrincipal()
        {
            InitializeComponent();
            _prodAPI = new ProductosAPI();

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (GrillaProductos.SelectedRows.Count > 0)
            {
                int id = (int)GrillaProductos.SelectedRows[0].Cells["Id"].Value;
                FrmEditar fActualizar = new FrmEditar(id, this);
                fActualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar.");
            }
        }
        public void ActualizarProductoEnGrilla(ProductosAPI productoActualizado)
        {
            foreach (DataGridViewRow row in GrillaProductos.Rows)
            {
                if ((int)row.Cells["Id"].Value == productoActualizado.Id)
                {
                    row.Cells["Price"].Value = productoActualizado.Price;
                    row.Cells["Title"].Value = productoActualizado.Title;
                    row.Cells["Description"].Value = productoActualizado.Description;
                    row.Cells["Category"].Value = productoActualizado.Category;
                    break;
                }
            }
        }

        private void btConsumirApi_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<ProductosAPI> producto = client.Get<List<ProductosAPI>>(request);
            GrillaProductos.DataSource = producto;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBuscarID.Text, out int productId))
            {
                var producto = _prodAPI.GetProductosId(url, productId);
                if (producto != null)
                {
                    GrillaProductos.DataSource = new List<ProductosAPI> { producto };
                }
                else
                {
                    MessageBox.Show("No se encontro el producto, revise que el ID ingresado sea correcto");
                }
            }
            else
            {
                MessageBox.Show("En este campo únicamente pueden ingresarse números.");
            }
        }


        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductosAPI productos = new ProductosAPI();
            string categoriaSelec = cbCategoria.SelectedItem.ToString();
            if (categoriaSelec == "Todas las categorias")
            {
                List<ProductosAPI> prodApi = productos.GetProductos(url);
                GrillaProductos.DataSource = prodApi;
            }
            else
            {
                List<ProductosAPI> prodApi = productos.GetFiltrado(url, categoriaSelec);
                GrillaProductos.DataSource = prodApi;
            }

        }
        private void cbOrdenar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbOrdenar.Text == "Descendente")
            {
                ProductosAPI productos = new ProductosAPI();
                GrillaProductos.DataSource = productos.ProdDesc(url);
            }
            else
            {
                ProductosAPI productos = new ProductosAPI();
                GrillaProductos.DataSource = productos.ProdAsc(url);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void ActualizarGrilla()
        {
            GrillaProductos.DataSource = null;
            GrillaProductos.DataSource = new List<ProductosAPI> { _prodAPI };
        }

        private void btCrear_Click_1(object sender, EventArgs e)
        {
            using (FrmCrear fCrear = new FrmCrear())
            {
                if (fCrear.ShowDialog() == DialogResult.OK && fCrear.ProductoNuevo != null)
                {
                    var product = GrillaProductos.DataSource as List<ProductosAPI> ?? new List<ProductosAPI>();
                    product.Add(fCrear.ProductoNuevo);
                    GrillaProductos.DataSource = null;
                    GrillaProductos.DataSource = product;
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto");
                }
            }
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (GrillaProductos.CurrentRow == null || GrillaProductos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }
            var producto = GrillaProductos.CurrentRow.DataBoundItem as ProductosAPI;
            if (producto == null || producto.Id <= 0)
            {
                MessageBox.Show("Producto no válido para eliminación.");
                return;
            }
            var confirmResult = MessageBox.Show("¿Estás seguro de que queres eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    ProductosAPI productosApi = new ProductosAPI();
                    productosApi.EliminarProducto(producto, url);
                    MessageBox.Show("El producto se eliminó correctamente.");
                    var productosList = (List<ProductosAPI>)GrillaProductos.DataSource;
                    productosList.Remove(producto);
                    GrillaProductos.DataSource = null;
                    GrillaProductos.DataSource = productosList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
                }
            }
        }

        private void btLimitar_Click(object sender, EventArgs e)
        {

            if (int.TryParse(tbLimitar.Text, out int limite) && limite > 0)
            {

                var productosList = GrillaProductos.DataSource as List<ProductosAPI>;

                if (productosList != null && productosList.Any())
                {

                    if (limite > productosList.Count)
                    {
                        MessageBox.Show("El número ingresado no se encuentra en los ID disponibles.");
                    }

                    var productosLimitados = productosList.Take(limite).ToList();
                    GrillaProductos.DataSource = null;
                    GrillaProductos.DataSource = productosLimitados;
                }
                else
                {
                    MessageBox.Show("No hay productos disponibles para mostrar.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido mayor a 0.");
            }
        } 
    }
}
