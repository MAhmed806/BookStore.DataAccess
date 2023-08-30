using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repositories.Generic_Repository;
using BookStore.Models.Models;

namespace BookStore.DataAccess.Repositories.Product_Repository
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
            var objfromdb= _context.Products.FirstOrDefault(u=>u.Id==product.Id);
            if(objfromdb != null)
            {
                objfromdb.Title = product.Title;
                objfromdb.ISBN = product.ISBN;
                objfromdb.ListPrice = product.ListPrice;
                objfromdb.Price = product.Price;
                objfromdb.Price50 = product.Price50;
                objfromdb.Price100 = product.Price100;
                objfromdb.Description = product.Description;
                objfromdb.ProductImages = product.ProductImages;
                objfromdb.CategoryId = product.CategoryId;
                objfromdb.Author=product.Author;



            }
        }
    }
}
