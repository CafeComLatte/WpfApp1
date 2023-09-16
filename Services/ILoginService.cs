using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ILoginService
    {
        User UserInfo { get; }
        User UserLogin(string userID, string userPass, out string error);
    }

    public class LoginService : ILoginService
    {
        private User _user = new User();
        public User UserInfo { get => _user; }
        public User UserLogin(string userID, string userPass, out string error)
        {
            error = null;
            User user = new User()
            {
                Id = userID,
                Name = "test",
                Password = userPass
            };

            _user = user;

            return user;
        }
    }
}
