using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car[] c1 = new Car[2];
            List<Car> c1 = new List<Car>();

            c1.Add(new Car("123abc","ford"));
            c1.Add(new Car("456def","chevy"));

            c1.Add(new NascarCar("RuffRiders","jk361","dodge"));
            c1.Add(new NascarCar("SuperSpeeders","863hvb6","chrysler"));
            c1.Add(new NascarCar("RubberBurners","ri989","lambo"));
            c1.Add(new NascarCar("RocketFuel","jw78t","jeep"));

            foreach (Car element in c1)
            {
                element.printInfo();
            }

        }

    }
}
