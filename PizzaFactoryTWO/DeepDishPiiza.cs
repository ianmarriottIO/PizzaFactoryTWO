using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTWO
{
    internal class DeepDishPizza : IPizza
    {
        public void Prepare()
        {
            // Set settings in system for stuffed crust preparations
            Console.WriteLine("Preparing Deep Dish pizza");
        }
    }
}
