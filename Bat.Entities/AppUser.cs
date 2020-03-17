using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BatWithAsp.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
        }

        public string City { get; set; }

        public List<Post> Posts { get; set; }
    }
}
