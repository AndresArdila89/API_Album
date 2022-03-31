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
        private List<Album> albs = new List<Album>();
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
                albs = JsonConvert.DeserializeObject<List<Album>>(response);
                carouselItems.ItemsSource = albs;

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var id = Convert.ToInt32(((Button)sender).BindingContext);

            foreach (Album album in albs)
            {
                if (album.Id == id)
                {

                    Navigation.PushAsync(new details(album));
                   
                }
            }



        }
    }
}
