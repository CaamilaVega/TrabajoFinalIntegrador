using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalIntegrador1
{
    public class Productos
    {
        
      
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string image { get; set; }

        public static Productos GetProductos(string url,int productoid)
        {
        var client = new RestClient(url);
        var request = new RestRequest($"products/{productoid}", Method.Get);
        Productos producto = client.Get<Productos>(request);
        return producto;
        }
        public List<Productos> ProdDesc(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products?sort=desc", Method.Get);
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }
        public List<Productos> ProdAsc(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products", Method.Get);
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }

        public List<Productos> FiltradoJewelery(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products/category/jewelery", Method.Get);
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }
        public List<Productos> FiltradoElectronics(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products/category/electronics", Method.Get);
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }
        public List<Productos> FiltradoMensclothing(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products/category/men's clothing", Method.Get);
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }
        public List<Productos> Filtradowomensclothing(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest("products/category/women's clothing", Method.Get);
            List<Productos> productos = client.Get<List<Productos>>(request);
            return productos;
        }
    }
}
