using Common;
using Common.Enum;
using CommunityToolkit.Mvvm.Input;
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
    public class SearchPageViewModel : BaseViewModel
    {
        public static IServiceProvider Services;
        private readonly IDialogService _dialogService;

        public SearchPageViewModel(IServiceProvider service, IDialogService dialogService) {
            Services = service;
            _dialogService = dialogService;

            ProductVOCollection = new ObservableCollection<ProductVO>(MockUpData.Products);

        }

        private ObservableCollection<ProductVO> _productVOCollection;

        public ObservableCollection<ProductVO> ProductVOCollection
        {
            get => _productVOCollection;
            set => SetProperty(ref _productVOCollection, value);
        }

        private RelayCommand<ProductVO> _productSearchCommand;
        public RelayCommand<ProductVO> MyProductSearchCommand
        {
            get
            {
                return _productSearchCommand ??
                    (_productSearchCommand = new RelayCommand<ProductVO>(this.ProductSearchExecute));
            }
        }

        private void ProductSearchExecute(ProductVO product)
        {
            Console.WriteLine("ProductSearchExecute");
            if (product != null) {
                _dialogService.SetSize(900, 350);
                _dialogService.SetVM(new PopViewModel(product), "Product Details");
                _dialogService.Dialog.Show();
            }
        }
    }
}
