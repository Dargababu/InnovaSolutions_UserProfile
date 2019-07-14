using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnovaSolutions_UserProfile.API.Services.Models
{
    public class Signup
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<string> Preferences { get; set; }
    }
}