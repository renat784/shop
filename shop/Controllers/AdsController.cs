using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpPost]
        public int Post(Ad advert)
        {
            context.Ads.Add(advert);
            context.SaveChanges();
            return advert.AdId;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IEnumerable<Ad> SearchByCategoryId(int id)
        {
            return context.Ads.Where(i => i.CategoryId == id);
        }

        [HttpGet]
        [Route("[action]")]
        public IEnumerable<Ad> SearchAll()
        {
            return context.Ads;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IEnumerable<Ad> SearchBySubCategoryId(int id)
        {
            return context.Ads.Where(i => i.SubCategoryId == id).ToArray();

        }

        [HttpGet]
        [Route("[action]/{id}")]
        public Ad SearchByAdId (int id)
        {
            return context.Ads.Where(i => i.AdId == id)
                .Include("City")
                .Include("Category")
                .Include("SubCategory").ToList().First();
        }

        [HttpGet]
        [Route("[action]")]
        public IEnumerable<Ad> GetTop25 ()
        {
            return context.Ads.Take(25).ToArray();
        }
    }
}