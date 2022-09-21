using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTWO
{
    public class PizzaFactory
    {
        public PizzaFactory()
        {

        }
        public void preparePizzas(IList<IPizza> pizzas)
        {
            foreach (IPizza ipizza in pizzas)
            {
                ipizza.prepare();
            }
        }

        public void getDeliveryDetails(IList<IDelivery> deliveries)
        {
            foreach (IDelivery idelivery in deliveries)
            {
                idelivery.canDeliver();
                idelivery.getDeliveryType();
            }
        }
    }
}
