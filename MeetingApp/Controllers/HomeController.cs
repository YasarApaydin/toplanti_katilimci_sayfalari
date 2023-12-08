﻿using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {

     

        public IActionResult Index() {
            int saat = DateTime.Now.Hour;
            //DateTime saat1 = DateTime.Now;
            //string sadeceSaat = saat1.ToString("HH:mm");
            ViewBag.selamlama=saat > 12 ? "İyi Günler" : "Günaydın";
            // ViewBag.UserName = ", Yaşar Bey";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true ).Count();
            //ViewData["Saat"] = sadeceSaat;
            var mmeting = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount


            };


            return View(mmeting);

        }
    }
}
