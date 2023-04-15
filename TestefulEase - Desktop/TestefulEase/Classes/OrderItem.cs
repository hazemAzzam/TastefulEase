using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestefulEase.Classes
{
    public class OrderItem
    {
        public int id { get; set; }
        public int menu_item { get; set; }
        public MenuItem menu_item_object;
        public int quantity { get; set; }

        public Dictionary<string, string> serialize()
        {
            var data = new Dictionary<string, string>
            {
                {"id", id.ToString() },
                {"menu_item", menu_item.ToString() },
                {"quantity", quantity.ToString() },
            };
            return data;
        }
        public OrderItem()
        {
            menu_item_object= new MenuItem();
        }
    }
}
