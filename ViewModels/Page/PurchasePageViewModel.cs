using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            PurchaseCollection = new ObservableCollection<PurchaseVO>(MockUpData.Purchases);
            
        }
        private ObservableCollection<PurchaseVO> _purchaseCollection;
        public ObservableCollection<PurchaseVO> PurchaseCollection
        {
            get => _purchaseCollection;
            set => SetProperty(ref _purchaseCollection, value);
        }

    }
}
