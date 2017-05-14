using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Njinx.Core.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Column("ApplicationUser_Id")]
        public string ApplicationUserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfileImage { get; set; }

        public virtual List<UserProfile> Followed { get; set; }
        public virtual List<UserProfile> Followers { get; set; }
    }
}