using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrassicJava: Drink
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
                if (size == Size.Small)
                {
                    this.Calories = 2;
                    this.Price = 0.59;
                }
                if (size == Size.Medium)
                {
                    this.Calories = 4;
                    this.Price = 0.99;
                }
                if (size == Size.Large)
                {
                    this.Calories = 8;
                    this.Price = 1.49;
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
