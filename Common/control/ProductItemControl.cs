using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Common.control
{
    public class ProductItemControl : Button
    {
        public ProductItemControl() { 
            this.DefaultStyleKey = typeof(ProductItemControl);  
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        public string Name
        {
            get { return (string)base.GetValue(NameProperty); }
            set { base.SetValue(NameProperty, value); }
        }

        public static readonly DependencyProperty NameProperty =
          DependencyProperty.Register("Name", typeof(string), typeof(ProductItemControl));

        public string Price
        {
            get { return (string)base.GetValue(PriceProperty); }
            set { base.SetValue(PriceProperty, value); }
        }

        public static readonly DependencyProperty PriceProperty =
          DependencyProperty.Register("Price", typeof(string), typeof(ProductItemControl));

        public string Contents
        {
            get { return (string)base.GetValue(ContentsProperty); }
            set { base.SetValue(ContentsProperty, value); }
        }

        public static readonly DependencyProperty ContentsProperty =
          DependencyProperty.Register("Contents", typeof(string), typeof(ProductItemControl));


        public ImageSource Image
        {
            get { return base.GetValue(ImageProperty) as ImageSource; }
            set { base.SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
          DependencyProperty.Register("Image", typeof(ImageSource), typeof(ProductItemControl));

        public string SysDate
        {
            get { return (string)base.GetValue(SysDateProperty); }
            set { base.SetValue(SysDateProperty, value); }
        }

        public static readonly DependencyProperty SysDateProperty =
          DependencyProperty.Register("SysDate", typeof(string), typeof(ProductItemControl));

    }
}
