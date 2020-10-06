using Aphesia.EF.Models;
using Aphesia.Provider.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aphesia.Tests.Controllers
{
    [TestFixture]
    public class ProductControllerTest
    {
        private ProductController productController;
        [SetUp]
        public void Initialize()
        {
            productController = new ProductController();
        }
        [Test]
        public void AddProduct()
        {
            int count = productController.GetProducts().Count;
            Product product = new Product()
            {
                Name = "Product1",
                Descrption = "Product added"
            };
            productController.AddProduct(product);
            int newCount = productController.GetProducts().Count;
            Assert.That(newCount == count + 1);
            //Assert.AreEqual("Product1", product.Name);
        }
    }
}
