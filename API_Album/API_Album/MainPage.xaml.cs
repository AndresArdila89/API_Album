using API_Album.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace API_Album
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            fetchAlbum(); 
        }

        public async void fetchAlbum()
        {
            string url = "https://jsonplaceholder.typicode.com/photos";
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                var albums = JsonConvert.DeserializeObject<List<Album>>(response);
                carouselItems.ItemsSource = albums;

            }
        }


    }
}
