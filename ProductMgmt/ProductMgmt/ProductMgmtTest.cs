using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    [TestFixture]
    public class ProductMgmtTest
    {
        ProductManagement productMgr;
        [SetUp]
        public void Setup()
        {
            productMgr = new ProductManagement();
        }
        [Test]
        public void AddProductTest()
        {
            var product = new Product()
            {
                //Id=4,
                Name = "Washing Machine",
                Price = 42000.50
            };
            var result = productMgr.AddProduct(product);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Equals(product));
        }
        [Test]
        public void UpdateProductTest()
        {
            var product = new Product()
            {
                Id=1,
                Name="I Phone 13 Pro",
                Price=98000.45
            };
            var result = productMgr.UpdateProduct(1);
            Assert.IsNotNull(result);
            //Assert.IsTrue(result.Equals(product));
            //Assert.AreEqual("I Phone 13 Pro", result.Name);
            //Assert.AreEqual(98000.45, result.Price);
        }
    }
}
