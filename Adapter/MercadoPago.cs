using System;

namespace Adapter
{
    class MercadoPago : IMercadoPago
    {
        public Token AuthToken()
        {
            return new Token();
        }

        public void PaymentWithMercadoPago()
        {
            AuthToken();
            Console.WriteLine("Pagando com Mercado Pago");
        }

        public void ReceivedPaymentWithMercadoPago()
        {
            AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago");
        }
    }
}
