using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactoryTWO
{
    public class Order
    {
        public int id { get; set; }
        public string date { get; set; }
        public Pizza pizza { get; set; }

        public Order(int id, string date, Pizza pizza)
        {
            this.id = id;
            this.date = date;
            this.pizza = pizza;
        }

        public void showOrderDetails()
        {
            Console.WriteLine("ID: " + id + " Date: " + date + " Pizza: " + pizza.name);
        }
    }
}
