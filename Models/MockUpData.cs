using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MockUpData
    {
        public static IList<EventProduct> EventProducts { get; set; } = new List<EventProduct>();

        public static IList<EventContent> EventContents { get; set; } = new List<EventContent>();
        
        public static IList<ProductVO> Products { get; set; } = new List<ProductVO>();

        public static IList<PurchaseVO> Purchases { get; set; } = new List <PurchaseVO>();
        
        public static async Task InitMockUpData()
        {
            await Task.Run(() =>
            {
                EventProducts.Add(new EventProduct { Id = "1", Name = "마카롱", Price = "5,000원", Image = "/Common;component/Images/" + "macarons.jpg" });
                EventProducts.Add(new EventProduct { Id = "2", Name = "펜케이크", Price = "3,000원", Image = "/Common;component/Images/" + "pancakes.jpg" });
                EventProducts.Add(new EventProduct { Id = "3", Name = "커피케이크", Price = "7,000원", Image = "/Common;component/Images/" + "cake.jpg" });
                EventProducts.Add(new EventProduct { Id = "4", Name = "크루아상", Price = "5,000원", Image = "/Common;component/Images/" + "croissant.jpg" });
                EventProducts.Add(new EventProduct { Id = "5", Name = "라떼", Price = "3,000원", Image = "/Common;component/Images/" + "latte.jpg" });

                EventContents.Add(new EventContent { Image = "/Common;component/Images/event1.png" });

                Products.Add(new ProductVO { Id = "1", Name = "마카롱", Price = "5,000원", Image = "/Common;component/Images/" + "macarons.jpg", Contents = "엄청 달콤한 딸기 마카롱입니다.", SysDate = "20230916" });
                Products.Add(new ProductVO { Id = "2", Name = "펜케이크", Price = "3,000원", Image = "/Common;component/Images/" + "pancakes.jpg", Contents = "유기농 연유와 딸기를 섞은 펜케이크입니다.", SysDate = "20230916" });
                Products.Add(new ProductVO { Id = "3", Name = "커피케이크", Price = "7,000원", Image = "/Common;component/Images/" + "cake.jpg", Contents = "커피와 초콜릿을 섞은 커피케이크입니다.", SysDate = "20230916" });
                Products.Add(new ProductVO { Id = "4", Name = "크루아상", Price = "5,000원", Image = "/Common;component/Images/" + "croissant.jpg", Contents = "담백하고 달콤한 크루아상입니다.", SysDate = "20230916" });
                Products.Add(new ProductVO { Id = "5", Name = "라떼", Price = "3,000원", Image = "/Common;component/Images/" + "latte.jpg", Contents = "유기농 우유를 사용하여 고소한 맛이 나는 라떼입니다.", SysDate = "20230916" });
                Products.Add(new ProductVO { Id = "6", Name = "아이스커피", Price = "2,500원", Image = "/Common;component/Images/" + "icecoffee.jpg", Contents = "커피믹스와 고소한 커피를 섞은 아이스커피입니다.", SysDate = "20230916" });
                Products.Add(new ProductVO { Id = "7", Name = "아메리카노", Price = "2,500원", Image = "/Common;component/Images/" + "americano.jpg", Contents = "고소하고 풍미가 느껴지는 아메리카노입니다.", SysDate = "20230916" });
                Products.Add(new ProductVO { Id = "8", Name = "초콜릿케이크", Price = "5,000원", Image = "/Common;component/Images/" + "chocolatecake.jpg", Contents = "고급 초콜릿을 사용한 담백하고 달콤한 초콜릿케이크입니다.", SysDate = "20230916" });

                Purchases.Add(new PurchaseVO { PaymentDate = "20230918", PaymentTime = "1450", SysDate = "20230916", ProductName = "아메리카노", Contents = "고소하고 풍미가 느껴지는 아메리카노입니다.", Count = "5", Price = "2,500원", TotalPrice = "12,500원", Image = "/Common;component/Images/americano.jpg" });

            });
            
        }
    }
}
