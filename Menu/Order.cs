using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        private ObservableCollection<IOrderItem> items;

        /*public ObservableCollection<IOrderItem> Items
        {
            get
            {
               // return items;
            }

            set
            {
                items = new ObservableCollection<IOrderItem>();
                items = value;
            }
        }*/

        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();



        private double subTotalCost;
        public double SubTotalCost
        {
            get
            {
                foreach (IOrderItem x in Items)
                {
                    subTotalCost += x.Price;
                }
                if (subTotalCost > 0) return subTotalCost;
                else return 0;
            }
        }

        public double SalesTaxRate { get; protected set; } = 0.1;

        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubTotalCost;
            }
        }

        public double TotalCost
        {
            get
            {
                return  SubTotalCost + SalesTaxCost;
            }
        }
    }
}
