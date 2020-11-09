using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var suv = new SUV();
            var vehicles = new List<IVehicle>() { car, truck, suv };

            foreach(var vehicle in vehicles) 
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            
            }




            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done - Create 2 Interfaces called IVehicle & ICompany

            //Done - Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Done - Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Done - Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
