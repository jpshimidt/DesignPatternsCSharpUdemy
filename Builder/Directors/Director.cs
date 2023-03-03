using Builder.Builders;

namespace Builder.Directors
{
    class Director
    {
        readonly IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicleType(Components.VehicleType.SEDAN);
            builder.SetEngine(new Components.Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Components.Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(Components.VehicleType.TRUCK);
            builder.SetEngine(new Components.Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Components.Transmission.MANUAL);
        }

        public void ConstructSUV()
        {
            builder.SetVehicleType(Components.VehicleType.SUV);
            builder.SetEngine(new Components.Engine(2600));
            builder.SetSeats(5);
            builder.SetTransmission(Components.Transmission.AUTOMATIC_SEQUENCIAL);
            builder.SetAirBag(new Components.AirBag(true));
        }
    }
}
