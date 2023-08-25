using BookStore.Models.Models;

namespace BookStore.DataAccess.Repositories.OrderHeader_Repository
{
    public interface IOrderHeaderRepository : IGenericRepository<OrderHeader>
    {
        void Update(OrderHeader OrderHeader);
        void UpdateStatus(int id, string orderstatus, string? paymentstatus = null);
        void UpdateStripePaymentId(int id, string sessionid, string paymentintentid);
    }
}
