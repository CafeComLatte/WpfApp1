using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Windows;
using Models;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            UserInfoVO.IsLogin = false;
        }


        private void minimize_button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void maximize_button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.maximize_button.IsChecked == true ? WindowState.Normal : WindowState.Maximized;
        }

        private void shutdown_button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            this.Close();
        }

        private void xMainWindow_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.Name = "test";

            if (user != null)
            {
                Console.WriteLine("bubble test");
            }
        }
    }
}
