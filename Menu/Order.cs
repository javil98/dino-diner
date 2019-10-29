using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;


namespace DinoDiner.Menu
{
    public class Order: INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        //Backing variables
        double salesTaxRate = 0;

        List<IOrderItem> items = new List<IOrderItem>();

        public Order()
        {
            items = new List<IOrderItem>();
        }

        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// Gets the subtotal of the order.
        /// </summary>
        public double SubTotalCost
        {
            get
            {
                double subTotalCost = 0;
                foreach (IOrderItem x in items)
                {
                    subTotalCost += x.Price;
                }
                if (subTotalCost > 0) return Math.Truncate(subTotalCost *100) /100;
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
                return Math.Truncate((SalesTaxRate * SubTotalCost)* 100) /100;
            }
            
        }

        /// <summary>
        /// Gets the total cost of the order by adding both the subtotalcost and the sales tax cost.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return  Math.Truncate((SubTotalCost + SalesTaxCost) *100) /100;
            }
        }

        /// <summary>
        /// Adds a new item to our order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertyChanged();

        }
        /// <summary>
        /// Removes items from the order.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertyChanged();
            }
            return removed;
        }

        /// <summary>
        /// Notifies the listed notifications about the properties changing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertyChanged();
            
        }

        /// <summary>
        /// Notifies that the properties changes.
        /// </summary>
        void NotifyAllPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }


    }
}
