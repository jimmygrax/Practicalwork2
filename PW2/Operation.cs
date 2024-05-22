using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PW2
{
    public class Operation
    {
        protected string operacion;
        protected string simbol;
        protected double num1;
        protected double num2;
        private string result;

        public Operation(string operacion)
        {
            this.operacion = operacion;
        }
        public Operation() { }
        public void Parametros()
        {
            try
            {
                string[] elemen = operacion.Split(' ');

                this.num1 = int.Parse(elemen[0]);
                this.simbol = elemen[1];
                this.num2 = int.Parse(elemen[2]);

                switch (simbol)
                {
                    case "+":
                        Add a = new Add();

                        this.result = Convert.ToString(a.Operar(this.num1, this.num2));

                        break;
                    case "-":
                        Substract s = new Substract();
                        this.result = Convert.ToString(s.Operar(this.num1, this.num2));


                        break;
                    case "*":
                        Multiply m = new Multiply();
                        this.result = Convert.ToString(m.Operar(this.num1, this.num2));


                        break;
                    case "/":
                        Divide d = new Divide();
                        this.result = Convert.ToString(d.Operar(this.num1, this.num2));


                        break;
                    case "^":
                        Pow pow = new Pow();
                        this.result = Convert.ToString(pow.Operar(this.num1, this.num2));


                        break;
                    case "%":
                        Modulus mod = new Modulus();
                        this.result = Convert.ToString(mod.Operar(this.num1, this.num2));

                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        public string Devolver()
        {
            return this.result;
        }
    }
}
