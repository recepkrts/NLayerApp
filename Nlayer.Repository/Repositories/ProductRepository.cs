using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entity;
using NLayer.Core.Repositories;

namespace Nlayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategoryAsync()
        {
            //Eager Loading
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }
    }
}
