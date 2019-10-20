using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTests
    {
        //The correct price,calories,ice and size.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
            
        }
        //The correct price,calories,ice and size.
        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        //Correct price and size when changing the size.
        [Fact]
       
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        //Correct value when calling HoldIce method.
        [Fact]
        public void ShouldHaveCorrectWhenCallingHoldIce()
        {
            JurassicJava java = new JurassicJava();
            java.HoldIce();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectValueWhenCallingLeaveSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
        [Fact]
        public void SizeToSmallNotifyOfSpecialPropertyChanged()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Medium;
                java.Size = Size.Small;
            });

            
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Medium;
                java.Size = Size.Small;
            });
        }

        [Fact]
        public void SizeToMediumNotifyOfSpecialPropertyChanged()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Medium;
            });

            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeToLargeNotifyOfSpecialPropertyChanged()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = Size.Large;
            });

            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = Size.Large;
            });
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                }

            );
        }
    }


}
