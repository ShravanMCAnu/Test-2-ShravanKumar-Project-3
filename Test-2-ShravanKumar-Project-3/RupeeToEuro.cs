using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2_ShravanKumar_Project_3
{
    internal class RupeeToEuro:ICurrency
    {
        public static double Euro=0.012;
        public void GetValue()
        {
            Console.WriteLine("Enter INR value to get Euro value");
            int value = int.Parse(Console.ReadLine());
            double resultValue = value * Euro;
            Console.WriteLine("Result value is "+resultValue+" euro");
        }
    }
}
