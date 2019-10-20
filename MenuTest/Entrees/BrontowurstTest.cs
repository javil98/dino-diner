using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void HoldBunShouldNotifyOfSpecialPropertyChanged()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw , "Special", () =>
            {
                bw.HoldBun();
            });
        }

        [Fact]
        public void HoldOnionShouldNotifyOfSpecialPropertyChanged()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldOnion();
            });
        }

        [Fact]
        public void HoldPeppersShouldNotifyOfSpecialPropertyChanged()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldPeppers();
            });
        }

        [Fact]
        public void ShouldHaveEmptySpecialListByDefault()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);

        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                }

            );
        }

        [Fact]
        public void SpecialShouldHoldPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                }

            );
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }

            );
        }

        [Fact]
        public void SpecialShouldHoldBunAndOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunAndPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldPepperAndOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            bw.HoldPeppers();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }
            );
        }

        [Fact]
        public void SpecialShouldHoldBunAndOnionAndPeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            bw.HoldBun();
            bw.HoldPeppers();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                }

            );
        }
    }

}
