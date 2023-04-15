using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestefulEase.Classes
{
    public class MenuItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string image { get; set; }
        public Image image_data { get; set; }
        public Category[] categories_info { get; set; }

        public async Task LoadImageDataAsync()
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] imageData = await webClient.DownloadDataTaskAsync(image);
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(memoryStream);
                    image_data = image;
                }
            }
        }
    }
}
