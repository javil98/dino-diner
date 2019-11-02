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
            //ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            order.Add(new Fryceritops());
            order.Add(new DinoNuggets());
            order.Add(new Water());

            //order.items = orderList;

            Assert.Equal(5.34, order.SubTotalCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectSubTotal2()
        {

            Order order = new Order();
            order.Add(new PrehistoricPBJ());
            order.Add(new MeteorMacAndCheese());
            order.Add(new Sodasaurus());

            //order.Items = orderList;

            Assert.Equal(9.01, order.SubTotalCost, 2);


        }

        [Fact]
        public void ShouldHaveCorrectSubTotal3()
        {
            
            Order order = new Order();
            order.Add(new TRexKingBurger());
            order.Add(new MeteorMacAndCheese());
            order.Add(new Sodasaurus());

            //order.Items = orderList;

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
            Order order = new Order();
            order.Add(new TRexKingBurger());
            order.Add(new MeteorMacAndCheese());
            order.Add(new Sodasaurus());

            Assert.Equal(1.094, order.SalesTaxCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectSalesTax2()
        {
            
            Order order = new Order();
            order.Add(new PrehistoricPBJ());
            order.Add(new MeteorMacAndCheese());
            order.Add(new Sodasaurus());

            Assert.Equal(0.90 , order.SalesTaxCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCorrectSalesTax3()
        {
            ObservableCollection<IOrderItem> orderList = new ObservableCollection<IOrderItem>();
            Order order = new Order();
            order.Add(new Fryceritops());
            order.Add(new DinoNuggets());
            order.Add(new Water());

            Assert.Equal(.53, order.SalesTaxCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectTotalCost1()
        {
            Order order = new Order();
            order.Add(new TRexKingBurger());
            order.Add(new MeteorMacAndCheese());
            order.Add(new Sodasaurus());

            Assert.Equal(12.03, order.TotalCost, 2);
        }

        [Fact]
        public void ShouldHaveCorrectTotalCost2()
        {
           
            Order order = new Order();
            order.Add(new Fryceritops());
            order.Add(new DinoNuggets());
            order.Add(new Water());

            Assert.Equal(5.87, order.TotalCost, 2);
        }
    }

   
}
