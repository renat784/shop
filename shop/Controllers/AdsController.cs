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
        [Route("[action]/{search}/{categoryId}/{subcategoryId}/{cityId}/{min_price}/{max_price}/{asc}")]
        public IEnumerable<Ad> SearchByFilter(string search,int categoryId, int subcategoryId, int cityId, int min_price,
            int max_price, int asc)
        {
            var query = from ad in context.Ads select ad;

            if (search != "all")
            {
                query = query.Where(i => i.Title.Contains(search));
            }
            if (categoryId != 0)
            {
                query = query.Where(i => i.CategoryId == categoryId);
            }

            if (subcategoryId != 0)
            {
                query = query.Where(i => i.SubCategoryId == subcategoryId);
            }
            if (cityId != 0)
            {
                query = query.Where(i => i.CityId == cityId);
            }
            if (min_price != -1 && max_price != -1)
            {
                query = query.Where(i => i.Price >= min_price && i.Price <= max_price);
            }
            if (min_price != -1 && max_price == -1)
            {
                query = query.Where(i => i.Price >= min_price);
            }
            if (min_price == -1 && max_price != -1)
            {
                query = query.Where(i => i.Price <= max_price);
            }
            if (asc == 0)
            {
                query = query.OrderByDescending(i => i.Price);
            }
            if (asc == 1)
            {
                query = query.OrderBy(i => i.Price);
            }


            if (query.Count() == 0)
            {
                return new List<Ad>(); 
            }

            return query;

            //context.Ads.Where(
            //    i => i.CategoryId == categoryId &&
            //    i.SubCategoryId == subcategoryId &&
            //    i.CityId == cityId &&
            //    i.Price >= min_price &&
            //    i.Price <= max_price)
            //    .OrderBy(i => i.Price); 
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
        [Route("[action]/{count}")]
        public IEnumerable<Ad> GetTop(int count = 10)
        {
            return context.Ads.OrderByDescending(i => i.AdId).Take(count).ToArray();
        }

        [HttpGet]
        [Route("[action]")]
        public int AdsTotalCount()
        {
            return context.Ads.Count();
        }

        
    }
}