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
    public class EventProductItemControl : Button
    {
        public EventProductItemControl()
        {
            this.DefaultStyleKey = typeof(EventProductItemControl);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        public string IConName
        {
            get { return (string)base.GetValue(IConNameProperty); }
            set { base.SetValue(IConNameProperty, value); }
        }

        public static readonly DependencyProperty IConNameProperty =
          DependencyProperty.Register("IConName", typeof(string), typeof(EventProductItemControl));

        public string IConPrice
        {
            get { return (string)base.GetValue(IConPriceProperty); }
            set { base.SetValue(IConPriceProperty, value); }
        }

        public static readonly DependencyProperty IConPriceProperty =
          DependencyProperty.Register("IConPrice", typeof(string), typeof(EventProductItemControl));

        public ImageSource IConImage
        {
            get { return base.GetValue(IconImageProperty) as ImageSource; }
            set { base.SetValue(IconImageProperty, value); }
        }

        public static readonly DependencyProperty IconImageProperty =
          DependencyProperty.Register("IConImage", typeof(ImageSource), typeof(EventProductItemControl));

        public ImageSource MouseOverIConImage
        {
            get { return base.GetValue(MouseOverIConImageProperty) as ImageSource; }
            set { base.SetValue(MouseOverIConImageProperty, value); }
        }

        public static readonly DependencyProperty MouseOverIConImageProperty =
          DependencyProperty.Register("MouseOverIConImage", typeof(ImageSource), typeof(EventProductItemControl));

    }
}
