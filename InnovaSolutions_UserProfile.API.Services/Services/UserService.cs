using InnovaSolutions_UserProfile.API.Services.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace InnovaSolutions_UserProfile.API.Services.Services
{
    public class UserService : IUserService
    {
        private readonly string _connectionString = string.Empty;
        public UserService()
        {
            _connectionString = DataConnection.GetConnectionString();
        }
        public async Task<bool> SendVerificationEmail(Signup signDetails)
        {
            bool isSent = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(SPDetail.SPInfo.SP_VerifySignup, connection);
                    connection.Open();
                    // todo opeartion to get information and sent back to the request
                }
            }
            catch (Exception)
            {

                throw;
            }
            return isSent;
        }

        public async Task<bool> StoreUserDetails(Signup signDetails)
        {
            bool isInserted = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(SPDetail.SPInfo.SP_InsertUser, connection);
                    connection.Open();
                    // todo opeartion to get information and sent back to the request
                }
            }
            catch (Exception)
            {

                throw;
            }
            return isInserted;
        }

        public async Task<bool> ValidateLoginDetails(Login loginDetails)
        {
            bool isValidated = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(SPDetail.SPInfo.SP_ValidateLogin, connection);
                    connection.Open();
                    // todo opeartion to get information and sent back to the request
                }
            }
            catch (Exception)
            {

                throw;
            }
            return isValidated;
        }
    }
    public  interface IUserService
    {
        Task<bool> ValidateLoginDetails(Login loginDetails);
        Task<bool> SendVerificationEmail(Signup signDetails);
        Task<bool> StoreUserDetails(Signup signDetails);
    }
}