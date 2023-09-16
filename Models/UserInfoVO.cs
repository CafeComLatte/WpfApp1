using System;

namespace Models
{
    public class UserInfoVO
    {
        public static string Id { get; set; }
        public static string Password { get; set; }
        public static Boolean IsLogin { get; set; }

        public static void clear()
        {
            Id = null; Password = null; IsLogin = false;
        }
    }
}