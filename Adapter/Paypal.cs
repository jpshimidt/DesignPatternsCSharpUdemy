using System;

namespace Adapter
{
    class Paypal : IPayPalPayment
    {
        private readonly Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            AuthToken();
            Console.WriteLine("Enviando pagamento com o PayPal");
        }

        public void PayPalReceived()
        {
            Console.WriteLine("Recebendo pagamento com o PayPal");
        }

    }
}
