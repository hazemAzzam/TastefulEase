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

namespace TestefulEase.UserControls.Payements
{
    public partial class PaymentItemControl : UserControl
    {
        AuthService authService= new AuthService();
        public Order orderItem = new Order();
        public PaymentItemControl()
        {
            InitializeComponent();
        }

        private void PaymentItemControl_Load(object sender, EventArgs e)
        {
            orderDateLbl.Text = orderItem.order_date.ToString();
            numberOfItemsLbl.Text = orderItem.number_of_items.ToString();
            totalBeforeDiscount.Text = orderItem.total_amount.ToString();
            totalAfterDiscount.Text = orderItem.total_amount_after.ToString();
            couponDiscountLbl.Text = (orderItem.discount * 100).ToString() + "%";

            if (orderItem.status == "Paied")
            {
                button1.Visible= false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.order = orderItem.id;
            string json = JsonSerializer.Serialize(payment);
            var response = await authService.SendPostRequest("http://127.0.0.1:8000/api/Payments/", json);
            if (response.StatusCode == 201)
            {
                button1.Visible= false;
            }
        }
    }
}
