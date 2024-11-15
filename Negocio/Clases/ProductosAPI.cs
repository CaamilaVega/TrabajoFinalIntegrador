using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Policy;
using System.Windows.Forms;
using NLog;
using RestSharp;

namespace Negocio
{
    public class ProductosAPI
    {
        string url = ConfigurationManager.AppSettings["urlApi"];
        Logger _logger = LogManager.GetCurrentClassLogger();


        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }


        public List<ProductosAPI> GetProductos(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products", Method.Get);
                List<ProductosAPI> producto = client.Get<List<ProductosAPI>>(request);
                return producto;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error en el método GetProductos", url);
                return null;
            }
        }


        public  ProductosAPI GetProductosId(string url, int productId)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{productId}", Method.Get);
                ProductosAPI producto = client.Get<ProductosAPI>(request);
                return producto;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error en el método GetProductosId.", url, productId);
                return null;
            }
        }
        public List<ProductosAPI> ProdDesc(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products?sort=desc", Method.Get);
                List<ProductosAPI> productos = client.Get<List<ProductosAPI>>(request);
                return productos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error en el método ProdDesc.", url);
                return null;
            }
        }
  
        public List<ProductosAPI> ProdAsc(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products?sort=asc", Method.Get);
                List<ProductosAPI> productos = client.Get<List<ProductosAPI>>(request);
                return productos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error en el método ProdAsc.", url);
                return null;
            }
        }

        public List<ProductosAPI> GetFiltrado(string url, string categoria)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/category/{categoria}", Method.Get);
                List<ProductosAPI> productos = client.Get<List<ProductosAPI>>(request);
                return productos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error en el método GetFiltrado.", url, categoria);
                return null;
         
            }
        }

        public ProductosAPI CrearProducto(ProductosAPI productoNuevo, string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest("products", Method.Post);
                request.AddJsonBody(productoNuevo);
                var response = client.Execute<ProductosAPI>(request);

                if (!response.IsSuccessful)
                {
                    throw new Exception($"Error: {response.ErrorMessage}");
                }
                return response.Data;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error en el método CrearProducto.", url, productoNuevo);
                return null;
            }
        }
        public void EliminarProducto(ProductosAPI producto, string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest($"products/{producto.Id}", Method.Delete);
                var response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    throw new Exception("No se pudo eliminar el producto.");
                }  
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error en el método EliminarProducto para el ID: {producto.Id}");
                
            }
        }
    }
}


