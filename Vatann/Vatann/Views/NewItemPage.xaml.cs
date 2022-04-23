using System;
using System.Collections.Generic;
using System.ComponentModel;
using Vatann.Models;
using Vatann.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vatann.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}