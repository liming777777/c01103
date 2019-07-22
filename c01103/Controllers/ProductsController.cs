using c01103.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace c01103.Controllers
{
    public class ProductsController : ApiController
    
    {
        private PrDataContext db = new PrDataContext();

        // GET api/Products

        public IEnumerable<Product> GetAllProducts()
        {
            return db.Products;
        }

        // GET api/Products/5
        public IHttpActionResult GetProduct(int id)
        {
            // var product = products.FirstOrDefault((p) => p.Id == id);
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}