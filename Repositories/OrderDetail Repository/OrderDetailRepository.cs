using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repositories.Generic_Repository;
using BookStore.DataAccess.Repositories.OrderHeader_Repository;
using BookStore.Models.Models;

namespace BookStore.DataAccess.Repositories.OrderDetail_Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(OrderDetail OrderDetail)
        {
            _context.Update(OrderDetail);
        }

        public void UpdateStatus(int id, string orderstatus, string? paymentstatus = null)
        {
            var orderfromdb= _context.OrderHeaders.FirstOrDefault(x=> x.Id == id);
            if (orderfromdb != null)
            {
                orderfromdb.OrderStatus= orderstatus;
                if (!string.IsNullOrEmpty(paymentstatus))
                {
                    orderfromdb.PaymentStatus= paymentstatus;
                }
            }
        }

        public void UpdateStripePaymentId(int id, string sessionid, string paymentintentid)
        {
            var orderfromdb = _context.OrderHeaders.FirstOrDefault(x => x.Id == id);
            if(!string.IsNullOrEmpty(sessionid))
            {
                orderfromdb.SessionId= sessionid;
            }
            if (!string.IsNullOrEmpty(paymentintentid))
            {
                orderfromdb.PaymentIntentId = paymentintentid;
                orderfromdb.PaymentDate= DateTime.Now;
            }
        }
    }
}
