using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnovaSolutions_UserProfile.API.Services.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerificationCode { get; set; }
    }
}