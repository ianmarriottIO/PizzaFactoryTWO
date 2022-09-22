using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTWO
{
    public class DeepDishPizza : Pizza, IPizza, IDelivery
    {
        public override string name { get; set; }
        public override List<string> toppings { get; set; }

        public DeepDishPizza()
        {
            name = "Deep Dish";
            toppings = new List<string>();
            addDefaultToppings();

        }
        public void addDefaultToppings()
        {
            toppings.Add("Tomato");
            toppings.Add("Beef");
            toppings.Add("Mushrooms");
        }

        public void displayToppings()
        {

        }

        public void prepare()
        {
            Console.WriteLine("Preparing Deep Dish pizza");
        }
        public void canDeliver()
        {
            Console.WriteLine("Your pizza can be delivered.");
        }

        public void getDeliveryType()
        {
            Console.WriteLine("We will deliver your pizza by boat.");
        }
    }
}
