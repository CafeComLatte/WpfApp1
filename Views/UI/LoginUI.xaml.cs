using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Views.UI
{
    /// <summary>
    /// LoginUI.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginUI : UserControl
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void xUserIDHint_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("xUserIDHint_MouseLeftButtonUp");
            this.xUserID.Focus();
            Console.WriteLine(xUserID.Text);
        }

        private void xPasswordHint_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("xPasswordHint_MouseLeftButtonUp");
            this.xPassword.Focus();
        }
    }
}
