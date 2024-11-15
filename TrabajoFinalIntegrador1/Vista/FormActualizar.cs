using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalIntegrador1
{
    public partial class FormActualizar : Form
    {
        string url = "https://fakestoreapi.com";
        private Productos produc;
        public FormActualizar(int id)
        {
            InitializeComponent();
            var client = new RestClient(url);
            var request = new RestRequest($"products/{id}", Method.Get);
            Productos producto = client.Get<Productos>(request);
            tbID.Text = producto.id.ToString();
            tbPrice.Text = producto.price.ToString();
            tbTitle.Text = producto.title;
            tbDescription.Text = producto.description;
            tbCategory.Text = producto.category;
        }
        void GuarProducto(Productos p)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{p.id}", Method.Put);
                request.AddJsonBody(p);
                var response = client.Put(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Se actualizó el producto correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar el producto: " + ex.Message);
            }
        }
        private void btActualizar_Click(object sender, EventArgs e)
        {

            Productos p =new Productos();
            {
                p.id = int.Parse(tbID.Text);
                p.price = decimal.Parse(tbPrice.Text);
                p.description = tbDescription.Text;
                p.title = tbTitle.Text;
            };
            GuarProducto(p);

        }
    }
}
