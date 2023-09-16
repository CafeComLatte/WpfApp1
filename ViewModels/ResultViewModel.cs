using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ResultViewModel : BaseViewModel
    {
        public static IServiceProvider Services;

        public ResultViewModel(IServiceProvider service) { 
            Services = service;
        }


    }
}
