using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DI_Test1
{
    public class AppHost
    {
        private readonly ICalculator _Calculator;

        public AppHost(ICalculator calculator)
        {
            _Calculator = calculator;
        }

        public int Run()
        {
            return  _Calculator.SumInt(1, 1);
            
        }
    }
}
