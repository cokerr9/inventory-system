using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system
{
    public static class UserDetail
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; }
        public static int UserStatus { get; set; }

        public static void SetUser(int userId, string userName, string userRole, int userStatus)
        {
            UserId = userId;
            UserName = userName;
            UserRole = userRole;
            UserStatus = userStatus;
        }

        public static void Clear()
        {
            UserId = 0;
            UserName = string.Empty;
            UserRole = string.Empty;
            UserStatus = 0;
        }
    }
}
