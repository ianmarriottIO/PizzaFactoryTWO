using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTWO
{
    public class StuffedCrustPizza : Pizza, IPizza, IDelivery
    {
        public override string name { get; set; }

        public override List<string> toppings { get; set; }


        public StuffedCrustPizza()
        {
            name = "Stuffed Crust";
            toppings = new List<string>();
            addDefaultToppings();
        }

        public void addDefaultToppings()
        {
            toppings.Add("Tomato");
            toppings.Add("Peppers");
            toppings.Add("Olives");
        }
        public void displayToppings()
        {
  
        }

        public void prepare()
        {
            Console.WriteLine("Preparing stuffed crust pizza");
        }
        public void canDeliver()
        {
            Console.WriteLine("Your pizza can be delivered.");
        }

        public void getDeliveryType()
        {
            Console.WriteLine("We will deliver your pizza by car.");
        }
    }
}
