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
using Newtonsoft.Json;
using TestefulEase.UserControls.Payements;

namespace TestefulEase.Forms
{
    public partial class PaymentsControl : UserControl
    {
        public FlowLayoutPanel FlowLayoutPanel1 { get { return flowLayoutPanel1; } }
        AuthService authService= new AuthService();
        static public List<Order> orders = new List<Order>();

        public PaymentsControl()
        {
            InitializeComponent();
        }

        private async void PaymentsControl_Load(object sender, EventArgs e)
        {
            
        }

        private async void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {   
            
        }

        private async void PaymentsControl_VisibleChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var data = await authService.GetRquestAsync("http://127.0.0.1:8000/api/orders/");
            orders = JsonConvert.DeserializeObject<List<Order>>(data);
            foreach (var order in orders)
            {
                PaymentItemControl paymentItemControl = new PaymentItemControl();
                paymentItemControl.orderItem = order;
                flowLayoutPanel1.Controls.Add(paymentItemControl);
            }
        }
    }
}
