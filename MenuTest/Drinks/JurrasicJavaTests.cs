using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTests
    {
        //The correct price,calories,ice and size.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrassicJava java = new JurrassicJava();
            Assert.Equal<double>(0.59, java.Price);
            
        }
        //The correct price,calories,ice and size.
        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            JurrassicJava java = new JurrassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrassicJava java = new JurrassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurrassicJava java = new JurrassicJava();
            Assert.False(java.Ice);
        }

        //Correct price and size when changing the size.
        [Fact]
       
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurrassicJava java = new JurrassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurrassicJava java = new JurrassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurrassicJava java = new JurrassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurrassicJava java = new JurrassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurrassicJava java = new JurrassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurrassicJava java = new JurrassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        //Correct value when calling HoldIce method.
        [Fact]
        public void ShouldHaveCorrectWhenCallingHoldIce()
        {
            JurrassicJava java = new JurrassicJava();
            java.holdIce();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectValueWhenCallingLeaveSpaceForCream()
        {
            JurrassicJava java = new JurrassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurrassicJava java = new JurrassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }


    }
}
