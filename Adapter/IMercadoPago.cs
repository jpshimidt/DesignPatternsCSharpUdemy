namespace Adapter
{
    interface IMercadoPago
    {
        Token AuthToken();
        void ReceivedPaymentWithMercadoPago();
        void PaymentWithMercadoPago();
    }
}
