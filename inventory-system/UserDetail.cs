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

        public static bool IsAdmin
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UserRole)) return true;
                return UserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                       UserRole.Equals("Super Admin", StringComparison.OrdinalIgnoreCase);
            }
        }

        public static bool IsSuperAdmin
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UserRole)) return true;
                return UserRole.Equals("Super Admin", StringComparison.OrdinalIgnoreCase);
            }
        }

        public static bool CanAccessModule(string module)
        {
            if (IsAdmin) return true;

            switch ((module ?? "").Trim().ToLowerInvariant())
            {
                case "dashboard":
                case "accessory":
                case "purchase":
                case "supplier":
                    return true;
                default:
                    return false;
            }
        }

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
