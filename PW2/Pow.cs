using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2
{
    public class Pow : Operation
    {
        private double result;

        public double Operar(double op1, double op2)
        {
            for (int i = 1; i <= op2; i++)
            {
                this.result = op1 * op1;
            }
            return this.result;
        }
        public double operateSign(string sign, double op1, double op2)
        {
            for (int i = 1; i <= op2; i++)
            {
                this.result = op1 * op1;
            }
            return this.result;
        }
    }
}
