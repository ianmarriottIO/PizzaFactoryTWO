namespace PizzaFactoryTWO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, Pizza World!");

            DeepDishPizza ddp = new DeepDishPizza();
            StuffedCrustPizza scp = new StuffedCrustPizza();

            Order order1 = new Order(001, "01/12/2022", scp);

            order1.showOrderDetails();


            //List<IPizza> ipizzas = new List<IPizza>();
            //List<IDelivery> ideliveries = new List<IDelivery>();

            //ipizzas.Add(scp);
            //ipizzas.Add(ddp);

            //ideliveries.Add(scp);
            //ideliveries.Add(ddp);

            //PizzaFactory pf2 = new PizzaFactory();
            //pf2.preparePizzas(ipizzas);
            //pf2.getDeliveryDetails(ideliveries);
        }
    }
}