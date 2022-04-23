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
    public partial class PageTabbedMain : Xamarin.Forms.TabbedPage
    {
        public PageTabbedMain()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Android>().SetBarItemColor(Color.Gray);
            On<Android>().SetBarSelectedItemColor(Color.DarkBlue);
        }
    }
}