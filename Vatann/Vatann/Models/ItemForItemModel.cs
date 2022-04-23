using System;
using System.Collections.Generic;
using System.Text;

namespace Vatann.Models
{
  public  class ItemForItemModel
    {
        private string image;
        public string ImageSource
        {
            get { return image; }
            set { image = value; }

        }
        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private string itemCost;
        public string ItemCost
        {
            get { return itemCost; }
            set { itemCost = value; }
        }
        private string itemDetail;
        public string ItemDetail
        {
            get { return itemDetail; }
            set { itemDetail = value; }

        }
        private string itemtoShip;
        public string ItemtoShip
        {
            get { return itemtoShip; }
            set { itemtoShip = value; }
        }
    }
}
