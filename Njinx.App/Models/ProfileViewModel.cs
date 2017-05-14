using System;
using System.ComponentModel.DataAnnotations;

namespace Njinx.App.Models
{
    public class ProfileViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Photo")]
        public string ProfileImage { get; set; }
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
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
    }
}
