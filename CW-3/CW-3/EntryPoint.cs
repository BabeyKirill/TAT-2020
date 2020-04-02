using System.Collections.Generic;

namespace CW_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Vehicle> autopark = new List<Vehicle>();
            ICreator carAutoTransmissionPetrolCreator = new CarAutoTransmissionPetrolCreator();
            ICreator carMechanicalTransmissionCreator = new CarMechanicalTransmissionCreator();
            ICreator bus45SeatsCreator = new Bus45SeatsCreator();
            ICreator truckMechanicalTransmissionCreator = new TruckMechanicalTransmissionCreator();
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