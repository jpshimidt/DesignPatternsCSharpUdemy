using FactoryMethod.Factories;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport transport = null;

            if (args.Length > 0 && args[0] == "--uber")
            {
                transport = new CarTransport();
            }
            else if (args.Length > 0 && args[0] == "--log")
            {
                transport = new MotocycleTransport();
            }
            else if (args.Length > 0 && args[0] == "--bicycle")
            {
                transport = new BicycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo do serviço");
            }

            if (transport != null)
            {
                transport.StratTransport();
            }

            Console.ReadKey();
        }
    }
}
