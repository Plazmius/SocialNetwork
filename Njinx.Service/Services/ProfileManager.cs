using System.Linq;
using AutoMapper;
using Njinx.Core.Entities;
using Njinx.DAL.Concrete;
using Njinx.Service.Models;

namespace Njinx.Service.Services
{
    public class ProfileManager
    {
        public void Add(UserProfileDto userProfile)
        {
            using (var db = new UnitOfWork())
            {
                var profile = new UserProfile();
                Mapper.Map(userProfile, profile);
                db.UserProfiles.Insert(profile);
                db.SaveChanges();
            }
        }

        public UserProfileDto GetProfileByIdentityId(string id)
        {
            using (var db = new UnitOfWork())
            {
                var result = new UserProfileDto();
                var userProfile = db.UserProfiles.Get(profile => profile.ApplicationUserId == id).First();
                Mapper.Map(userProfile, result);
                return result;
            }
        }
    }
}