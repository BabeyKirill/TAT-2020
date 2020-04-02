using System.Collections.Generic;

namespace CW_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Vehicle> autopark = new List<Vehicle>();
            Creator carAutoTransmissionPetrolCreator = new CarAutoTransmissionPetrolCreator();
            Creator carMechanicalTransmissionCreator = new CarMechanicalTransmissionCreator();
            Creator bus45SeatsCreator = new Bus45SeatsCreator();
            Creator truckMechanicalTransmissionCreator = new TruckMechanicalTransmissionCreator();
            autopark.Add(carAutoTransmissionPetrolCreator.Create());
            autopark.Add(carAutoTransmissionPetrolCreator.Create());
            autopark.Add(carMechanicalTransmissionCreator.Create());
            autopark.Add(carMechanicalTransmissionCreator.Create());
            autopark.Add(carMechanicalTransmissionCreator.Create());
            autopark.Add(bus45SeatsCreator.Create());
            autopark.Add(bus45SeatsCreator.Create());
            autopark.Add(truckMechanicalTransmissionCreator.Create());
            autopark.Add(truckMechanicalTransmissionCreator.Create());
        }
    }
}