using BookStore.DataAccess.Repositories.Application_User_Repository;
using BookStore.DataAccess.Repositories.Category_Repository;
using BookStore.DataAccess.Repositories.Company_Repository;
using BookStore.DataAccess.Repositories.OrderDetail_Repository;
using BookStore.DataAccess.Repositories.OrderHeader_Repository;
using BookStore.DataAccess.Repositories.Product_Repository;
using BookStore.DataAccess.Repositories.Shopping_Cart_Repository;
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
        ICompanyRepository Company { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUserRepository { get; }
        IOrderDetailRepository OrderDetail { get; }
        IOrderHeaderRepository OrderHeader { get; }
        void Save();

    }
}
