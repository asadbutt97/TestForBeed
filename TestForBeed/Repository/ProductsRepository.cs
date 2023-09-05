using Microsoft.EntityFrameworkCore;
using TestForBeed.Models;

namespace TestForBeed.Repository
{
  
 
        public class ProductRepository
        {
            private readonly TestDbContext _context;

            public ProductRepository(TestDbContext context)
            {
                _context = context;
            }

            public List<Product> GetAllProducts()
            {
                return _context.Products.Include(p => p.Category).ToList(); 
            }

            public Product GetProductById(int id)
            {
                return _context.Products.Find(id);
            }
    }
   }
