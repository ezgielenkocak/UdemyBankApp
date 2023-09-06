using Microsoft.AspNetCore.Mvc;
using Udemy.Bank.App.Web.Data.Context;
using Udemy.Bank.App.Web.Data.Interfaces;
using Udemy.Bank.App.Web.Data.Repositories;
using Udemy.Bank.App.Web.Mapping;

namespace Udemy.Bank.App.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BankContext _context;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;   
        public HomeController(BankContext context, IApplicationUserRepository applicationUserRepository, IUserMapper userMapper )
        {
            _context = context;
            _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_applicationUserRepository.GetAll()));
        }
    } 
}
