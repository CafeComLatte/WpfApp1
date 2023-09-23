using Common;
using CommunityToolkit.Mvvm.Input;
using Database;
using Models;
using Services;
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
        public PurchasePageViewModel(IServiceProvider service, IPurchaseDetailsService purchaseDetailsservice) {
            Services = service;

            PurchaseCollection = new ObservableCollection<PurchaseVO>(MockUpData.Purchases);
            
        }
        private ObservableCollection<PurchaseVO> _purchaseCollection;
        public ObservableCollection<PurchaseVO> PurchaseCollection
        {
            get => _purchaseCollection;
            set => SetProperty(ref _purchaseCollection, value);
        }

        private RelayCommand<PurchaseVO> _purchaseSearchCommand;
        public RelayCommand<PurchaseVO> PurchaseSearchCommand
        {
            get
            {
                return _purchaseSearchCommand ??
                    (_purchaseSearchCommand = new RelayCommand<PurchaseVO>(this.PurchaseSearchExecute));
            }
        }

        private void PurchaseSearchExecute(PurchaseVO purchase)
        {
            Console.WriteLine("PurchaseSearchExecute");
        }
    }
}
