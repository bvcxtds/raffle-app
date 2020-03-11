using System.ComponentModel.DataAnnotations;

namespace Raffle.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be 8 characters or more")]
        public string Password { get; set; }

    }
}