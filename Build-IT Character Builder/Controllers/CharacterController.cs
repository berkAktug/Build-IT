using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Build_IT_Character_Builder.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult CharacterBuilder()
        {
            return View();
        }

        public IActionResult TestBuilder()
        {
            return View();
        }
    }
}