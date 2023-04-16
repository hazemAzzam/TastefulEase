using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestefulEase.Classes
{
    public class Order
    {
        public int id { get; set; } 
        public int customer { get; set; }
        public DateTime order_date { get; set; }
        public OrderItem[] order_items { get; set; }
        public int total_amount { get; set; }
        public int number_of_items { get; set; }
        public string status { get; set; }

        public Order()
        {
            total_amount = 0;
            order_items = new OrderItem[0];
        }
        public void add_item(OrderItem orderItem)
        {
            int newLength = order_items.Length + 1;
            OrderItem[] newArray = new OrderItem[newLength];

            Array.Copy(order_items, newArray, order_items.Length);

            newArray[newLength - 1] = orderItem;

            order_items = newArray;
        }
    }
}
