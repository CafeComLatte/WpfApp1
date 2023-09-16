using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using Services;
using Models;
using ViewModels.Messaging;
using Common;
using System.Windows;

namespace ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly ILoginService _loginService;

        private string _userID;
        public string UserID
        {
            get => _userID;
            set
            {
                SetProperty(ref _userID, value);
                //LoginCommand.NotifyCanExecuteChanged();
            }
        }
        public LoginViewModel(ILoginService loginService) {

            _loginService = loginService;

            Console.WriteLine("LoginViewModel 생성자");

        }


        private RelayCommand _loginCommand;
        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand ??
                    (_loginCommand = new RelayCommand(
                        this.LoginExecute));
            }
        }

        private void LoginExecute()
        {

            MessageBox.Show("Bubble Test", "Yes-No", MessageBoxButton.YesNo);

            Console.WriteLine("Login Click!");

            string error = null;
            User user = _loginService.UserLogin("user", "password", out error);

            Console.WriteLine("ID : " + user.Id + ", Password : " + user.Password);



            WeakReferenceMessenger.Default.Send(new LoginCompleted(user));
        }


    }

    
}
