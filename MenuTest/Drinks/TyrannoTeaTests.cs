using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


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

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.False(tea.Sweet);
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
            tea.HoldIce();
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
            tea.AddSweet();
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
            tea.Size = Size.Medium;
            tea.AddSweet();
            
            Assert.Equal<uint>(32 , tea.Calories);
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
            tea.AddSweet();
            
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

        [Fact]
        public void AddSweetNotifyOfSpecialPropertyChanged()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.AddSweet();
            });
        }

        [Fact]
        public void SizeToSmallNotifyOfSpecialPropertyChanged()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Medium;
                tea.Size = Size.Small;
            });


            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Medium;
                tea.Size = Size.Small;
            });

            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Medium;
                tea.Size = Size.Small;
            });
        }

       

        [Fact]
        public void SizeToMediumNotifyOfSpecialPropertyChanged()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Medium;
            });

            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Medium;
            });

            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Medium;
            });

           
        }

        [Fact]
        public void SizeToLargeNotifyOfSpecialPropertyChanged()
        {
            TyrannoTea tea = new TyrannoTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Large;
            });

            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Large;
            });

            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Large;
            });

            
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }

            );
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldAddLemonAndHoldIce()
        {
            TyrannoTea tea = new TyrannoTea();
            tea.AddLemon();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                 item =>
                 {
                     Assert.Equal("Add Lemon", item);
                 }
            );
        }

    }
}
