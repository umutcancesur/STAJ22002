using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Apply()
        {
            return View();
        }
        //default olarak get request yapar fakat post request yapmak istediğimizde [HttpPost] attribute'unu kullanırız.
        //Bir method aynı isimde hem get hem de post request ile çağrılabilir. Fakat post request ile çağrıldığında diğer methodların çalışmaması için [HttpPost] attribute'unu kullanırız ve method parametrelerini değiştiririz.

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if(ModelState.IsValid){ 
                ViewBag.UserCount = Repository.Users.Count();
                Repository.CreateUser(model);
            return View("Thanks", model);
            }
            return View(model);
        }
        public IActionResult List()
        {
            return View(Repository.Users);
        }
        //meeting/details/1
        public IActionResult Details(int id){
            return View(Repository.GetById(id));
        }
    }
}
