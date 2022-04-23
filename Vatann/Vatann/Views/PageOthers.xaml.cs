using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vatann.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageOthers : ContentPage
    {
        public PageOthers()
        {
            InitializeComponent();
        }
        private async void Button_Hakkında(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageAbout());
        }

        private async void Button_Siparis(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageFollowOrder());
        }

    }
}