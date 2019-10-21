using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using System.Collections.ObjectModel;

namespace MenuTest
{
    public class MockEntree : Entree
    {
        public MockEntree()
        {
            this.Price = -50;
        }
    }
    public class OrderTest
    {

        
        [Fact]
        public void ShouldHaveCorrectSubTotal1()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new Fryceritops());
            orderList.Add(new DinoNuggets());
            orderList.Add(new Water());

            order.Items = orderList;

            Assert.Equal(5.34, order.SubTotalCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectSubTotal2()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new PrehistoricPBJ());
            orderList.Add(new MeteorMacAndCheese());
            orderList.Add(new Sodasaurus());

            order.Items = orderList;

            Assert.Equal(9.01, order.SubTotalCost, 2);


        }

        [Fact]
        public void ShouldHaveCorrectSubTotal3()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new TRexKingBurger());
            orderList.Add(new MeteorMacAndCheese());
            orderList.Add(new Sodasaurus());

            order.Items = orderList;

            Assert.Equal(10.94, order.SubTotalCost, 2);
        }
        [Fact]
        public void ShouldHaveCorrectSubtotalWhenNegative()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new MockEntree());
            Assert.Equal(0, order.SubTotalCost);
        }

     



        [Fact]
        public void ShouldHaveCorrectSalesTax1()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new TRexKingBurger());
            orderList.Add(new MeteorMacAndCheese());
            orderList.Add(new Sodasaurus());

            order.Items = orderList;

            Assert.Equal(1.094, order.SalesTaxCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectSalesTax2()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new PrehistoricPBJ());
            orderList.Add(new MeteorMacAndCheese());
            orderList.Add(new Sodasaurus());

            order.Items = orderList;

            Assert.Equal(0.90 , order.SalesTaxCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCorrectSalesTax3()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new Fryceritops());
            orderList.Add(new DinoNuggets());
            orderList.Add(new Water());

            order.Items = orderList;

            Assert.Equal(.53, order.SalesTaxCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectTotalCost1()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new TRexKingBurger());
            orderList.Add(new MeteorMacAndCheese());
            orderList.Add(new Sodasaurus());

            order.Items = orderList;

            Assert.Equal(12.03, order.TotalCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectTotalCost2()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            orderList.Add(new Fryceritops());
            orderList.Add(new DinoNuggets());
            orderList.Add(new Water());

            order.Items = orderList;

            Assert.Equal(5.87, order.TotalCost, 2);
        }
    }

   
}
