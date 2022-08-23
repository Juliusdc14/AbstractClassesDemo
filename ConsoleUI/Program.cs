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
            

            #region Vehicles

            
            var vehicles = new List<Vehicle>();



            
            Car focus = new Car() { HasTrunk = true, Make = "Dodge", Model = "Charger", Year = 2012 };
            Motorcycle motorcycle = new Motorcycle() { HasSideCart = true, Make = "Victory", Model = "X", Year = 2016 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Chevy", Model = "Cruz", Year = 2014 };
            Vehicle sport = new Car() { HasTrunk = false, Make = "Chevy", Model = "Corvette", Year = 2022 };
            
            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} Year {veh.Year}");
                veh.DriveAbstract();
                Console.WriteLine("------------------");
            }



            

            #endregion            
            Console.ReadLine();
        }
    }
}
