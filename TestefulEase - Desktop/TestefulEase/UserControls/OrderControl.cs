//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestefulEase.Classes;
using System.Text.Json;
using Flurl.Http;
using TestefulEase.Forms;

namespace TestefulEase.UserControls
{
    public partial class OrderControl : UserControl
    {
        AuthService authService = new AuthService();
        public int total_price
        {
            get { return int.Parse(orderPriceLbl.Text); }
            set { orderPriceLbl.Text = value.ToString(); }
        }
        public OrderControl()
        {
            InitializeComponent();
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            Dashboard.order.order_date= DateTime.Now;
            Dashboard.order.customer = Dashboard.customer.id;

            string json = JsonSerializer.Serialize(Dashboard.order);
            var client = new HttpClient();
            string url = "http://127.0.0.1:8000/api/make_order/";

           
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the request and get the response
            HttpResponseMessage response = await client.SendAsync(request);
            string responseBody = await response.Content.ReadAsStringAsync();

        }

        private void OrderControl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel1_VisibleChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            orderDateLbl.Text = DateTime.Now.ToString();
            total_price = 0;
            foreach (OrderItem item in Dashboard.order.order_items)
            {
                OrderMenuItem orderMenuItem = new OrderMenuItem();
                orderMenuItem.orderItem = item;
                total_price += item.menu_item_object.price * item.quantity;
                flowLayoutPanel1.Controls.Add(orderMenuItem);

            }
        }
    }
}
