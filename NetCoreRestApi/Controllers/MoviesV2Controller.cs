//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NetCoreRestApi.Models;

//namespace NetCoreRestApi.Controllers
//{
//    //[ApiVersion("2.0")]
//    //[Route("api/[controller]")]
//    [Route("api/movies")]
//    //[Route("api/v{version:apiVersion}/movies")]  //versioning via URL Path
//    //URL:-https://localhost:44315/api/V2/movies
//    [ApiController]
//    public class MoviesV2Controller : ControllerBase
//    {
//        List<MoviesV2> _moviesv2 = new List<MoviesV2>()
//        {
//            new MoviesV2(){Id = 0, MovieName="Marvel Z", MovieType="Action"},
//            new MoviesV2(){Id=0,MovieName="Walking Dead", MovieType ="Si-Fi"}
//        };

//        [HttpGet]
//        //URL:https://localhost:44315/api/movies?api-version=2.0
//        //QueryString Versioning
//        public IEnumerable<MoviesV2> Get()
//        {
//            return _moviesv2;
//        }
//    }
//}