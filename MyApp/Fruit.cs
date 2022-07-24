using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Fruit
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public bool HasSeedInTheMiddle { get; set; }
        protected string ColorOfFruit { get; set; }
        private bool IsMouldy { get; set; }
        public string TasteOfFruit { get; set; }
        public decimal Price { get; set; }
        public string CheckIfFruitIsMouldy()
        {
            if (IsMouldy)
            {
                return "Oh no, the fruit is mouldy!";
            }
            else
            {
                return "fruit is not mouldy :)";
            }
        }
        public void MakeFruitMouldy()
        {
            IsMouldy = true;
        }

        public string GetFruitStatus()
        {
            return $"Fruit Name = {Name}\nIs it Mouldy = {CheckIfFruitIsMouldy()}\n{Description}\nColour is {ColorOfFruit}\nTaste is {TasteOfFruit}\nPrice is £{Price}";
        }

        public string GetColorOfFruit()
        {
            return ColorOfFruit;
        }

        public string GetTasteOfFruit()
        {
            return TasteOfFruit;
        }

    }
}
