using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Principal;

namespace Day_9.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        
        public string SSN { get; set; }

        public string Address { get; set; }


    }
}
