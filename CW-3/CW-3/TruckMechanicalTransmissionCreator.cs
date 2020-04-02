namespace CW_3
{
    class TruckMechanicalTransmissionCreator : ICreator
    {
        public Vehicle Create()
        {
            Chassis chassis = new Chassis(6, 4000, "CH000004");
            Transmission transmission = new Transmission(TransmissionType.Mechanical, 6, "HappyWheels");
            double height = 4.1, width = 3.7;
            Truck truck = new Truck(chassis, transmission, width, height);
            Engine engine = new Engine(1000, 8.0, EngineType.Diesel, "EN000004");
            truck.Engine = engine;
            truck.Model = "SuperTruck 2000";
            truck.SerialNumber = "TR000001";
            truck.CarryingMass = 20000;
            return truck;
        }
    }
}