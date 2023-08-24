using BookStore.Models.Models;

namespace BookStore.DataAccess.Repositories.OrderDetail_Repository
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
        void Update(OrderDetail OrderDetail);
        void UpdateStatus(int id,string orderstatus,string? paymentstatus=null);
        void UpdateStripePaymentId(int id, string sessionid, string paymentintentid);
    }
}
