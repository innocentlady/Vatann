using DLToolkit.Forms.Controls;
using System;
using Vatann.Services;
using Vatann.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vatann
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            DependencyService.Register<MockDataStore>();
            MainPage =new NavigationPage(new PageTabbedMain());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
