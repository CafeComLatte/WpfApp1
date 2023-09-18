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
    public class PurchaseItemControl : Button
    {
        public PurchaseItemControl() { 
            this.DefaultStyleKey = typeof(PurchaseItemControl);   
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        public string ProductName
        {
            get { return (string)base.GetValue(ProductNameProperty); }
            set { base.SetValue(ProductNameProperty, value); }
        }

        public static readonly DependencyProperty ProductNameProperty =
          DependencyProperty.Register("ProductName", typeof(string), typeof(PurchaseItemControl));

        public string SinglePrice
        {
            get { return (string)base.GetValue(SinglePriceProperty); }
            set { base.SetValue(SinglePriceProperty, value); }
        }

        public static readonly DependencyProperty SinglePriceProperty =
          DependencyProperty.Register("SinglePrice", typeof(string), typeof(PurchaseItemControl));

        public string TotalPrice
        {
            get { return (string)base.GetValue(TotalPriceProperty); }
            set { base.SetValue(TotalPriceProperty, value); }
        }

        public static readonly DependencyProperty TotalPriceProperty =
          DependencyProperty.Register("TotalPrice", typeof(string), typeof(PurchaseItemControl));

        public string Count
        {
            get { return (string)base.GetValue(CountProperty); }
            set { base.SetValue(CountProperty, value); }
        }

        public static readonly DependencyProperty CountProperty =
          DependencyProperty.Register("Count", typeof(string), typeof(PurchaseItemControl));



        public string Contents
        {
            get { return (string)base.GetValue(ContentsProperty); }
            set { base.SetValue(ContentsProperty, value); }
        }

        public static readonly DependencyProperty ContentsProperty =
          DependencyProperty.Register("Contents", typeof(string), typeof(PurchaseItemControl));


        public ImageSource Image
        {
            get { return base.GetValue(ImageProperty) as ImageSource; }
            set { base.SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
          DependencyProperty.Register("Image", typeof(ImageSource), typeof(PurchaseItemControl));

        public string PaymentDate
        {
            get { return (string)base.GetValue(PaymentDateProperty); }
            set { base.SetValue(PaymentDateProperty, value); }
        }

        public static readonly DependencyProperty PaymentDateProperty =
          DependencyProperty.Register("PaymentDate", typeof(string), typeof(PurchaseItemControl));

        public string PaymentTime
        {
            get { return (string)base.GetValue(PaymentTimeProperty); }
            set { base.SetValue(PaymentTimeProperty, value); }
        }

        public static readonly DependencyProperty PaymentTimeProperty =
          DependencyProperty.Register("PaymentTime", typeof(string), typeof(PurchaseItemControl));


        public string SysDate
        {
            get { return (string)base.GetValue(SysDateProperty); }
            set { base.SetValue(SysDateProperty, value); }
        }

        public static readonly DependencyProperty SysDateProperty =
          DependencyProperty.Register("SysDate", typeof(string), typeof(PurchaseItemControl));

    }
}
