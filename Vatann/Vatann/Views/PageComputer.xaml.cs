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
      
        int adet = 1;

        public PageComputer()
        {
            InitializeComponent();         
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