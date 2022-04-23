using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Vatann.Models;
using Xamarin.Forms;
using Vatann.Views;

namespace Vatann.ViewModels
{
    public class ItemModel : BindableObject
    {
        private Page Page;


        public ItemModel(Page mainPage)
        {
            this.Page = mainPage;
            //AddItems();
        }

        private void AddItems()
        {
            for (int i = 0; i < 20; i++)
            { 
            ItemForItemModel ItemForDetail = new ItemForItemModel()
            {
                ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                ItemName = string.Format("ItemName {0}", i),
                ItemCost = string.Format("ItemCost {0}", i),
                ItemDetail = string.Format("ItemDetail {0}", i),
                ItemtoShip = string.Format("ItemtoShip  {0}", i),
            };

            Items.Add(ItemForDetail);
        }
        
        }

        private List<ItemForItemModel> _items = new List<ItemForItemModel>(){
                new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "4.799",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                },
                new ItemForItemModel()
                {
                   ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "4.799",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                },
                new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "4.799",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                },
                new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "4.799",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                }
        };
        public List<ItemForItemModel> Items
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

