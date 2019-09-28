using System.Collections.Generic;

namespace DinoDiner.Menu.Drinks
{
    public class JurrassicJava : Drink
    {
        public bool Decaf { get; set; } = false;

        public bool RoomForCream { get; set; } = false;


        private Size size;
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;

                    case Size.Small:
                        Price = .49;
                        Calories = 2;
                        break;


                }
            }

        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Coffee" };
            }
        }




        public JurrassicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
        }

        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }


    }
}
