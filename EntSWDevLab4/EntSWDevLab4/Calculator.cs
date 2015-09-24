using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntSWDevLab4
{
   public class Calculator
    {

        private Calculator()
        {
        }
        public static float Divide(float left, float right)
        {
            float divided = 0;
            if (right != 0)
            {
                divided = (left / right);
            }
            else
            {
                throw (new ArgumentException("Invalid division: 0 is undefined"));
            }
            return divided;
        }
    }
}
