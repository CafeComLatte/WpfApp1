using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Common.control
{
    
    public class ProductListControl : ListView
    {
        

        public ProductListControl()
        {
            this.DefaultStyleKey = typeof(ProductListControl);
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Console.WriteLine("test");

            
        }

        
    }
}
