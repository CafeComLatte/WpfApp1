using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views.UI.Windows;

namespace Services
{
    public interface IPurchaseDetailsService
    {

        Views.UI.Windows.IPurchaseDetailsDialog PurchaseDetailsDialog { get; }

        void SetSize(double width, double height);
        void SetVM(BaseViewModel vm, string title);
    }

    public class PurchaseDetailsService : IPurchaseDetailsService {
        private readonly IPurchaseDetailsDialog _popWindow;

        public PurchaseDetailsService(IPurchaseDetailsDialog window) { 
            _popWindow = window;
        }

        public IPurchaseDetailsDialog PurchaseDetailsDialog => _popWindow;

        public void SetSize(double width, double height)
        {
            _popWindow.Width = width;
            _popWindow.Height = height;
        }

        public void SetVM(BaseViewModel vm, string title)
        {
            
            _popWindow.DataContext = vm;
            _popWindow.Title = title;


        }
    }
}
