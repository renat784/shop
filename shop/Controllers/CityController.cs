using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shop.Models;

namespace shop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private DataContext context;

        public CityController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return context.Cities.ToArray();
        }
    }
}