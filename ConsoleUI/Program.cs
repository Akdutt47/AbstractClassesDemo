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
             * Done: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - Done
             * The vehicle class shall have three string properties: Year, Make, and Model - done
             * Set the defaults of the properties to something generic in the Vehicle class - done
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.- done
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.- done
             */


            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle- done
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - done
             * Provide the implementations for the abstract methods - done
             * Only in the Motorcycle class will you override the virtual drive method - done
            */

            // Create a list of Vehicle called vehicles - done
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - done
             * 
             * Set the properties values with object initializer syntax - done
             */
            var focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013 };
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "HD", Model = "Chopper", Year = 1978 };

            Vehicle sedan = new Car() { Make = "Dodge", Model = "Charger", Year = 2019 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Ferari", Model = "428", Year = 2000 };
            /*
 * Add the 4 vehicles to the list - done
 * Using a foreach loop iterate through the list and display each of the properties - done
 */
            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveVirtual();
                Console.WriteLine("-------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle - done

            #endregion            
            Console.ReadLine();
        }
    }
}
