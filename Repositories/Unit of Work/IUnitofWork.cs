using BookStore.DataAccess.Repositories.Category_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories.Unit_of_Work
{
    public interface IUnitofWork
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        void Save();

    }
}
