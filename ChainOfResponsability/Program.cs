using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server server;

        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@hcode.com.br", "1234");
            server.RegisterUser("joao@dev.com.br", "1234");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPassword());

            server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail:");
                string email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha:");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);
            }
            while (!done);

            Console.ReadLine();
        }
    }
}
