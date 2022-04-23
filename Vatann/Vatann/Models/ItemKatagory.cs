using System;
using System.Collections.Generic;
using System.Text;

namespace Vatann.Models
{
    public enum ItemKatagoryType
    {
        AnaSayfa,
        Telefon,
        Bilgisayar,
        Bilgisayar_Parcalari,
        Kamera,
        TV_ve_Elektronigi,
        Ofis,
        Aksesuar,
        Oyun_ve_Hobi,
        EvAletleri,
        Spor_ve_Outdoor,
        Hakkımızda,
        Notebook,
        ÜyeGirisi,
        Hesabım,
        ÜyelikBilgileri,
        Siparişler,
        ŞifreDeğiştirme,
        ÇıkışYap,
        Sepet,
        Diğer
    }
    public class ItemKatagory
    {
        public ItemKatagoryType Id { get; set; }

        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
