﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
