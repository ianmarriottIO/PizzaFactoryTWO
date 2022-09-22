using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTWO
{
    public interface IPizza
    {
        void prepare();
        void displayToppings();
    }

    public interface IDelivery
    {
        void canDeliver();
        void getDeliveryType();
    }

    public interface IOrder
    {
        void showOrderDetails();
    }
}
