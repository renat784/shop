using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models
{
    public class Ad
    {
        public int AdId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Desc { get; set; }

       
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }

        public int CityId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        
        public City City { get; set; }
        
        public SubCategory SubCategory { get; set; }
        
        public Category Category { get; set; }

    }

    public class Example
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
    }
}
