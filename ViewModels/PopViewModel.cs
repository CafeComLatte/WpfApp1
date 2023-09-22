using Common.Enum;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Models;
using Database;
using System;
using System.Windows;
using Common;

namespace ViewModels
{
    public class PopViewModel : BaseViewModel
    {
        Product product = new Product();

        private DataItem _item = new DataItem();

        private CustomEnum.Product selectFlag;

        public DataItem Item
        {
            get => _item;
            set => SetProperty(ref _item, value);
        }

        private OriginDataItem _originItem;


        public Boolean DeleteFlag { get; set; }

        

        public PopViewModel(ProductVO product) {
            Console.WriteLine("PopViewModel");
            
            Product = product;
        }

        public ProductVO Product { get; set; }

        private BaseViewModel _popupVM;

        public BaseViewModel PopupVM
        {
            get => _popupVM;
            set => SetProperty(ref _popupVM, value);
        }

        private string _purchaseCount;

        public string PurchaseCount
        {
            get => _purchaseCount;
            set => SetProperty(ref _purchaseCount, value);
        }

        private RelayCommand _closeCommand;
        public RelayCommand CloseCommand
        {
            get
            {
                return _closeCommand ??
                    (_closeCommand = new RelayCommand(
                        () =>
                        {
                            Console.WriteLine("CloseCommand");
                            PopupVM = null;
                        }));
            }
        }

        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return _saveCommand ??
                    (_saveCommand = new RelayCommand(
                        () =>
                        {
                            if (product.updateProductList(Item, _originItem, selectFlag) > 0)
                            {
                                MessageBox.Show("저장 성공!!!", "데이터처리 결과");
                                WeakReferenceMessenger.Default.Send<object, string>("ClosePopup");
                                PopupVM = null;
                            }
                            else
                            {
                                MessageBox.Show("저장 실패", "데이터처리 결과");
                            }

                            WeakReferenceMessenger.Default.Send<object, string>("ClosePopup");
                            PopupVM = null;
                        }));
            }
        }

    }
}
