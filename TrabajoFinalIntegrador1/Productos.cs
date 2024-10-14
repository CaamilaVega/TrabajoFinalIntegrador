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
    }
}
