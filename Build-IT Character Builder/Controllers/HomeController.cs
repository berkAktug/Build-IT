using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Character_Builder.Models;
using Microsoft.AspNetCore.Identity;

namespace Character_Builder.Controllers
{
    public class HomeController : Controller
    {

        private readonly Data.ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ListUsers()
        {
            List<UsersViewModel> userList = new List<UsersViewModel>();

            foreach (var item in _context.Users)
            {
                var user = new UsersViewModel
                {
                    Username = item.UserName,
                    Email = item.Email
                };

                userList.Add(user);
            }

            return View(userList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
