using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread.Models
{
    public class Shop
    {
        private List<Order> Orders = new List<Order>();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            double sumPrice = 0;
         
            foreach (Order order in Orders)
            {
                sumPrice+= order.TotalAmount;
                
            }
            return sumPrice/Orders.Count;
        }
        //public void GetOrdersAvg(DateTime dateTime)
        //{
        //    foreach (Order order in Orders)
        //    {

        //    }

        //}
        public void RemoveOrderByNo(int no)
        {
            Orders.RemoveAll(order=>order.No == no);   
               

        }
        public List<Order> FilterOrderByPrice(int minPrice,int maxprice)
        {
            List<Order> filteredOrders = new List<Order>();
            foreach (Order order in Orders)
            {
                if (order.TotalAmount>minPrice && order.TotalAmount<maxprice)
                {
                    filteredOrders.Add(order);
                }
            }
            return filteredOrders;

        }



    }
}
