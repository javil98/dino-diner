using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        //Correct price and size when changing the size.
        [Fact]

        public void ShouldHaveCorrectPriceForSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        //Correct value when calling HoldIce method.
        [Fact]
        public void ShouldHaveCorrectWhenCallingHoldIce()
        {
            Water water = new Water();
            water.holdIce();
            Assert.False(water.Ice);
        }

        //Correct value when calling AddLemon method
        [Fact]
        public void ShouldHaveCorrectWhenCallingAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        //Have correct Ingredients
        [Fact]
        public void ShouldHaveCorrectIngedientsWhenLemonIsFalse()
        {
            Water water = new Water();
            Assert.Single(water.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectIngedientsWhenLemonIsTrue()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Contains<string>("Lemon", water.Ingredients);
            Assert.Equal<int>(2, water.Ingredients.Count);
        }
    }
}
