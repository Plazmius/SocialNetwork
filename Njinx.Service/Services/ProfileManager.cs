using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<UserProfileDto> GetProfileByIdentityIdAsync(string id)
        {
            using (var db = new UnitOfWork())
            {
                var result = new UserProfileDto();
                var userProfile = (await db.UserProfiles.GetAsync(profile => profile.ApplicationUserId == id)).First();
                Mapper.Map(userProfile, result);
                return result;
            }
        }

        public async Task<IEnumerable<UserProfileDto>> SearchUsersAsync(params string[] searchWords)
        {
            using (var db = new UnitOfWork())
            {
                var foundProfiles = await db.UserProfiles.GetAsync(profile => searchWords.Contains(profile.Name)
                                                                   && searchWords.Contains(profile.Surname)
                                                                   || searchWords.Contains(profile.ApplicationUser.Email));

                return Mapper.Map<List<UserProfileDto>>(foundProfiles);
            }
        }
    }
}