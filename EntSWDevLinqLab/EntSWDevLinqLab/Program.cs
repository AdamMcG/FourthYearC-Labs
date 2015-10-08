using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntSWDevLinqLab
{
    class Program
    {
        private static void Main()
        {
            List<Car> fleet = new List<Car>
            {
                new Car("Ford", "Focus", "11-D-4322a", 1600),
                new Car("Mazda", "RX-7", "10-D-4322a", 1900),
                new Car("Toyota", "Corolla", "10-C-4322a", 1200),
                new Car("Ford", "Focus", "09-D-4322a", 1300),
                new Car("Mazda", "RX-9", "95-D-4322a", 1000)
            };

            var query = fleet.Select(car => car.Registration);
            foreach (var car in query)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            var query2 = fleet.Where(cars => cars.Make == "Mazda").Select(car => car.Make);
            foreach (var makeString in query2)
            {
                Console.WriteLine(makeString);
            }
            Console.WriteLine();
            var query3 = fleet.Where(cars => cars.EngineSize == 1600).Select(car => new {car.Make, car.Model});
            foreach (var car in query3)
            {
                Console.WriteLine(car.ToString());
            }
            Console.WriteLine();
            var query4 = fleet.Count(cars => cars.EngineSize < 1600);
            Console.WriteLine(query4);


            Console.ReadLine();
        }
    }
}
