using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vatann.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vatann.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCategory : ContentPage
    {
       
        public PageCategory()
        {
            InitializeComponent();
          
        }
        private async void Button_Computer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageComputerCategory());
        }
    }
      
    
}
