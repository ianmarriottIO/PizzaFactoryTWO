namespace PizzaFactoryTWO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DeepDishPizza ddp = new DeepDishPizza();
            StuffedCrustPizza scp = new StuffedCrustPizza();

            List<IPizza> ipizzas = new List<IPizza>();

            ipizzas.Add(scp);
            ipizzas.Add(ddp);

            PizzaFactory pf2 = new PizzaFactory();
            pf2.PreparePizzas(ipizzas);
        }
    }
}