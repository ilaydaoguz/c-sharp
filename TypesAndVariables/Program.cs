using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value types
            Console.WriteLine("Hello World!");
            char character='a';
            double number5 = 10.4;
            decimal number6 = 10.4M;
            bool condition = true;
            
            short number3 = 32456;
            byte number4 = 255;
            int number1 = 10; //32bit
            long number2 = 2174388292;  //64bit
            var number7 = 10;
            

            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Character is : {0}",(int)character);
            Console.WriteLine((int)Days.Sunday);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=3,Tuesday=6,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
