using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Test1
{
    class Calculator : ICalculator
    {
        public int SumInt(int x, int y)
        {
            return x + y;
        }
    }
}
