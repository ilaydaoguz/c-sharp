﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopss
{
    internal class Program
    {
            static void Main(string[] args)
            {
                //ForLoop();
                //WhileLoop();
                //DoWhile();
                //ForeachLoop();
                if (IsPrimeNumber(1317))
                {
                    Console.WriteLine("This is a prime number");
                }
                else
                {
                    Console.WriteLine("This is not a prime number");
                }



                Console.ReadLine();
            }

            private static bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        i = number;
                    }
                }
                return result;
            }

            private static void ForeachLoop()
            {
                string[] students = new string[3] { "Muharrem", "Merve", "Ahmet" };
                foreach (string student in students)
                {
                    //student değerini foreach içerisinde değiştiremeyiz!!! ÖNEMLİ BİLGİDİR.
                    Console.WriteLine(student);
                }
            }

            private static void DoWhile()
            {
                int number = 10;
                do
                {
                    Console.WriteLine(number);
                    number--;
                } while (number >= 0);
            }

            private static void WhileLoop()
            {
                int number = 100;
                while (number > 0)
                {
                    Console.WriteLine(number);
                    number--;
                }
                Console.WriteLine("Now number is -1");
            }

            private static void ForLoop()
            {
                for (int i = 0; i <= 100; i += 2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Finished");
            }
        }
    }