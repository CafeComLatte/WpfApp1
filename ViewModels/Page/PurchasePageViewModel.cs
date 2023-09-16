using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Page
{
    public class PurchasePageViewModel : BaseViewModel
    {
        public static IServiceProvider Services;
        public PurchasePageViewModel(IServiceProvider service) {
            Services = service;
        }

    }
}
