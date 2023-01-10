using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    class Process
    {


        public static double Calculate(char Opr, double Num1, double Num2)
        {
            double Sum = 0;

            switch(Opr)
            {
                case '+':
                    Sum = Num1 + Num2;
                    break;

                case '-':
                    Sum = Num1 - Num2;
                    break;

                case '*':
                    Sum = Num1 * Num2;
                    break;

                case '/':
                    Sum = Num1 / Num2;
                    break;
            }

            return Sum;
        }
    }
}
