using Common;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Models;
using Services;
using Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ViewModels.Messaging;


namespace ViewModels
{
    public class CommonViewModel : BaseViewModel
    {
        public static IServiceProvider Services { get; private set; }

        private IDialogService _dialogService;

        List<MenuItemVO> list = new List<MenuItemVO>();



        public CommonViewModel(IServiceProvider services) {
            Console.WriteLine("CommonViewModel 생성자 시작");  

            Services = services;

            //_dialogService = Services.GetService<IDialogService>();
            _dialogService = Services.GetService(typeof(Services.IDialogService)) as Services.IDialogService;
            /*
                        AutoLogOffHelper.LogOffTime = 1;
                        AutoLogOffHelper.MakeAutoLogOffEvent +=
                           new AutoLogOffHelper.MakeAutoLogOff(test);
                        AutoLogOffHelper.StartAutoLogoffOption();
            */

            WeakReferenceMessenger.Default.Register<LoginCompleted>(this, this.SetMenu);
            
            Console.WriteLine("CommonViewModel 생성자 끝");
        }

        private void test()
        {
            Console.WriteLine("test");
        }

        private AsyncRelayCommand _loadedCommand;
        public AsyncRelayCommand LoadedCommand
        {
            get
            {
                return _loadedCommand ??
                    (_loadedCommand = new AsyncRelayCommand(
                        this.LoadedExecute));
            }
        }

        private async Task LoadedExecute()
        {
            Console.WriteLine("LoadedExecute Start ");
            /*
            list.Clear();

            await Task.Run(() =>
            {
                MainMenu mainMenu = new MainMenu();
                list = mainMenu.getMenuList();
                
            });
            MenuItemVO.Clear();
            list.ForEach(item => { MenuItemVO.Add(item); });
            */
            Console.WriteLine("LoadedExecute End ");
        }

        private object viewModel;

        public object ViewModel
        {
            get => viewModel;
            set => SetProperty(ref viewModel, value);
        }

        private ObservableCollection<MenuItemVO> menuItemVO = new ObservableCollection<MenuItemVO>();

        public ObservableCollection<MenuItemVO> MenuItemVO
        {
            get { return menuItemVO; }
            set { SetProperty(ref menuItemVO, value); }
        }

        public void dispose()
        {
            Console.WriteLine("CommonViewModel.dispose()");

            ViewModel = null;
        }


        private void SetMenu(object recipient, LoginCompleted loginCompleted)
        {
            Console.WriteLine("Go MainViewModel");

            ViewModel = Services.GetService(typeof(MainViewModel)) as MainViewModel;
            
        }

    }
}
