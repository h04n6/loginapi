
using System.Security.Policy;

namespace LoginAPI.Models
{
    public class UpdateModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
