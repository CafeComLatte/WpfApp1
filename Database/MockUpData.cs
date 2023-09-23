using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class MockUpData
    {
        public static IList<ProductVO> EventProducts { get; set; } = new List<ProductVO>();

        public static IList<EventContent> EventContents { get; set; } = new List<EventContent>();
        
        public static IList<ProductVO> Products { get; set; } = new List<ProductVO>();

        public static IList<PurchaseVO> Purchases { get; set; } = new List <PurchaseVO>();
        
        public static async Task InitMockUpData()
        {
            await Task.Run(() =>
            {
                Product prod = new Product();
                List<ProductVO> prods = new List<ProductVO>();
                prods = prod.SelectProduct("product");
                Products = prods;
                
                List<ProductVO> eventProds = new List<ProductVO>();
                eventProds = prod.SelectProduct("event_product");
                EventProducts = eventProds;

                EventContentDAO eventContent = new EventContentDAO();
                List<EventContent> eventContents = new List<EventContent>();
                eventContents = eventContent.Select();
                EventContents = eventContents;

                PurchaseDAO purchaseDAO = new PurchaseDAO();
                List<PurchaseVO> purchases = new List<PurchaseVO>();
                purchases = purchaseDAO.Select();

                Purchases = purchases;
                
            });
            
        }
    }
}
