using Domain.Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExchangeC.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<User> _userRepository;
        public ActionResult Index()
        {
            _userRepository.Insert(new Domain.Entities.User
            {
                Email = "pooria@gmail.com",
                EmailConfirmationCode = "",
                EmailConfirmationDatetime = DateTime.Now,
                EmailConfirmationDatetimeRequest = DateTime.Now,
                FamilyName = "taghizadeh",
                IsDisable = false,
                Mobile = "09127426249",
                MobileConfirmationCode = "",
                MobileConfirmationDatetime = DateTime.Now,
                MobileConfirmationDatetimeRequest = DateTime.Now,
                Name = "pooria",
                NationalCode = "4270399880",
                Password = "123",
                UserId = Guid.NewGuid()
            });
            _userRepository.Save();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}