using System;
using System.ComponentModel.DataAnnotations;

namespace Njinx.App.Models
{
    public class ProfileViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Birth date")]
        public DateTime BirthDate { get; set; }
    }
}
