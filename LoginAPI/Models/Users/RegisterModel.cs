using System.ComponentModel.DataAnnotations;

namespace LoginAPI.Models.Users
{
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
