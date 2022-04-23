using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Vatann.Models;
using Xamarin.Forms;

namespace Vatann.ViewModels
{
    public class ItemComputer : ContentPage
    {
        private Page Page;

        public ItemComputer(Page mainPage)
        {
            this.Page = mainPage;
            AddItems();
        }

        private void AddItems()
        {
            for (int i = 0; i < 20; i++)
            {
                ItemForItemModel ItemForDetail = new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lenovo/thumb/132540-1_large.jpg",
                    ItemName = string.Format("ItemName {0}", i),
                    ItemCost = string.Format("ItemCost {0}", i),
                    ItemDetail = string.Format("ItemDetail {0}", i),
                    ItemtoShip = string.Format("ItemtoShip  {0}", i),
                };

                Items.Add(ItemForDetail);
            }

        }

        private ObservableCollection<ItemForItemModel> _items = new ObservableCollection<ItemForItemModel>()
        {   new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lenovo/thumb/132540-1_large.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "14.799",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                },
                new ItemForItemModel()
                {
                   ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lenovo/thumb/132540-1_large.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "14.799",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                },
                new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lenovo/thumb/132540-1_large.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "14.799",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                },
                new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lenovo/thumb/132540-1_large.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "14.799",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                }

        };
        public ObservableCollection<ItemForItemModel> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {
                    Page.DisplayAlert("FlowListView", data + "", "Ok");
                });
            }
        }
    }
}