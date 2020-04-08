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
    public class AdsController : ControllerBase
    {
        private DataContext context;

        public AdsController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("{id:int}")]
        public IEnumerable<Ad> Get(int id)
        {
            return context.Ads.Where(i => i.SubCategoryId == id).ToArray();
        }

        [HttpGet]
        public IEnumerable<Ad> Get()
        {
            return context.Ads.Take(10).ToArray();
        }
    }
}