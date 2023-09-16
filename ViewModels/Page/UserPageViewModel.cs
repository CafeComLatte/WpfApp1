using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Page
{
    public class UserPageViewModel
    {
        public static IServiceProvider Services;
        public UserPageViewModel(IServiceProvider service) {
            Console.WriteLine("UserPageViewModel 생성자");
            Services = service;
        }
    }
}
