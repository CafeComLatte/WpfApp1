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
    public class SearchPageViewModel : BaseViewModel
    {
        public static IServiceProvider Services;


        public SearchPageViewModel(IServiceProvider service) {
            Services = service;

            ProductVOCollection = new ObservableCollection<ProductVO>(MockUpData.Products);

        }

        private ObservableCollection<ProductVO> _productVOCollection;

        public ObservableCollection<ProductVO> ProductVOCollection
        {
            get => _productVOCollection;
            set => SetProperty(ref _productVOCollection, value);
        } 

    }
}
