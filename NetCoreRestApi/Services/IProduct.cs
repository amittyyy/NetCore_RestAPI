using NetCoreRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreRestApi.Services
{
    public interface IProduct
    {
        IEnumerable<Product> GetProduct();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
