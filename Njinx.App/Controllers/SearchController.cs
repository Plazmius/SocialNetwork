using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.ApplicationServices;
using System.Web.Mvc;
using AutoMapper;
using Njinx.App.Models;
using Njinx.Service.Services;

namespace Njinx.App.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Search(string searchString)
        {
            var searchWords = searchString.Split(' ').ToArray();

            var foundUsers = await new ProfileManager().SearchUsersAsync(searchWords);

            return View(foundUsers.Select(profile => new ProfileViewModel
            {
                Name = profile.Name,
                Surname = profile.Surname,
                ProfileImage = profile.ProfileImageB64
            }));
        }
    }
}