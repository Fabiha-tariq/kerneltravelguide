using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace KernelTravelGuides.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string First_Name { get; set; }

        [Required]
        public string Last_Name { get; set; }
        [Required]
        public string User_Name { get; set; }

        [Required]
        public DateTime Age { get; set; }

        [Required]
        public string Phone { get; set; }

    }
}
