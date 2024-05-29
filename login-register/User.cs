using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_register
{
    public class User {
        private static User userInstance;

        private string username;
        private string fullName;
        private string pfp;
        private bool is_author;

        private User() { 
            username = string.Empty;
            fullName = string.Empty;
            pfp = string.Empty;
            is_author = false;
        }

        public static User RequestUser
        {
            get {
                if (userInstance == null)
                {
                   userInstance = new User();
                }
                return userInstance;
            }
        }

        public static string GetUsername() { return userInstance.username; }
        public static string GetFullName() { return userInstance.fullName; }
        public static string GetProfilePic() { return userInstance.pfp; }
        public static bool GetAuthor() { return userInstance.is_author; }

        public static void SetUsername(string username) { userInstance.username = username; }
        public static void SetFullName(string fullName) { userInstance.fullName = fullName; }
        public static void SetProfilePic(string pfp) { userInstance.pfp = pfp; }
        public static void SetAuthor(bool is_author) { userInstance.is_author = is_author; }
    }
}
