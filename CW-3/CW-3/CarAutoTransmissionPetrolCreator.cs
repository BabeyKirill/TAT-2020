namespace CW_3
{
    class CarAutoTransmissionPetrolCreator : ICreator
    {
        public Vehicle Create()
        {
            Chassis chassis = new Chassis(4, 2000, "CH000001");
            Transmission transmission = new Transmission(TransmissionType.Automatical, 5, "Nestle");
            CarType carType = CarType.Sedan;
            Car car = new Car(chassis, transmission, carType);
            Engine engine = new Engine(250, 4.5, EngineType.Petrol, "EN000001");
            car.Engine = engine;
            car.Model = "MegaCar 1000";
            car.SerialNumber = "CA000001";
            car.NumberOfSeats = 5;
            car.TrunkVolume = 55.5;
            return car;
        }
    }
}