using Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Views.UI
{
    /// <summary>
    /// ProductDetailControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProductDetailUI : UserControl
    {
        public ObservableCollection<DataItem> Data
        {
            get { return (ObservableCollection<DataItem>)GetValue(TitleValueProperty); }
            set { SetValue(TitleValueProperty, value); }
        }
        public static readonly DependencyProperty TitleValueProperty =
          DependencyProperty.Register("Data", typeof(ObservableCollection<DataItem>), typeof(ProductDetailUI), new PropertyMetadata(null));


        public ProductDetailUI()
        {
            InitializeComponent();

            
        }
    }
}
