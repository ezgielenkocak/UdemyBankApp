using System.Collections.Generic;
using System.Linq;
using Udemy.Bank.App.Web.Data.Context;
using Udemy.Bank.App.Web.Data.Entities;
using Udemy.Bank.App.Web.Data.Interfaces;

namespace Udemy.Bank.App.Web.Data.Repositories
{    //tekrar ettiğim iş userları listelemekti

    //bana 2 tane metot lazım 1.id ile getiren, 2.bütün hepsini getiren
    public class ApplicationUserRepository:IApplicationUserRepository //bu interface'i görünce gitdependency injection aracılığıyla bana örneğini ver
    {
        private readonly BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
            _context = context;
        }

        public List<ApplicationUser> GetAll()
        {
            return _context.ApplicationUsers.ToList();
        }

        public  ApplicationUser GetById(int id)
        {
            return _context.ApplicationUsers.SingleOrDefault(x => x.Id==id);
        }

      
    }
}
