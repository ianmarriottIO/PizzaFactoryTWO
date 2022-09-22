using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTWO
{
    public abstract class Pizza
    {
        public abstract string name { get; set; }
        public abstract List<string> toppings { get; set; }

        public void displayToppings(List<string> toppings)
        {
            foreach (var topping in toppings)
            {
                Console.WriteLine(topping);
            }
        }
    }


}
