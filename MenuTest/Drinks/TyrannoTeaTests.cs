using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;


namespace MenuTest.Drinks
{
    public class TyrannoTeaTests
    {
        //The correct price,calories,ice and size.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.True(tea.Ice);
        }

        //Correct price and size when changing the size.
        [Fact]
       
        public void ShouldHaveCorrectPriceForSmall()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //Correct value when calling HoldIce method.
        [Fact]
        public void ShouldHaveCorrectWhenCallingHoldIce()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.holdIce();
            Assert.False(tea.Ice);
        }

        //Correct value when calling AddLemon method
        [Fact]
        public void ShouldHaveCorrectWhenCallingAddLemon()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        //Correct calories when setting the Sweet protperty
        [Fact]
        
        public void ShouldHaveCorrectCaloriesWhenSweetIsTrueForSmall()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Sweet = true;
            Assert.Equal<uint>(2*8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesWhenSweetIsFalseForSmall()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>( 8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesWhenSweetIsTrueForMedium()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Sweet = true;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(2 * 16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesWhenSweetIsFalseForMedium()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesWhenSweetIsTrueForLarge()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            
            Assert.Equal<uint>(2 * 32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesWhenSweetIsFalseForLarge()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Sweet = true;
            tea.Sweet = false;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        //Have correct Ingredients
        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngedientsForWhenSweetIsTrue()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Sweet = true;
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngedientsForWhenSweetAndLemonIsTrue()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.Sweet = true;
            tea.AddLemon();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(4, tea.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngedientsForWhenLemonIsTrue()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.AddLemon();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
        }









    }
}
