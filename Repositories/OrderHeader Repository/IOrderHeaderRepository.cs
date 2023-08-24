using BookStore.Models.Models;

namespace BookStore.DataAccess.Repositories.OrderHeader_Repository
{
    public interface IOrderHeaderRepository : IGenericRepository<OrderHeader>
    {
        void Update(OrderHeader OrderHeader);
    }
}
