using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2_ShravanKumar_Project_3
{
    internal class RupeeToYen
    {
        public static double yen=1.72;

        public void GetValue()
        {
            Console.WriteLine("Enter INR value to get Yen value");
            int value=int.Parse(Console.ReadLine());
            double resultValue = value * 1.72;
            Console.WriteLine("Result Value is "+resultValue+"¥");

        }
    }
}
