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
            var client = new RestClient(url);
            var request = new RestRequest($"products/{id}", Method.Get);
            Productos producto = client.Get<Productos>(request);
            producto.id = int.Parse(tbIdCrear.Text);
            producto.price= decimal.Parse(tbPriceCrear.Text);
            producto.title = tbTitleCrear.Text;
            producto.description= tbDescriptionCrear.Text;
            producto.category= tbCategoryCrear.Text;
            InitializeComponent();
        }

        void GrabarProducto(Productos prod)
        {
            var client= new RestClient(url);
            var request = new RestRequest("",Method.Post);
            request.AddJsonBody(prod);

            var producto = client.Post(request);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            Productos prod=new Productos();
            prod.id=int.Parse(tbIdCrear.Text);
            prod.price = decimal.Parse(tbPriceCrear.Text);
            prod.title = tbTitleCrear.Text;
            prod.description = tbDescriptionCrear.Text;
            prod.category = tbCategoryCrear.Text;
            MessageBox.Show("Se agrego correctamente el producto");

        }

        private void FormCrear_Load(object sender, EventArgs e)
        {

        }
    }
}
