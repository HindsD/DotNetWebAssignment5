using System.Collections.Generic;

namespace Northwind.Models
{
    public class ProductViewModel
    {
        public Category category { get; set; }
        public IEnumerable<Product> Product { get; set; }
    }
}