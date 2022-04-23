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
                   ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lg/thumb/nano75pa1-2_small.jpg",
                    ItemName = string.Format("55NANO756PA"),
                    ItemCost = "11.799",
                    ItemDetail = "LG 55NANO756 55inc 139 CM NANOCELL 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",
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
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/philips/thumb/v2-88491_small.jpg",
                    ItemName = string.Format("GC5032/20"),
                    ItemCost = "1.599",
                    ItemDetail = "PHILIPS GC5032/20 AZUR ELITE OPTİMAL TEMP TEKNOLOJİLİ BUHARLI ÜTÜ",
                    ItemtoShip = "Kargo Bedava"
                },
                 new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/arnica/thumb/130693-1_small.jpg",
                    ItemName = string.Format("IH32059 KÖPÜKLÜ EKO SİYAH"),
                    ItemCost = "499",
                    ItemDetail = "ARNICA KÖPÜKLÜ TÜRK KAHVE MAKİNESİ EKO SİYAH - IH32059",
                    ItemtoShip = "Kargo Bedava"
                },
                  new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/vivo/thumb/127471_small.jpg",
                    ItemName = string.Format("Y11s_SİYAH"),
                    ItemCost = "2.799",
                    ItemDetail = "Vivo Y11s 32 Gb Fantom Siyahı Akıllı Telefon",
                    ItemtoShip = "Kargo Bedava"
                },
                   new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/kioxia/thumb/117108_small.jpg",
                    ItemName = string.Format("LTC10Z240GG8"),
                    ItemCost = "4.799",
                    ItemDetail = "Kioxia 240GB Exceria Serisi Sata 3.0 SSD (555MB Okuma / 540MB Yazma)",
                    ItemtoShip = "Kargo Bedava"
                },
                    new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/axen/thumb/axen-ax32dab13-gorseli-108257_small.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "2.399",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                },
                     new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    ItemName = string.Format("AX32DB13-TNR"),
                    ItemCost = "4.799",
                    ItemDetail = "AXEN 32inc 82 CM AX32DAB13 HD READY ANDROID SMART TV,DAHİLİ UYDU ALICI",
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
                   ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/lg/thumb/nano75pa1-2_small.jpg",
                    ItemName = string.Format("55NANO756PA"),
                    ItemCost = "11.799",
                    ItemDetail = "LG 55NANO756 55inc 139 CM NANOCELL 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",
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
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/philips/thumb/v2-88491_small.jpg",
                    ItemName = string.Format("GC5032/20"),
                    ItemCost = "1.599",
                    ItemDetail = "PHILIPS GC5032/20 AZUR ELITE OPTİMAL TEMP TEKNOLOJİLİ BUHARLI ÜTÜ",
                    ItemtoShip = "Kargo Bedava"
                },
                 new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/arnica/thumb/130693-1_small.jpg",
                    ItemName = string.Format("IH32059 KÖPÜKLÜ EKO SİYAH"),
                    ItemCost = "499",
                    ItemDetail = "ARNICA KÖPÜKLÜ TÜRK KAHVE MAKİNESİ EKO SİYAH - IH32059",
                    ItemtoShip = "Kargo Bedava"
                },
                  new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/vivo/thumb/127471_small.jpg",
                    ItemName = string.Format("Y11s_SİYAH"),
                    ItemCost = "2.799",
                    ItemDetail = "Vivo Y11s 32 Gb Fantom Siyahı Akıllı Telefon",
                    ItemtoShip = "Kargo Bedava"
                },
                   new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/kioxia/thumb/117108_small.jpg",
                    ItemName = string.Format("LTC10Z240GG8"),
                    ItemCost = "4.799",
                    ItemDetail = "Kioxia 240GB Exceria Serisi Sata 3.0 SSD (555MB Okuma / 540MB Yazma)",
                    ItemtoShip = "Kargo Bedava"
                },
                    new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/axen/thumb/axen-ax32dab13-gorseli-108257_small.jpg",
                    ItemName = string.Format("SM-A325FZKHTUR"),
                    ItemCost = "2.399",
                    ItemDetail = "Samsung Galaxy A32 128 Gb Akıllı Siyah",
                    ItemtoShip = "Kargo Bedava"
                },
                     new ItemForItemModel()
                {
                    ImageSource = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/121935_small.jpg",
                    ItemName = string.Format("AX32DB13-TNR"),
                    ItemCost = "4.799",
                    ItemDetail = "AXEN 32inc 82 CM AX32DAB13 HD READY ANDROID SMART TV,DAHİLİ UYDU ALICI",
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

