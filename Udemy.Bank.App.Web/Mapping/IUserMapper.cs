using System.Collections.Generic;
using Udemy.Bank.App.Web.Data.Entities;
using Udemy.Bank.App.Web.Models;

namespace Udemy.Bank.App.Web.Mapping
{
    public interface IUserMapper
    {
         List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        UserListModel MapToUserList(ApplicationUser user);
    }
}
