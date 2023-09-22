using Common;
using Common.Enum;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using ViewModels.Page;
using System.Threading;

namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        Product product = new Product();

        private readonly IDialogService _dialogService;
        private readonly IUserService _userService;

        private object viewModel;

        public object ViewModel
        {
            get => viewModel;
            set => SetProperty(ref viewModel, value);
        }

        private ObservableCollection<DataItem> data = new ObservableCollection<DataItem>();

        public ObservableCollection<DataItem> Data
        {
            get { return data; }
            set { SetProperty(ref data, value); }

        }

        private string search;
        public string Search
        {
            get => search;
            set
            {
                SetProperty(ref search, value);
            }
        }

        public static IServiceProvider Services;

        public MainViewModel(IDialogService dialogService, IUserService userService, IServiceProvider services)
        {
            Services = services;

            _dialogService = dialogService;
            _userService = userService;

            
            Console.WriteLine("MainViewModel 생성 : " + userService.UserInfo.Id);

            WeakReferenceMessenger.Default.Register<object, string>(this, "ClosePopup", this.ClosePopup);
        }
        private Boolean _loadingShow;
        public Boolean LoadingShow
        {
            get => _loadingShow;
            set => SetProperty(ref _loadingShow, value);
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
            LoadingShow = true;

            await MockUpData.InitMockUpData();

            LoadingShow = false;

            ViewModel = Services.GetService(typeof(MainPageViewModel)) as MainPageViewModel;
        }

        private RelayCommand<DataItem> _productSelectCommand;
        public RelayCommand<DataItem> ProductSelectCommand
        {
            get
            {
                return _productSelectCommand ??
                    (_productSelectCommand = new RelayCommand<DataItem>(this.GoProductDetail));
            }
        }

        private void GoProductDetail(DataItem item)
        {
            Console.WriteLine("상품 버튼 클릭");


            _dialogService.SetSize(500, 500);
            _dialogService.SetVM(new PopViewModel(null),"Product Details");
            _dialogService.Dialog.Show();
        }

        private RelayCommand _registerCommand;
        public RelayCommand RegisterCommand
        {
            get
            {
                return _registerCommand ??
                    (_registerCommand = new RelayCommand(
                        this.RegisterExecute));
            }
        }

        private RelayCommand<string> _sideMenuCommand;
        public RelayCommand<string> SideMenuCommand
        {
            get
            {
                return _sideMenuCommand ??
                    (_sideMenuCommand = new RelayCommand<string>(this.GoMenu));
            }
        }


        private void GoMenu(string MenuName)
        {
            switch (MenuName)
            {
                case "Main":
                    Console.WriteLine($"{MenuName}");
                    ViewModel = Services.GetService(typeof(MainPageViewModel)) as MainPageViewModel;
                    break;
                case "User":
                    Console.WriteLine($"{MenuName}");
                    ViewModel = Services.GetService(typeof(UserPageViewModel)) as UserPageViewModel;
                    break;
                case "Search":
                    Console.WriteLine($"{MenuName}");
                    ViewModel = Services.GetService(typeof(SearchPageViewModel)) as SearchPageViewModel;
                    break;
                case "Purchase":
                    Console.WriteLine($"{MenuName}");
                    ViewModel = Services.GetService(typeof(PurchasePageViewModel)) as PurchasePageViewModel;
                    break;
                default:
                    break;

            }
        }


        private void RegisterExecute()
        {
            Console.WriteLine("RegisterExecute");
            _dialogService.SetSize(500, 500);
            _dialogService.SetVM(new PopViewModel(null),"New Product Registration");
            _dialogService.Dialog.Show();
        }

        private void ClosePopup(object recipient, object str)
        {
            Console.WriteLine("ClosePopup");

            //Data = product.getProductList();

            _dialogService.Dialog.Hide();

        }
    }
}
