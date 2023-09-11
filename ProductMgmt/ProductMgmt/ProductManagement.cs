using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMgmt
{
    public class ProductManagement
    {
        static ProductDbEntities1 db;
        public ProductManagement()
        {
            db = new ProductDbEntities1();
        }
        public Product AddProduct(Product product) 
        {
            db.Products.Add(product);
            return product;
        }
        public Product RetrieveProduct(int id)
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.Equals(id));
                return product;
            }
            else
            {
                Console.WriteLine("Product Not Found");
                return null;
            }
        }
        public void DeleteProduct(int id) 
        {
            if (IsExistProduct(id))
            {
                Product product = db.Products.SingleOrDefault(p => p.Equals(id));
                db.Products.Remove(product);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }
        public Product UpdateProduct(int id)
        {
            Product product = null;
            if (IsExistProduct(id))
            {
                product = db.Products.SingleOrDefault(p => p.Id == id);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
            return product;
        }
        public bool IsExistProduct(int id)
        {
            var pro = db.Products.FirstOrDefault(p => p.Id == id);
            if (pro == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
