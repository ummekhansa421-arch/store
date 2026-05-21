using Apps.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Core.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ProductCategoryEnum  Category { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public ProductCategoryStatus Status { get; set; }

    }
}
