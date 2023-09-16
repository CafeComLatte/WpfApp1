using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Windows;
using ViewModels;
using ViewModels.Page;
using Views.UI.Windows;

namespace WpfApp1
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        
        public App()
        {
            Services = ConfigureService();

        }

        public static IServiceProvider Services { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            MainWindow window = new MainWindow();

            CommonViewModel model = new CommonViewModel(Services);
            model.ViewModel = Services.GetService(typeof(LoginViewModel)) as LoginViewModel;
            window.DataContext = model;
            window.ShowDialog();

            model.dispose();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }


        private static IServiceProvider ConfigureService()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IDialogService, DialogService>();
            services.AddSingleton<ILoginService, LoginService>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IDialog, PopWindow>();

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<ResultViewModel>();

            services.AddSingleton<MainPageViewModel>();
            services.AddSingleton<UserPageViewModel>();
            services.AddSingleton<SearchPageViewModel>();
            services.AddSingleton<PurchasePageViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
