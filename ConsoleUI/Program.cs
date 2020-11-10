using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles



            /* 
             * done-Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * done-Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * done-Provide the implementations for the abstract methods
             * done-Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             *done- Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * done-Set the properties with object initializer syntax
             */
            var nissan = new Car() { HasTrunk = true, Make = "Nissan", Model = "Pathfinder", Year = 2017 };
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "Yamaha", Model = "Scooter", Year = 2019 };
            Vehicle sedan = new Car() { HasTrunk = true, Make = "Honda", Model = "Accord", Year = 2020 };
            Vehicle compact = new Car() { HasTrunk = true, Make = "Nissan", Model = "Sentra", Year = 2018 };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(nissan);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(compact);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveAbstract();
                Console.WriteLine("------------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
