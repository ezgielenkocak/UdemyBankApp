using Udemy.Bank.App.Web.Data.Context;
using Udemy.Bank.App.Web.Data.Entities;
using Udemy.Bank.App.Web.Data.Interfaces;

namespace Udemy.Bank.App.Web.Data.Repositories
{
    public class AccountRepository:IAccountRepository
    {
        private readonly BankContext _context;

        public AccountRepository(BankContext context)
        {
            context = _context;
        }
        public void Create(ApplicationUser user)
        {
            _context.ApplicationUsers.Add(user);
            _context.SaveChanges();
        }
    }
}
