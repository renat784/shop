using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shop.Models;

namespace shop.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private DataContext context;

        public CategoriesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<SubCategory> Get()
        {
            return context.SubCategories.ToArray();
        }
    }
}