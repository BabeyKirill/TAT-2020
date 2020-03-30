using System;

namespace DEV_1._4
{
    /// <summary>
    /// Measurement system in this programm is kilometers, kilometers/hours and hours
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(new Coordinates(0, 0, 5));
            Coordinates newp = new Coordinates(1000, 0, 5);
            Console.WriteLine(plane.CaulculateTimeForTrip(newp));
        }
    }
}