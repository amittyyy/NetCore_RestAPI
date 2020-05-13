//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NetCoreRestApi.Models;

//namespace NetCoreRestApi.Controllers
//{
//    //[ApiVersion("1.0")]
//    [Route("api/movies")]
//    [ApiController]
//    public class MoviesV1Controller : ControllerBase
//    {
//        List<MoviesV1> _movies = new List<MoviesV1>()
//        {
//            new MoviesV1(){Id = 0, MovieName="Marvel Z"},
//            new MoviesV1(){Id=0,MovieName="Walking Dead"}
//        };

//        [HttpGet]
//        //URL:-https://localhost:44315/api/movies?api-version=1.0
//        public IEnumerable<MoviesV1> Get()
//        {
//            return _movies;
//        }
//    }
//}