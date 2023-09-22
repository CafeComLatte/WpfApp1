using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Page
{
    public class SearchDetailsPageViewModel
    {
        public static IServiceProvider Services;
        public SearchDetailsPageViewModel(IServiceProvider service) { 
            Services = service;
        }

    }
}
