﻿using System;
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

        [NotMapped]
        public List<string> Images { get; set; }
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }

        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
    }

    public class Example
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
    }
}
