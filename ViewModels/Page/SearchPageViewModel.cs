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

            ProductVOCollection = new ObservableCollection<ProductVO>();

            GetProduct();
        }

        private ObservableCollection<ProductVO> _productVOCollection;

        public ObservableCollection<ProductVO> ProductVOCollection
        {
            get => _productVOCollection;
            set => SetProperty(ref _productVOCollection, value);
        } 

        private void GetProduct()
        {
            ProductVOCollection.Add(new ProductVO { Id = "1", Name = "마카롱", Price = "5,000원", Image = "/Common;component/Images/" + "macarons.jpg", Contents = "엄청 달콤한 딸기 마카롱입니다.", SysDate="20230916" });
            ProductVOCollection.Add(new ProductVO { Id = "2", Name = "펜케이크", Price = "3,000원", Image = "/Common;component/Images/" + "pancakes.jpg", Contents = "유기농 연유와 딸기를 섞은 펜케이크입니다.", SysDate = "20230916" });
            ProductVOCollection.Add(new ProductVO { Id = "3", Name = "커피케이크", Price = "7,000원", Image = "/Common;component/Images/" + "cake.jpg", Contents = "커피와 초콜릿을 섞은 커피케이크입니다.", SysDate = "20230916" });
            ProductVOCollection.Add(new ProductVO { Id = "4", Name = "크루아상", Price = "5,000원", Image = "/Common;component/Images/" + "croissant.jpg", Contents = "담백하고 달콤한 크루아상입니다.", SysDate = "20230916" });
            ProductVOCollection.Add(new ProductVO { Id = "5", Name = "라떼", Price = "3,000원", Image = "/Common;component/Images/" + "latte.jpg", Contents = "유기농 우유를 사용하여 고소한 맛이 나는 라떼입니다.", SysDate = "20230916" });
            ProductVOCollection.Add(new ProductVO { Id = "6", Name = "아이스커피", Price = "2,500원", Image = "/Common;component/Images/" + "icecoffee.jpg", Contents = "커피믹스와 고소한 커피를 섞은 아이스커피입니다.", SysDate = "20230916" });
            ProductVOCollection.Add(new ProductVO { Id = "7", Name = "아메리카노", Price = "2,500원", Image = "/Common;component/Images/" + "americano.jpg", Contents = "고소하고 풍미가 느껴지는 아메리카노입니다.", SysDate = "20230916" });
            ProductVOCollection.Add(new ProductVO { Id = "8", Name = "초콜릿케이크", Price = "5,000원", Image = "/Common;component/Images/" + "chocolatecake.jpg", Contents = "고급 초콜릿을 사용한 담백하고 달콤한 초콜릿케이크입니다.", SysDate = "20230916" });

        }
    }
}
