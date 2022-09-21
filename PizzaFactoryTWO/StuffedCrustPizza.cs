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

        public StuffedCrustPizza()
        {
            name = "Stuffed Crust";
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
