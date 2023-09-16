using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Models;

namespace Views.UI
{
    /// <summary>
    /// PopupWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PopupWindow : Window
    {
        

        public PopupWindow(DataItem item)
        {

            Console.WriteLine("Product Name : " + item.ProductName);
            Console.WriteLine("Process : " + item.Process);
            Console.WriteLine("Weight : " + item.Weight);
            Console.WriteLine("Height : " + item.Height);
            Console.WriteLine("Register : " + item.Register);

            this.DataContext = item;

            InitializeComponent();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
