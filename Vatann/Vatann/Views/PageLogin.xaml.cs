using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Vatann.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLogin : Xamarin.Forms.TabbedPage
    {
        public PageLogin()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
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
            await Navigation.PushAsync(new PageBasket());
        }

    }
}