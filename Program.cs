using Thread.Models;

namespace Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

          
            shop.AddOrder(new Order { No = 1, ProductCount = 2, TotalAmount = 100 });
            shop.AddOrder(new Order { No = 2, ProductCount = 3, TotalAmount = 200 });
           

            
            double avgOrderValue = shop.GetOrdersAvg();

            
            

            
            int minPrice = 100;
            int maxPrice = 200;
            List<Order> filteredOrders = shop.FilterOrderByPrice(minPrice, maxPrice);

        }
    }
}