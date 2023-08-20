using System;

namespace _47_InterfaceExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            // creating a new object of thpe car
            Car damagedCar = new Car(80f, "Blue");

            // add the two chairs to the IDestructable list of the car
            // so that when we destroy the car the destroyable objects
            // that are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
        }
    }
}
