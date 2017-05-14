using System;
using Njinx.Core.Entities;

namespace Njinx.Service.Models
{
    public class UserProfileDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string AppUserId { get; set; }
        public string ProfileImageB64 { get; set; }
    }
}