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
    public partial class PageComputer : ContentPage
    {
        Product ÜrünBilgileri;
        int adet = 1;

        public PageComputer(Product ürünItem)
        {
            InitializeComponent();
            ÜrünBilgileri = ürünItem;
            id.Text = ÜrünBilgileri.Id.ToString();
            Image.Source = ÜrünBilgileri.ImageSource;
            Name.Text = ÜrünBilgileri.Name;
            Detail.Text = ÜrünBilgileri.Info;
            Cost.Text = string.Format("{0:#,0.####}", ÜrünBilgileri.Cost);
            Taksit.Text = string.Format("{0:#,0.####}", (ÜrünBilgileri.Cost / 12)) + "'den başlayan taksitlerle ";
            picker.SelectedIndex = 0;
        }
       
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                adet = Convert.ToInt32((picker.ItemsSource[selectedIndex] as string)[0].ToString());
            }
        }

    }
}