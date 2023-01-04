using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {
        public double Calculate(double a, double b, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = a + b;
                    return result;
                case "-":
                    result = a - b;
                    return result;
                case "*":
                    result = a * b;
                    return result;
                case "/":
                    result = a / b;
                    return result;

            }

            return default;
        }
    }
}
