using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add2(20, 3);

            //int number1;
            //int number2 = 100;
            //var result = Add3(out number1,number2);
            //Console.WriteLine(result);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(3, 5,7));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2 = 30) //değer yoksa kullan,her zaman sonda 
        {
            return number1 + number2;
        }

        static int Add3(out int number1, int numner2)
        {
            number1 = 30;
            return number1 + numner2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        } 

    }
}
