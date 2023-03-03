using System;

namespace Adapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private readonly MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            mercadoPago.PaymentWithMercadoPago();
        }

        public void PayPalReceived()
        {
            mercadoPago.ReceivedPaymentWithMercadoPago();
        }
    }
}
