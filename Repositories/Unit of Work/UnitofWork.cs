using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repositories.Application_User_Repository;
using BookStore.DataAccess.Repositories.Category_Repository;
using BookStore.DataAccess.Repositories.Company_Repository;
using BookStore.DataAccess.Repositories.OrderDetail_Repository;
using BookStore.DataAccess.Repositories.OrderHeader_Repository;
using BookStore.DataAccess.Repositories.Product_Repository;
using BookStore.DataAccess.Repositories.Shopping_Cart_Repository;

namespace BookStore.DataAccess.Repositories.Unit_of_Work
{
    public class UnitofWork : IUnitofWork
    {
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }

        public IApplicationUserRepository ApplicationUserRepository => throw new NotImplementedException();
        public IOrderDetailRepository OrderDetail { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }

        private ApplicationDbContext _context;
        public UnitofWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
            Product = new ProductRepository(_context);
            Company = new CompanyRepository(_context);
            ShoppingCart = new ShoppingCartRepository(_context);
            ApplicationUser = new ApplicationUserRepository(_context);
            OrderDetail= new OrderDetailRepository(_context);
            OrderHeader= new OrderHeaderRepository(_context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
