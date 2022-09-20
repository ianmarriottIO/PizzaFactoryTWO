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
        public void PreparePizzas(IList<IPizza> pizzas)
        {
            foreach (IPizza ipizza in pizzas)
            {
                ipizza.Prepare();
            }
        }
    }
}
