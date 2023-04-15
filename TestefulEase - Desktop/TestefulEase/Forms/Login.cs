using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using TestefulEase.Classes;

namespace TestefulEase.Forms
{
    public partial class Login : Form
    {
        AuthService authService = new AuthService();
        
        public Login()
        {
            InitializeComponent();
        }

        
        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Dictionary<string, string>
            {
                {"phone_number", phoneNumberTxt.Text },
                {"password", passwordTxt.Text }
            };
            var responseContent = await authService.SendPostRequestAsync("http://127.0.0.1:8000/api/login/", data);

            if (responseContent != null)
            {
                var customer = JsonConvert.DeserializeObject<Customer>(responseContent);
                
                Dashboard dashboard = new Dashboard();

                Dashboard.customer = customer;
                
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("null");
            }
        }
    }
}
