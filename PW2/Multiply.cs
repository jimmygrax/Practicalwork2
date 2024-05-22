using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2
{
    public class Multiply : Operation
    {
        public Multiply() {}
        public double Operar(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
