using BookStore.Models.Models;

namespace BookStore.DataAccess.Repositories.OrderDetail_Repository
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
        void Update(OrderDetail OrderDetail);
       
    }
}
