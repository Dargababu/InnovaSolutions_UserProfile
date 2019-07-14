using InnovaSolutions_UserProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovaSolutions_UserProfile.Business.Services
{
    public class UserProfileBusiness : IUserProfileBusiness
    {
        private static readonly UserProfileBusiness _instance = new UserProfileBusiness();
        public static UserProfileBusiness Instance => _instance;
        private UserProfileBusiness() { }

        public bool SendVerificationEmail(Signup signupDetails)
        {
            try
            {
                // call API url of reference - InnovaSolutions_UserProfile.API.Services and send back response 
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool ValidateLoginDetails(Login loginDetails)
        {
            try
            {
                // call API url of reference - InnovaSolutions_UserProfile.API.Services and send back response 
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool StoreUserDetails(Signup signupDetails)
        {
            try
            {
                // call API url of reference - InnovaSolutions_UserProfile.API.Services and send back response 
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
    }

    public interface IUserProfileBusiness
    {
        bool SendVerificationEmail(Signup signupDetails);
        bool ValidateLoginDetails(Login loginDetails);
        bool StoreUserDetails(Signup signupDetails);
    }
}
