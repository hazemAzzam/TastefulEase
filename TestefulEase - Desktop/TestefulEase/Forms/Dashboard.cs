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
using TestefulEase.UserControls;

namespace TestefulEase.Forms
{
    public partial class Dashboard : Form
    {
        static public Customer customer;
        static public Order order;

        MenuControl menuControl = new MenuControl();
        OrderControl orderControl = new OrderControl();
        public static PaymentsControl paymentsControl = new PaymentsControl();

        public Dashboard()
        {
            InitializeComponent();

            order = new Order();

            menuControl.Dock = DockStyle.Fill;
            orderControl.Dock = DockStyle.Fill;
            paymentsControl.Dock = DockStyle.Fill;

            container.Controls.Add(menuControl);
            container.Controls.Add(orderControl);
            container.Controls.Add(paymentsControl);            
        }

        private void FixDashBoard_Load(object sender, EventArgs e)
        {
            customerNameLbl.Text = "Welcome " + customer.first_name + " " + customer.last_name;
            
            orderControl.Hide();
            paymentsControl.Hide();
            menuControl.Show();

            button1.BackColor = Color.FromArgb(61, 33, 37);
            button4.BackColor = Color.FromArgb(26, 25, 23);
            button2.BackColor = Color.FromArgb(26, 25, 23);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderControl.Hide();
            paymentsControl.Hide();
            menuControl.Show();

            button1.BackColor = Color.FromArgb(61, 33, 37);
            button2.BackColor = Color.FromArgb(26, 25, 23);
            button4.BackColor = Color.FromArgb(26, 25, 23);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderControl.Show();
            menuControl.Hide();
            paymentsControl.Hide();

            button2.BackColor = Color.FromArgb(61, 33, 37);
            button4.BackColor = Color.FromArgb(26, 25, 23);
            button1.BackColor = Color.FromArgb(26, 25, 23);
        }
        int mouseX;
        int mouseY;
        bool dragging;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
            dragging = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderControl.Hide();
            menuControl.Hide();
            paymentsControl.Show();

            button4.BackColor = Color.FromArgb(61, 33, 37);
            button1.BackColor = Color.FromArgb(26, 25, 23);
            button2.BackColor = Color.FromArgb(26, 25, 23);
        }
    }
}
