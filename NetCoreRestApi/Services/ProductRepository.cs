using NetCoreRestApi.Data;
using NetCoreRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreRestApi.Services
{
    public class ProductRepository : IProduct
    {
        private ProductDbContext productDbContext;

        public ProductRepository(ProductDbContext _productDbContext)
        {
            productDbContext = _productDbContext;
        }


        public void AddProduct(Product product)
        {
            productDbContext.Products.Add(product);
            productDbContext.SaveChanges(true);
        }

        public void DeleteProduct(int id)
        {
            var product = productDbContext.Products.Find(id);
            productDbContext.Products.Remove(product);
            productDbContext.SaveChanges(true);
        }

        public IEnumerable<Product> GetProduct()
        {
            return productDbContext.Products;
        }

        public Product GetProduct(int id)
        {
            var product = productDbContext.Products.SingleOrDefault(m => m.ProductId == id);
            return product;
        }

        public void UpdateProduct(Product product)
        {
            productDbContext.Products.Update(product);
            productDbContext.SaveChanges(true);
        }
    }
}
