//using NetCoreRestApi.Data;
//using NetCoreRestApi.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace NetCoreRestApi.Services
//{
//    public class ServiceRepository : IServices
//    {
//        private ProductDbContext productDbContext;

//        public ServiceRepository(ProductDbContext _productDbContext)
//        {
//            productDbContext = _productDbContext;
//        }
//        public void AddService(Service service)
//        {
//            productDbContext.Services.Add(service);
//            productDbContext.SaveChanges(true);
//        }

//        public void DeleteService(int id)
//        {
//            var service = productDbContext.Services.Find(id);
//            productDbContext.Services.Remove(service);
//            productDbContext.SaveChanges(true);
//        }

//        public Service GetService(int id)
//        {
//            var service = productDbContext.Services.SingleOrDefault(m => m.ServiceId == id);
//            return service;
//        }

//        public IEnumerable<Service> GetService()
//        {
//            return productDbContext.Services;
//        }

//        public void UpdateService(Service service)
//        {
//            productDbContext.Services.Update(service);
//            productDbContext.SaveChanges(true);
//        }
//    }
//}
