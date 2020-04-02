namespace CW_3
{
    class Bus45SeatsCreator : ICreator
    {
        public Vehicle Create()
        { 
            Chassis chassis = new Chassis(6, 12000, "CH000003");
            Transmission transmission = new Transmission(TransmissionType.Automatical, 6, "Nutella");
            BusAssignment busAssigment = BusAssignment.Intercity;
            Bus bus = new Bus(chassis, transmission, busAssigment);
            Engine engine = new Engine(800, 7.0, EngineType.Petrol, "EN000003");
            bus.Engine = engine;
            bus.Model = "SuperBus 2000";
            bus.SerialNumber = "BU000001";
            bus.NumberOfSeats = 45;
            return bus;
        }
    }
}