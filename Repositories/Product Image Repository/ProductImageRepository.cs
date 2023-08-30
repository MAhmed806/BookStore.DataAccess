using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repositories.Generic_Repository;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories.Product_Image_Repository
{
    public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductImageRepository(ApplicationDbContext context) : base(context)
        { 
            _context = context;
        }

        public void Update(ProductImage productImage)
        {
            _context.ProductImages.Update(productImage);
        }
    }
}
