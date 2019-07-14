using InnovaSolutions_UserProfile.Business.Services;
using InnovaSolutions_UserProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InnovaSolutions_UserProfile.Controllers
{
    public class UserController : Controller
    {
        private IUserProfileBusiness userProfileBusiness = null;
        public UserController()
        {
            userProfileBusiness = UserProfileBusiness.Instance;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadLogin()
        {
            return PartialView("_Login");
        }
        public ActionResult LoadSignUp()
        {
            return PartialView("_Signup");
        }
        [HttpPost]
        public ActionResult VerifyLogin(Login loginDetails)
        {
            userProfileBusiness.ValidateLoginDetails(loginDetails);
            return PartialView("_UserProfile");
        }
        [HttpPost]
        public ActionResult VerifySignUp(Signup signupDetails)
        {
            userProfileBusiness.SendVerificationEmail(signupDetails);
            return PartialView("_UserProfile");
        }
        [HttpPost]
        public ActionResult StoreUserDetails(Signup signupDetails)
        {
            userProfileBusiness.StoreUserDetails(signupDetails);
            return PartialView("_UserProfile");
        }
    }
}