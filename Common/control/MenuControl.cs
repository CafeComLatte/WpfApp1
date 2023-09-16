using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Common.control
{
    
    public class MenuControl : ListView
    {
        
        public MenuControl() {

            this.DefaultStyleKey = typeof(MenuControl);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            //this.MouseDoubleClick += this.test;
            
        }

        private void test(object sender, MouseButtonEventArgs e)
        {
            var test = (MenuItemVO)((ListView)sender).SelectedItem;
            Console.WriteLine(test.MenuName);

        }

        [TemplatePart(Name = MenuInfoPartName, Type = typeof(ItemsControl))]
        public class MenuItemControl : ItemsControl
        {
            private const string MenuInfoPartName = "PART_Menu";

            public MenuItemControl()
            {
                this.DefaultStyleKey = typeof(MenuItemControl);

            }

            public override void OnApplyTemplate()
            {
                base.OnApplyTemplate();

                Console.WriteLine("Item click");
            }
        }




    }
}
