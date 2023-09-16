using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Xml.Linq;
using System.Configuration;
using System.Windows.Input;

namespace Common.control
{
    [TemplatePart(Name = TestPartName, Type = typeof(Grid))]
    public class MenuItemControl : Control
    {
        private const string TestPartName = "PART_TEST";

        private Grid _itemPart;

        public MenuItemControl()
        {
            this.DefaultStyleKey = typeof(MenuItemControl);

        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();



            _itemPart = GetTemplateChild(TestPartName) as Grid;

            //if (_listViewItemPart is null) return;
            _itemPart.MouseDown += this.itemPart_MouseDown;

        }
        
        private void itemPart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                if (SelectCommand != null)
                    SelectCommand.Execute(SelectCommandParameter);
            }
        }

        public static readonly DependencyProperty SelectCommandProperty =
            DependencyProperty.Register(
                "SelectCommand",
                typeof(ICommand),
                typeof(MenuItemControl),
                new UIPropertyMetadata(null));

        public ICommand SelectCommand
        {
            get
            {
                return (ICommand)GetValue(SelectCommandProperty);
            }
            set
            {
                SetValue(SelectCommandProperty, value);
            }
        }

        public static readonly DependencyProperty SelectCommandParameterProperty =
            DependencyProperty.Register(
                "SelectCommandParameter",
                typeof(Object),
                typeof(MenuItemControl),
                new UIPropertyMetadata(null));

        public Object SelectCommandParameter
        {
            get
            {
                return (Object)GetValue(SelectCommandParameterProperty);
            }
            set
            {
                SetValue(SelectCommandParameterProperty, value);
            }
        }

    }

}
