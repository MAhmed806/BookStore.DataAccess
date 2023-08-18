using BookStore.Data;
using BookStore.DataAccess.Repositories.Category_Repository;
using BookStore.DataAccess.Repositories.Company_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories.Unit_of_Work
{
    public class UnitofWork : IUnitofWork
    {
        public ICategoryRepository Category{get; private set;}
        public IProductRepository Product { get; private set;}
        public ICompanyRepository Company { get; private set;}

        private ApplicationDbContext _context;
        public UnitofWork(ApplicationDbContext context)
        {
            _context = context;
            Category=new CategoryRepository(_context);
            Product=new ProductRepository(_context);
            Company=new CompanyRepository(_context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
