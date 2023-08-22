using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories.Shopping_Cart_Repository
{
    public interface IShoppingCartRepository:IGenericRepository<ShoppingCart>
    {
        void Update(ShoppingCart shoppingCart);
    }
}
