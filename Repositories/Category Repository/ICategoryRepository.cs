using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories.Category_Repository
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
   
        void Update(Category category);
    }
}
