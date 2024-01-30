using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle

	{
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in park.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} and it is in park.");
        }
    }
}

