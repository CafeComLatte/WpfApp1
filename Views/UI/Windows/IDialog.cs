using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views.UI.Windows
{
    public interface IDialog
    {
        
        string Title { get; set; }

        double Width { get; set; }
        double Height { get; set; }
        object DataContext { get; set; }
        void Show();
        void Close();

        void Hide();
        Action CloseCallback { get; set; }
    }

}
