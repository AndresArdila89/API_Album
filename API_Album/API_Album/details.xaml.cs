using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Album.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace API_Album
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class details : ContentPage
    {
/*        public details()
        {
            InitializeComponent();
        }
*/
        public details(Album album)
        {
            InitializeComponent();
            title.Text = album.Title;
            id.Text = album.Id.ToString();
            albumId.Text = album.AlbumId.ToString();
            urlImage.Source = album.Url;
            url.Text = album.Url;


        }
    }
}