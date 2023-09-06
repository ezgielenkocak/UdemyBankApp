using System.Collections.Generic;
using System.Linq;
using Udemy.Bank.App.Web.Data.Entities;
using Udemy.Bank.App.Web.Models;

namespace Udemy.Bank.App.Web.Mapping
{
    public class UserMapper:IUserMapper
    {
        //gelen listeyi view' e çeviricez
        public List<UserListModel> MapToListOfUserList(List<ApplicationUser> users)
        {
            return users.Select(x => new UserListModel
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname
            }).ToList();
        }
        public UserListModel MapToUserList(ApplicationUser user)
        {
            return new UserListModel
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname
            };
        }
    }
}
