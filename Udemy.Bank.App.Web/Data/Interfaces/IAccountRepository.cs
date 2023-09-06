using Udemy.Bank.App.Web.Data.Entities;

namespace Udemy.Bank.App.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        void Create(ApplicationUser user);
    }
}
