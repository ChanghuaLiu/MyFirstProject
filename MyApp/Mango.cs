using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Mango : Fruit
    {
        public Mango()
        {
            Name = "Mango";
            Description = "Sweet";
            ColorOfFruit = "Green";
        }

        public void RipenMango()
        {
            ColorOfFruit = "Yellow";
        }
    }
}
