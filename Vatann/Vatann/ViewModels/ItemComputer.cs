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
                   ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/msi/thumb/130986-1_small.jpg",
                    ItemName = string.Format("GF63 THIN 11UC-238XTR"),
                    ItemCost = "15.887",
                    ItemDetail = "Msi Gf63 Thin 11.Nesil Core i7 11800H-16Gb-512Gb Ssd-15.6inc-Rtx3050 4Gb-Freedos",
                    ItemtoShip = "Kargo Bedava"
                },
                new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/hp/thumb/128946_small.jpg",
                    ItemName = string.Format("MBD15I3/8/256"),
                    ItemCost = "9.799",
                    ItemDetail = "Huawei Matebook D15 10.Nesil Core i3 10110U-8Gb-256Gb Ssd-15.6inc-W10",
                    ItemtoShip = "Kargo Bedava"
                },
                new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lenovo/thumb/132732-1_small.jpg",
                    ItemName = string.Format("3511-FB1135W82N"),
                    ItemCost = "20.799",
                    ItemDetail = "Dell Inspiron 15 3511 11.Nesil Core i5 1135G7-8Gb-256Gb Ssd-15.6-Mx350 2Gb-W11",
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