using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Common.control
{
    public class ReciptItemControl : Button
    {
        public ReciptItemControl() { 
            base.DefaultStyleKey = typeof(ReciptItemControl);   
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }


    }
}
