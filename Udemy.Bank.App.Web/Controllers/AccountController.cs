using Microsoft.AspNetCore.Mvc;
using Udemy.Bank.App.Web.Data.Context;
using Udemy.Bank.App.Web.Data.Interfaces;
using Udemy.Bank.App.Web.Data.Repositories;
using Udemy.Bank.App.Web.Mapping;
using Udemy.Bank.App.Web.Models;

namespace Udemy.Bank.App.Web.Controllers
{
    public class AccountController : Controller
    {
        //READONLY:Bir şet readonly ise CONTRUCTOR içinde SETlenebilir demektir.
        private readonly BankContext _context;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        public AccountController(BankContext context, IUserMapper userMapper, IApplicationUserRepository applicationUserRepository)

        {
            _context = context;
            _userMapper = userMapper;
            _applicationUserRepository = applicationUserRepository;

        }

        public IActionResult Create(int id) //id ile ilgili user'ları getiriyoruz. (user bilgilerini çekiyoruz)
        {
            var userInfo = _userMapper.MapToUserList(_applicationUserRepository.GetById(id));

            return View(userInfo);
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {
            //modeli accounta çevirdim
            _context.Accounts.Add(new Data.Entities.Account
            {
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance,
            });
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");


        }
    }
}
