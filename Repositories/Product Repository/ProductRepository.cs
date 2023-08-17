using BookStore.Data;
using BookStore.DataAccess.Repositories.Generic_Repository;
using BookStore.Models.Models;


namespace BookStore.DataAccess.Repositories.Category_Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Product product)
        {
            _context.Update(product);
        }
    }
}
