using System;
using System.Windows;

namespace Views.UI.Windows
{
    /// <summary>
    /// PopWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PopWindow : Window, IDialog
    {

        public Action CloseCallback { get; set; }

        public PopWindow()
        {
            InitializeComponent();
        }

        private void xCloseButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("xCloseButton_Click");
            if (CloseCallback != null)
                CloseCallback();

            this.Hide();
        }

    }
}