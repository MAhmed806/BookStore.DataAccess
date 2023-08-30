using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repositories.Application_User_Repository
{
    public interface IApplicationUserRepository : IGenericRepository<ApplicationUser>
    {
        public void Update(ApplicationUser applicationUser);
    }
}
