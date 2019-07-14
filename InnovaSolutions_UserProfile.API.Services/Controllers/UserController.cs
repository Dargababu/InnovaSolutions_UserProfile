using InnovaSolutions_UserProfile.API.Services.Models;
using InnovaSolutions_UserProfile.API.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InnovaSolutions_UserProfile.API.Services.Controllers
{
    [RoutePrefix("user")]
    public class UserController : ApiController
    {
        private readonly IUserService service = null;
        public UserController()
        {
            service = new UserService();
        }

        [HttpPost]
        [Route("login/validate")]
        public async Task<IHttpActionResult> ValidateLoginDetails([FromBody]Login loginDetails)
        {
            bool isValidated = await service.ValidateLoginDetails(loginDetails);
            return Json(new { IsValidated = isValidated });
        }

        [HttpPost]
        [Route("signup/verify")]
        public async Task<IHttpActionResult> SendVerificationEmail([FromBody]Signup signDetails)
        {
            bool isVerified = await service.SendVerificationEmail(signDetails);
            return Json(new { IsVerified = isVerified });
        }

        [HttpPost]
        [Route("user/insert")]
        public async Task<IHttpActionResult> StoreUserDetails([FromBody]Signup signDetails)
        {
            bool isInserted = await service.StoreUserDetails(signDetails);
            return Json(new { IsInserted = isInserted });
        }
    }
}
