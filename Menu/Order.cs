using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
       /// <summary>
       /// Gets and sets the Items of the order.
       /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();



        /// <summary>
        /// Gets the subtotal of the order.
        /// </summary>
        public double SubTotalCost
        {
            get
            {
                double subTotalCost = 0;
                foreach (IOrderItem x in Items)
                {
                    subTotalCost += x.Price;
                }
                if (subTotalCost > 0) return subTotalCost;
                else return 0;
            }
        }

        /// <summary>
        /// Gets the SalesTaxRate of the order.
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.1;

        /// <summary>
        /// Gets the Sales Tax Cost of the order.
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubTotalCost;
            }
        }

        /// <summary>
        /// Gets the total cost of the order by adding both the subtotalcost and the sales tax cost.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return  SubTotalCost + SalesTaxCost;
            }
        }
    }
}
