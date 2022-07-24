using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Strawberry : Fruit
    {
        public Strawberry()
        {
            Name = "Strawberry";
            Description = "Not Tasty";
            ColorOfFruit = "White";
            TasteOfFruit = "Sour";
            Price = 10000.25m;

        }public void RipenStrawberry()
        {
            Description = "Tasty";
            TasteOfFruit = "sweet";
            ColorOfFruit = "Red";
        

        }
    }
}
