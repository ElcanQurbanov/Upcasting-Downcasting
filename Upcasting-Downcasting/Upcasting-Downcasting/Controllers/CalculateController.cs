using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting.Controllers
{
    public class CalculateController
    {
        public double Calculate()
        {
            Console.WriteLine("Birinci ededi daxil edin");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("operatoru daxil edin");
            string operation = Console.ReadLine();

            Console.WriteLine("Reqem daxil edin");
            double b = double.Parse(Console.ReadLine());

            ICalculateService calculateService= new CalculateService();



            var result = calculateService.Calculate(a, b, operation);

            Console.WriteLine($"Netice {result}");

            return result;
                
        }
    }
}
