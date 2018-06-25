using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFProductRepository: IProductRepository {
        private ApplicationDbContext _context;

        public IEnumerable<Product> Products => _context.Products;

        public EFProductRepository(ApplicationDbContext context) {
            _context = context;
        }
    }
}
