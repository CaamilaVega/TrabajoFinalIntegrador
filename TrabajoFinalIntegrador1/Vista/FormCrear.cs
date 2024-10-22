using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalIntegrador1
{
    public partial class FormCrear : Form
    {
        string url = "https://fakestoreapi.com";
        private Productos produc;
        public FormCrear(int id)
        {
            InitializeComponent();
            var client = new RestClient(url);
            var request = new RestRequest($"products/{id}", Method.Post);
            Productos producto = client.Post<Productos>(request);

        }
        void GuarProducto(Productos p)
        {

            var client = new RestClient(url);
            var request = new RestRequest("products/1", Method.Post);
            request.AddJsonBody(p);

            var producto = client.Put(request);
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p.id = int.Parse(tbIdCrear.Text);
            p.price = decimal.Parse(tbPriceCrear.Text);
            p.description = tbDescriptionCrear.Text;
            p.title = tbTitleCrear.Text;
            GuarProducto(p);
            MessageBox.Show("Se creo el producto");

        }

      
    }
        
}
