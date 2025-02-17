using Microsoft.AspNetCore.Identity;

namespace gencol.Models
{
    public class Users : IdentityUser
    {
        public string FullName {get; set;}
    }
}