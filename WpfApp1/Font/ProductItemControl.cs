using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Common.control
{

    [TemplatePart(Name = ProductItemPartName, Type = typeof(Grid))]
    public class ProductItemControl : Control
    {
        private const string ProductItemPartName = "PART_ProductItem";

        private Grid _itemPart;

        public ProductItemControl()
        {
            this.DefaultStyleKey = typeof(ProductItemControl);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _itemPart = GetTemplateChild(ProductItemPartName) as Grid;
            _itemPart.MouseDown += this._itemPart_MouseDown;
        }

        public void _itemPart_MouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                if (ProductSelectCommand != null)
                    ProductSelectCommand.Execute(ProductSelectCommandParameter);
            }
        }

        public static readonly DependencyProperty ProductSelectCommandProperty =
            DependencyProperty.Register(
                "ProductSelectCommand",
                typeof(ICommand),
                typeof(ProductItemControl),
                new UIPropertyMetadata(null));

        public ICommand ProductSelectCommand
        {
            get
            {
                return (ICommand)GetValue(ProductSelectCommandProperty);
            }
            set
            {
                SetValue(ProductSelectCommandProperty, value);
            }
        }

        public static readonly DependencyProperty ProductSelectCommandParameterProperty =
            DependencyProperty.Register(
                "ProductSelectCommandParameter",
                typeof(Object),
                typeof(ProductItemControl),
                new UIPropertyMetadata(null));

        public Object ProductSelectCommandParameter
        {
            get
            {
                return (Object)GetValue(ProductSelectCommandParameterProperty);
            }
            set
            {
                SetValue(ProductSelectCommandParameterProperty, value);
            }
        }

    }
}
