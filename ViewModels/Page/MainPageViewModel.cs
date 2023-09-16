using Common;
using CommunityToolkit.Mvvm.Input;
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
        Queue<EventProduct> list;
        public MainPageViewModel() {
            Console.WriteLine("MainPageViewModel 생성자 ");

            EventProductCollection = new ObservableCollection<EventProduct>();

            list = new Queue<EventProduct>();

            list.Enqueue(new EventProduct { Id = "1", Name="마카롱", Price="5,000원", Image= "/Common;component/Images/" + "macarons.jpg"});
            list.Enqueue(new EventProduct { Id = "2", Name = "펜케이크", Price="3,000원", Image = "/Common;component/Images/" + "pancakes.jpg" });
            list.Enqueue(new EventProduct { Id = "3", Name = "커피케이크", Price="7,000원", Image = "/Common;component/Images/" + "cake.jpg" });
            list.Enqueue(new EventProduct { Id = "4", Name = "크루아상", Price = "5,000원", Image = "/Common;component/Images/" + "croissant.jpg" });
            list.Enqueue(new EventProduct { Id = "5", Name = "라떼", Price = "3,000원", Image = "/Common;component/Images/" + "latte.jpg" });

            EventProductCollection.Add(new EventProduct { Id = "1", Name = "마카롱", Price = "5,000원", Image = "/Common;component/Images/" + "macarons.jpg" });
            EventProductCollection.Add(new EventProduct { Id = "2", Name = "펜케이크", Price = "3,000원", Image = "/Common;component/Images/" + "pancakes.jpg" });
            EventProductCollection.Add(new EventProduct { Id = "3", Name = "커피케이크", Price = "7,000원", Image = "/Common;component/Images/" + "cake.jpg" });
            EventProductCollection.Add(new EventProduct { Id = "4", Name = "크루아상", Price = "5,000원", Image = "/Common;component/Images/" + "croissant.jpg" });
            for(int i=0; i<4; i++)
            {
                EventProductCollection.Add(list.ToArray().ToList()[i]);
            }

            EventContentCollection = new ObservableCollection<EventContent>();
            EventContentCollection.Add(new EventContent { Image = "/Common;component/Images/event1.png" });
        }

        private ObservableCollection<EventProduct> _eventProductCollection;
        public ObservableCollection<EventProduct> EventProductCollection {
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
                list.Dequeue();
                list.Enqueue(EventProductCollection[i]);
                
            }
            
            EventProductCollection.Clear();
            
            for (int i = 0; i < 4; i++)
            {
                EventProductCollection.Add(list.ToArray().ToList()[i]);
            }

        }

    }

    public class EventContent
    {
        public string Image { get; set; }   
    }

    public class EventProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Price { get; set; }

        public string Image { get; set; }
    }
}
