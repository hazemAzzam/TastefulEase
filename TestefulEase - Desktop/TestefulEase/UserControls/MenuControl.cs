using Newtonsoft.Json;
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

namespace TestefulEase.UserControls
{
    public partial class MenuControl : UserControl
    {
        AuthService authService = new AuthService();
        public MenuControl()
        {
            InitializeComponent();
        }

        private async void MenuControl_Load(object sender, EventArgs e)
        {
            var responseContent = await authService.GetRquestAsync("http://127.0.0.1:8000/api/menu_items/");

            if (responseContent != null)
            {
                var menuItems = JsonConvert.DeserializeObject<List<MenuItem>>(responseContent); 
                foreach(MenuItem item in menuItems)
                {
                    MenuItemControl menuItem = new MenuItemControl();
                    menuItem.menuItem = item;
                    await item.LoadImageDataAsync();

                    flowLayoutPanel1.Controls.Add(menuItem);
                }
            }
        }
    }
}
