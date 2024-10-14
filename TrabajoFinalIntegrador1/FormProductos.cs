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
        string url = "https://fakestoreapi.com";
        private Productos produc;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            int id=(int)GrillaProductos.SelectedRows[0].Cells[0].Value;
            FormCrear fCrear = new FormCrear(id);
            fCrear.ShowDialog();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            int id=(int)GrillaProductos.SelectedRows[0].Cells[0].Value;//Marcar el ID de la fila y celda 0
            //MessageBox.Show(id.ToString());
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

        private void tbBuscarID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBuscarID.Text, out int productoId))
            {
 
                List<Productos> producto = new List<Productos>(){Productos.GetProductos(url, productoId)};
                GrillaProductos.DataSource = producto;
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbCategoria.Text, out int category))
            {

                List<Productos> producto = new List<Productos>() { Productos.GetProductos(url, category) };
                GrillaProductos.DataSource = producto;
            }
        }

        //private void cbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    descen.id = Productos.producto.OrderByDescending(des => des.id);
        //}
    }
}
