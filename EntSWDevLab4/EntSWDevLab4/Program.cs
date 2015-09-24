using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntSWDevLab4
{
    class Program
    {
        static void Main()
        {
            try
            {
                string first = "Number1:";
                string secondnum = "number2: ";
                Console.WriteLine(first);
                string firstNumber = Console.ReadLine();
                float a = float.Parse(firstNumber, NumberStyles.AllowDecimalPoint);
                Console.WriteLine(secondnum);
                string second = Console.ReadLine();
                float b = float.Parse(second, NumberStyles.AllowDecimalPoint);
                Console.WriteLine(Calculator.Divide(a, b));

            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format for number");
            }
            catch (OverflowException e2)
            {
                Console.WriteLine(e2);
            }






            Console.ReadLine();
        }
    }
}
