using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Njinx.App.Models;
using Njinx.Service.Services;

namespace Njinx.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
            {
                return View();
            }
            
            var profileManager = new ProfileManager();
            var currentUserProfile = profileManager.GetProfileByIdentityId(HttpContext.User.Identity.GetUserId());

            return View("UserHome", new ProfileViewModel
            {
                Name = currentUserProfile.Name,
                Surname = currentUserProfile.Surname,
                BirthDate = currentUserProfile.BirthDate
            });
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