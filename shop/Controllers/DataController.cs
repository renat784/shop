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
    public class DataController : ControllerBase
    {
        private DataContext context;

        public DataController(DataContext context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("[action]")]
        public IEnumerable<City> Cities()
        {
            return context.Cities.ToArray();
        }


        [HttpGet]
        [Route("[action]")]
        public IEnumerable<Category> Categories()
        {
            return context.Categories.ToArray();
        }


        [HttpGet]
        [Route("[action]")]
        public IEnumerable<SubCategory> SubCategories()
        {
            return context.SubCategories.ToArray();
        }
    }
}