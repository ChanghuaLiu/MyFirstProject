using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Watermelon : Fruit

    {
        public Watermelon()
        {
            Name = "Watermelon";
            Description = "Watery";
            ColorOfFruit = "Red";
            TasteOfFruit = "Fresh";
            Price = 2000.89m;
            MakeFruitMouldy();
        }

        public void NotRipenWatermelon()
        {
            Description = "Light";
            TasteOfFruit = "Sour";
            ColorOfFruit = "Pink";
        }
    }
}

