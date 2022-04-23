using System.ComponentModel;
using Vatann.ViewModels;
using Xamarin.Forms;

namespace Vatann.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}