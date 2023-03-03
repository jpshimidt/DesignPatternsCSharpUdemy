using System;

namespace Bridge.Platforms
{
    class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfigureRMTP();
        }

        public void AuthToken()
        {
            Console.WriteLine("YouTube: Token autenticado");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP");
        }
    }
}
