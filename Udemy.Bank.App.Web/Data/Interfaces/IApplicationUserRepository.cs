using System.Collections.Generic;
using Udemy.Bank.App.Web.Data.Entities;

namespace Udemy.Bank.App.Web.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
         ApplicationUser GetById(int id);

    }
}
