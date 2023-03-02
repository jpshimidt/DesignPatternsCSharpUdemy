﻿using System;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos sudente, ventos ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok! Ligando as helices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
