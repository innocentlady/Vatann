using System;
using System.Collections.Generic;
using Vatann.ViewModels;
using Vatann.Views;
using Xamarin.Forms;

namespace Vatann
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
