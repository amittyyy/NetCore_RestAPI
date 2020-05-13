//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NetCoreRestApi.Data;
//using NetCoreRestApi.Models;
//using NetCoreRestApi.Services;

//namespace NetCoreRestApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ServicesController : ControllerBase
//    {
//        //ProductDbContext productDbContext = new ProductDbContext();

//        private IServices serviceRepository;
//        public ServicesController(IServices _serviceRespository)
//        {

//            serviceRepository = _serviceRespository;
//        }

//        [HttpGet]
//        public IEnumerable<Service> Get()
//        {
//            return serviceRepository.GetService();
//        }

//        [HttpGet ("{id}", Name = "Get")]
//        public IActionResult Get(int id)
//        {
//            var service = serviceRepository.GetService(id);

//            if (service == null)
//                return BadRequest("Empty");
//            return Ok(service);

//        }

//        [HttpPost]
//        public IActionResult Post([FromBody] Service service)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ModelState);
//            serviceRepository.AddService(service);
//            return StatusCode(StatusCodes.Status201Created);
//        }

//        [HttpPut ("{id}")]
//        public IActionResult Put(int id, [FromBody] Service service)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest(ModelState);
//            if (id != service.ServiceId)
//                return NotFound("No Records");

//            try
//            {
//                serviceRepository.UpdateService(service);
//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine(ex);
//                return NotFound("No Record");
//            }

//            return Ok("Product Updates");
//        }

//        [HttpDelete ("{id}")]
//        public IActionResult Delete(int id)
//        {
//            serviceRepository.DeleteService(id);
//            return Ok("Product Deleted");
//        }


//    }
//}