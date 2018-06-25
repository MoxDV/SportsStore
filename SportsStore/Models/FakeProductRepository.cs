using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product> {
            new Product{ Name = "Футбольный мяч", Price = 25},
            new Product{ Name = "Доска для серфинга", Price = 179},
            new Product{ Name = "Беговая обувь", Price = 95}
        };
    }
}
