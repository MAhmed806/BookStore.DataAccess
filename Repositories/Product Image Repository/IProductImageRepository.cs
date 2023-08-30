using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories.Product_Image_Repository
{
    public interface IProductImageRepository:IGenericRepository<ProductImage>
    {
        public void Update(ProductImage productImage);
    }
}
