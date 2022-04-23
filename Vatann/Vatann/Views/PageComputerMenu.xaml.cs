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
    public partial class PageComputerMenu : ContentPage
    {
        ItemComputer ItemModel;
        public PageComputerMenu()
        {
            InitializeComponent(); List<string> CarouselItems = new List<string>()//fırsatürünlerindeki resim url'leri.
            {
              "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/SE_cep_14-03--mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/11-2021/theone_banner_mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/samsung-s22-buyback-17-03-mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/02-2022/HP_2_notebook_Mobil_Ilan_04.03.22.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/hp-ilan-mob.jpg",
             "https://cdn.vatanbilgisayar.com/Upload/BANNER//yeni-tasarim/anasayfa/03-2022/intel-11700K-mob.jpg",
             };
            FırsatÜrünleriCarousel.ItemsSource = CarouselItems;
            ItemModel = new ItemComputer(this);
            BindingContext = ItemModel;
        }
        private async void Button_Page(object sender, EventArgs e)
        {
            
        }
        

    }
}
