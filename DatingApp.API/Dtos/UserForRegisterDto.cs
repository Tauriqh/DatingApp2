using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "You must specify password between 6 and 15 characters!!")]
        public string Password { get; set; }
    }
}