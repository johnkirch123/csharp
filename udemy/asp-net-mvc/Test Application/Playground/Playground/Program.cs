using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new MyLibrary.Customer();

            MyLibrary.ICalculate calc = new MyLibrary.AddCalculate();
            MyLibrary.ICalculate subcalc = new MyLibrary.SubCalculate();

            var addResult = calc.PerformCalculation(10, 10);
            var subResult = subcalc.PerformCalculation(10, 5);
            Console.WriteLine("Addition Calculated number is {0}", addResult);
            Console.WriteLine("Subtraction Calculated number is {0}", subResult);

            MyLibrary.MyObject myObj = new MyLibrary.MyObject();
            MySecondLibrary.MyObject myObj2 = new MySecondLibrary.MyObject(2, 5);

            //myObj.number1 = 10;
            //myObj.number2 = 20;

            Console.WriteLine("number3 property from MyLibrary is {0}", myObj.number3);
            Console.WriteLine("number3 property from MySecondLibrary is {0}", myObj2.number3);
            Console.ReadLine();
        }
    }

        
}
