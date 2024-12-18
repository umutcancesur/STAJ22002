using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    //localhost/home
    public IActionResult Index()
    {
        //int saat = DateTime.Now.Hour;
        //var selamlama = saat > 12 ? "İyi günler" : "Günaydın";

        int saat = DateTime.Now.Hour;
        ViewBag.Selamlama = saat > 12 ? "İyi günler" : "Günaydın";
        //ViewBag.UserName = "Umut";
        int userCount = Repository.Users.Where(info => info.WillAttend == true).Count();

        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "İstanbul, Ataşehir Memorial",
            Date = new DateTime(2025, 01, 20, 20, 0, 0),
            NumberOfPeople = userCount
        };

        return View(meetingInfo);
    }
}