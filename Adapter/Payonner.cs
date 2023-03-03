using System;

namespace Adapter
{
    class Payonner : IPayonnerPayment
    {
        private readonly Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivedPayment()
        {
            AuthToken();
            Console.WriteLine("Recebendo pagamento com Payyonner");
        }

        public void SendPayment()
        {
            AuthToken();
            Console.WriteLine("Pagando com Payyonner");
        }
    }
}
