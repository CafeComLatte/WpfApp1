using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Common.control
{

    public class ProductItemControl : Control
    {


        
        public ProductItemControl() { 
            this.DefaultStyleKey = typeof(ProductItemControl);  
        
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            base.MouseDown += this.CustomMouseDown;
        }

        private void CustomMouseDown(object sender, MouseButtonEventArgs e)
        {
            ProductSearchCommand.Execute(ProductSearchCommandParameter);
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



        

        public static readonly DependencyProperty ProductSearchCommandProperty =
                DependencyProperty.Register(
                    "ProductSearchCommand",
                    typeof(ICommand),
                    typeof(ProductItemControl),
                    new UIPropertyMetadata(null));

        public ICommand ProductSearchCommand
        {
            get
            {
                return (ICommand)GetValue(ProductSearchCommandProperty);
            }
            set
            {
                SetValue(ProductSearchCommandProperty, value);
            }
        }

        public static readonly DependencyProperty ProductSearchCommandParameterProperty =
                DependencyProperty.Register(
                    "ProductSearchCommandParameter",
                    typeof(Object),
                    typeof(ProductItemControl),
                    new UIPropertyMetadata(null));

        public Object ProductSearchCommandParameter
        {
            get
            {
                return (Object)GetValue(ProductSearchCommandParameterProperty);
            }
            set
            {
                SetValue(ProductSearchCommandParameterProperty, value);
            }
        }

    }
}
