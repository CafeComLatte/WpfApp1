using System;
using System.Numerics;
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

        private void xMinusButton_Click(object sender, RoutedEventArgs e)
        {
            Int64 count = Int64.Parse(xCountText.Text.ToString());
            if(count > 0)
            {
                xCountText.Text = (count - 1).ToString();                
            }
        }

        private void xPlusButton_Click(object sender, RoutedEventArgs e)
        {
            Int64 count = Int64.Parse(xCountText.Text.ToString());
            Console.WriteLine(xCountText.Text.ToString());
            if(count < 100)
            {
                
                xCountText.Text = (count + 1).ToString();
            }
        }
    }
}