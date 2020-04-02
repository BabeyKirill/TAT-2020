namespace CW_3
{
    class CarMechanicalTransmissionCreator : ICreator
    {
        public Vehicle Create()
        {           
            Chassis chassis = new Chassis(4, 2300, "CH000002");
            Transmission transmission = new Transmission(TransmissionType.Mechanical, 6, "Adidas");
            CarType carType = CarType.SUV;
            Car car = new Car(chassis, transmission, carType);
            Engine engine = new Engine(300, 4.0, EngineType.Petrol, "EN000002");
            car.Engine = engine;
            car.Model = "SuperCar 2000";
            car.SerialNumber = "CA000002";
            car.NumberOfSeats = 7;
            car.TrunkVolume = 48.1;
            return car;
        }
    }
}