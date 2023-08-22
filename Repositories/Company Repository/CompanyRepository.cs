using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repositories.Generic_Repository;
using BookStore.Models.Models;

namespace BookStore.DataAccess.Repositories.Company_Repository
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
        public void Update(Company company)
        {
            _context.Update(company);

        }
    }
}
