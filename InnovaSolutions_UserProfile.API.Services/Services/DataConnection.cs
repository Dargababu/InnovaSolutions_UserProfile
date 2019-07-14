using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InnovaSolutions_UserProfile.API.Services.Services
{
    public static class DataConnection
    {
        
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["CCDDbConnection"].ConnectionString;
        }
        
    }
}