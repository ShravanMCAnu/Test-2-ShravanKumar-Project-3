using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2_ShravanKumar_Project_3
{
    internal class RupeeToDollar:ICurrency
    {
        public static double dollar = 80.05;
        public void GetValue()
        {
            Console.WriteLine("Enter INR value to get Dollar value");
            int value = int.Parse(Console.ReadLine());
            double resultValue = value * dollar;
            Console.WriteLine("Result Value is "+resultValue+"$");
        }
    }
}
