using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestefulEase.Classes;
using TestefulEase.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TestefulEase.UserControls
{
    public partial class MenuItemControl : UserControl
    {
        public MenuItem menuItem;
        OrderItem orderItem = new OrderItem();

        private int item_quantity
        {
            get { return orderItem.quantity; }
            set { 
                orderItem.quantity = value;
                quantity.Text = value.ToString(); 
            }
        }
        public MenuItemControl()
        {
            InitializeComponent();
        }

        private void MenuItemControl_Load(object sender, EventArgs e)
        {
            textBox1.Text = menuItem.name;
            textBox1.Text += Environment.NewLine + menuItem.description;
            textBox1.Text += Environment.NewLine + menuItem.price.ToString() +"$";
            itemPictureBox.Image = menuItem.image_data;

        }

        private void itemOrderBtn_Click(object sender, EventArgs e)
        {
            orderItem.menu_item = menuItem.id;
            orderItem.menu_item_object = menuItem;
            orderItem.quantity = int.Parse(quantity.Text);
            Dashboard.order.add_item(orderItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            item_quantity += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item_quantity -= 1;
        }
    }
}
