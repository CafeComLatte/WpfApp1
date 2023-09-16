using CommunityToolkit.Mvvm.Messaging.Messages;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.messaging
{
    public class LogOutCompleted : ValueChangedMessage<UserInfoVO>
    {
        public LogOutCompleted(UserInfoVO userInfoVO) : base(userInfoVO) { }
        public string ErrorMessage { get; set; }
    }   
}
