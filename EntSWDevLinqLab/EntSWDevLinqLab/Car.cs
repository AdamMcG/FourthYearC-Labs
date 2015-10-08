using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntSWDevLinqLab
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int EngineSize { get; set; }


        public Car(string make, string model, string reg, int engineSize)
        {
            this.Make = make;
            this.Model = model;
            this.Registration = reg;
            this.EngineSize = engineSize;
        }

        public Car() : this(String.Empty, String.Empty, String.Empty, 0)
        {
        }

        public override string ToString()
        {
            return "Car: \n" + "\t" + Make + "\n\tModel: " + Model + "\n\tRegistration: " + Registration + "\n\tEngine: " +
            EngineSize;
        }
    }
}
