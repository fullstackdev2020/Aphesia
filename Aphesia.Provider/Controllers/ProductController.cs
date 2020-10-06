using Aphesia.EF.DbContext;
using Aphesia.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aphesia.Provider.Controllers
{
    public class ProductController
    {
        public List<Product> GetProducts()
        {
            return new AphesiaContext().Products.ToList();
        }
        //public Product GetbyId(int Id)
        //{
        //    var p = ne
        //    return
        //}

        public void AddProduct(Product product)
        {
            var ctx = new AphesiaContext();
            ctx.Products.Add(product);
            ctx.SaveChanges();
        }
        public Product GetProductById(int Id)
        {
            var product = new Product();
        }
    }
}
