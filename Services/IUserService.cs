using Models;

namespace Services
{
    public interface IUserService
    {
        User UserInfo { get; set; }
    }

    public class UserService : IUserService
    {
        public UserService(ILoginService loginService) { 
            UserInfo = loginService.UserInfo;
        }

        public User UserInfo { get; set; }
    }
}
