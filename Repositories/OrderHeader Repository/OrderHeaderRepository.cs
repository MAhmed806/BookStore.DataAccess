using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repositories.Generic_Repository;
using BookStore.DataAccess.Repositories.OrderHeader_Repository;
using BookStore.Models.Models;

namespace BookStore.DataAccess.Repositories.OrderDetail_Repository
{
    public class OrderHeaderRepository : GenericRepository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderHeaderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Update(OrderHeader OrderHeader)
        {
            _context.Update(OrderHeader);
        }
    }
}
