using System;

namespace Bridge.Platforms
{
    class TwitchTv : IPlatform
    {
        public TwitchTv()
        {
            ConfigureRMTP();
        }

        public void AuthToken()
        {
            Console.WriteLine("TwitchTv: Token autenticado");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TwitchTv: Configurando servidor RMTP");
        }
    }
}
