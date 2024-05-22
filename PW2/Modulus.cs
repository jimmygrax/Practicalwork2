using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW2
{
    public class Modulus : Operation
    {
        private double result;
        public Modulus() { }
        public Modulus(double result)
        {
            this.result = result;
        }
        public double Operar(double op1, double op2)
        {
            if (op2 == 0 || op2 == 1) return 1;

            this.result = op1;
            while (this.result >= op2)
            {
                this.result -= op2;
            }
            return this.result;     
        }
        public double operateSign(string sign, double op1, double op2)
        {
            if (op2 == 0 || op2 == 1) return 1;

            this.result = op1;
            while (this.result >= op2)
            {
                this.result -= op2;
            }
            return this.result;
        }
    }
}
