using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {
        Product p = new Product();

        //public IEnumerable<Product> GetProducts()
        //{
        //    List<Product> products = p.ProductsList();
        //    return products;
        //}

        public HttpResponseMessage GetProducts()
        {
            List<Product> products = p.ProductsList();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            return response;
        }
        public IHttpActionResult GetProduct(int id)
        {
            List<Product> products = p.ProductsList();
            Product product = products.SingleOrDefault(pr => pr.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //public HttpResponseMessage UpdateProduct(Product UpdP)
        //{
        //    return HttpResponseMessage.
        //}
    }
}
