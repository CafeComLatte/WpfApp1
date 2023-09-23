using Common;
using CommunityToolkit.Mvvm.Input;
using Database;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media.Animation;

namespace ViewModels.Page
{
    public class MainPageViewModel : BaseViewModel
    {
        Queue<ProductVO> TotalEventProductlist;
        public MainPageViewModel() {
            Console.WriteLine("MainPageViewModel 생성자 ");

            TotalEventProductlist = new Queue<ProductVO>(MockUpData.EventProducts);
            EventProductCollection = new ObservableCollection<ProductVO>(MockUpData.EventProducts.Take(4).ToList());
            
            EventContentCollection = new ObservableCollection<EventContent>(MockUpData.EventContents);
        }

        private ObservableCollection<ProductVO> _eventProductCollection;
        public ObservableCollection<ProductVO> EventProductCollection {
            get => _eventProductCollection;
            set => SetProperty(ref _eventProductCollection, value);
        }

        private ObservableCollection<EventContent> _eventContentCollection;

        public ObservableCollection<EventContent> EventContentCollection
        {
            get => _eventContentCollection;
            set => SetProperty(ref _eventContentCollection, value);
        }

        private RelayCommand _btnCommand;
        public RelayCommand BtnCommand
        {
            get
            {
                return _btnCommand ??
                    (_btnCommand = new RelayCommand(
                        this.BtnExecute));
            }
        }

        private void BtnExecute()
        {
            for (int i = 0; i < 4; i++)
            {
                TotalEventProductlist.Dequeue();
                TotalEventProductlist.Enqueue(EventProductCollection[i]);
                
            }
            
            EventProductCollection.Clear();
            
            for (int i = 0; i < 4; i++)
            {
                EventProductCollection.Add(TotalEventProductlist.ToArray().ToList()[i]);
            }

        }

    }

}
