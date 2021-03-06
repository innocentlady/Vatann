using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vatann.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vatann.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMain : ContentPage
    {
        ItemModel ItemModel;
        public PageMain()
        {               
            InitializeComponent();

            List<string> CarouselItems = new List<string>()//fırsatürünlerindeki resim url'leri.
            {
              "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/SE_cep_14-03--mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/11-2021/theone_banner_mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/samsung-s22-buyback-17-03-mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/02-2022/HP_2_notebook_Mobil_Ilan_04.03.22.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/hp-ilan-mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/intel-11700K-mob.jpg",
             };
            FırsatÜrünleriCarousel.ItemsSource = CarouselItems;
            ItemModel = new ItemModel(this);
            BindingContext = ItemModel;
      
        }
        List<string> Items = new List<string>
    {
            "Dominican Republic" , "United States" , "Spain" , "Costa Rica"
    };
        async void Handle_SearchButtonPressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageSearch());
        }
     
        private async void Button_Clicked(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new PageCategory());
        }
        private async void Button_Basket(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageBasket());
        }
        private async void Button_Main(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageMain());
        }
        private async void Button_Hesap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageLogin());
        }
        private async void Button_Diger(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageOthers());
        }

    }
}