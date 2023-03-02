using System;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pego a encomenda, subindo no patinete...");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto");
        }
    }
}
