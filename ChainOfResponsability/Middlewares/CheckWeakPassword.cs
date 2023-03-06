using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckWeakPassword : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("1234"))
            {
                Console.WriteLine("Senha fraca: Recomendamos a troca da senha");
                return true;
            }

            return CheckNext(email, password);

        }
    }
}
