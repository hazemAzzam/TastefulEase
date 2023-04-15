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
using TestefulEase.Forms;

namespace TestefulEase.UserControls
{
    public partial class OrderMenuItem : UserControl
    {

        public OrderItem orderItem;
        public OrderMenuItem()
        {
            InitializeComponent();
        }

        private void OrderMenuItem_Load(object sender, EventArgs e)
        {
            itemPictureBox.Image = orderItem.menu_item_object.image_data;
            textBox1.Text = orderItem.menu_item_object.name;
            textBox1.Text += Environment.NewLine + orderItem.menu_item_object.description;
            textBox1.Text += Environment.NewLine + orderItem.menu_item_object.price.ToString() + "$";
            quantity.Text = orderItem.quantity.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderItem.quantity++;
            Dashboard.order.total_price += orderItem.menu_item_object.price;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderItem.quantity--;
            Dashboard.order.total_price -= orderItem.menu_item_object.price;


        }
    }
}
