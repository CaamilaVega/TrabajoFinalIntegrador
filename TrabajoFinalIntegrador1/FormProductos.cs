using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalIntegrador1
{
    public partial class FormProductos : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        string url = "https://fakestoreapi.com";
        private Productos produc;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            FormCrear fCrear = new FormCrear();
            fCrear.ShowDialog();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            int id = (int)GrillaProductos.SelectedRows[0].Cells[0].Value;
            FormActualizar fActualizar = new FormActualizar(id);
            fActualizar.ShowDialog();


        }

        private void btConsumirApi_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<Productos> producto = client.Get<List<Productos>>(request);
            GrillaProductos.DataSource = producto;
        }


        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBuscarID.Text, out int productoId))
            {

                List<Productos> producto = new List<Productos>() { Productos.GetProductos(url, productoId) };
                GrillaProductos.DataSource = producto;
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Productos productosAPI = new Productos();
            switch (cbCategoria.Text)
            {
                case "Jewelery":
                    GrillaProductos.DataSource = productosAPI.FiltradoJewelery(url); break;
                case "Men's clothing":
                    GrillaProductos.DataSource = productosAPI.FiltradoMensclothing(url); break;
                case "Women's clothing":
                    GrillaProductos.DataSource = productosAPI.Filtradowomensclothing(url); break;
                case "Electronics":
                    GrillaProductos.DataSource = productosAPI.FiltradoElectronics(url); break;
                default:
                    GrillaProductos.DataSource = productosAPI.ProdAsc(url); break;
            }
        }

        private void cbOrdenar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbOrdenar.Text == "Descendente")
            {
                Productos productosAPI = new Productos();
                GrillaProductos.DataSource = productosAPI.ProdDesc(url);
            }
            else
            {
                Productos productosAPI = new Productos();
                GrillaProductos.DataSource = productosAPI.ProdAsc(url);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrillaProductos.SelectedRows.Count > 0)
                {
                    int id = (int)GrillaProductos.SelectedRows[0].Cells[0].Value;
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el producto?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        var client = new RestClient(url);
                        var request = new RestRequest($"products/{id}", Method.Delete);

                        var response = client.Execute(request);

                        if (response.IsSuccessful)
                        {
                            MessageBox.Show("Se eliminó el producto correctamente");
                            GrillaProductos.Rows.RemoveAt(GrillaProductos.SelectedRows[0].Index);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el producto: " + response.ErrorMessage);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó el producto");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para eliminar");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Excepcion en el método Delete");
                MessageBox.Show("Ocurrió un error al intentar eliminar el producto: " + ex.Message);
            }
        }
    }
}
