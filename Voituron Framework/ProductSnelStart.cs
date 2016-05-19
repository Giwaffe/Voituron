﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voituron_Framework
{
    public class ProductSnelStart
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int DiscountGroup { get; set; }
        public decimal MaxDiscount { get; set; }
        public decimal AmountInStorage { get; set; }
    }
}