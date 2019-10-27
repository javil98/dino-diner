using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;


namespace DinoDiner.Menu
{
    public class Order:INotifyPropertyChanged
    {
       /// <summary>
       /// Gets and sets the Items of the order.
       /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;

        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
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

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            Items.Add(item);
        }


    }
}
