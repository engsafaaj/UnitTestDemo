using System;
using System.Collections.Generic;
using System.Text;
namespace UnitDemo
{
    public class MathOpertors
    {
        public int Add(int n1, int n2)
        {
            if (n1 == 0)
            {
                return n2;
            }
            else
            {
                return n1 + n2;
            }
        }

        public int Div(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("Can not Div by Zero Value");
            }
            else
            {
                return n1 / n2;
            }
        }

    }
}
