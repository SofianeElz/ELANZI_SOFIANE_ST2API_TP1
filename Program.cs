using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace TP1

{
    class Program
    {

        static void Sapin()
        {
            Console.WriteLine("Enter the size of the tree");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                //for loop to add space
                for (int j = 1; j <= (size - i); j++)
                {
                    Console.Write(" ");
                }
                //for loop to print *, for each line 
                //k < i *2
                //so for example, if i =1, it will print star for 1 times, as loop will work  until k < 2, that is 1 time
                // when i = 2, condition will be k < 4, means it will print star for 3 times
                // and so on.
                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int k = 1; k < (size-1); k++)
            {
                Console.Write(" ");
            }
            Console.Write("| |");




        }

        static void HautetBas(int N)
        {
            Console.Write("0");
            for (int i = 1; i <= N; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("0");
        }
        static void Cotés(int N)
        {
            Console.Write("|");
            for (int i = 1; i < N; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(" |");
        }

        private static int PowerFunction(int x)
        { return (int)(Math.Pow(x, 2) - 4); }

        static int Fibonacci(int nbrseries, int N)
        {
            int a = 1;
            for (int i = 0; i <= nbrseries; i++)
            {
                int temp = a;
                a = N;
                N = temp + a;
            }
            return a;
        }

        static void Between1and1000PRIME()
        {
            Console.WriteLine("\nPrime Numbers between 1 and 1000 : ");
            for (int i = 2; i <= 1000; i++)
            {
                bool Prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime == true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\n --------------------------------- \n");
        }

        static int Factorial(int Facto)
        {
            if (Facto == 0) return 1;
            return Facto * Factorial(Facto - 1);
        }

        static void MultiplicationTableof()
        {
            Console.WriteLine("Choose a number to see its table");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 1000)
            {
                Console.WriteLine("Choose a number to see its table");
                N = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The table of {0}", N);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, N, i * N);
            }


        }

        static void Main(string[] args)
        {


            Console.WriteLine(" Multiplication Tables");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nTable of {0} :\n", i);
                for (int j = 1; j <= 10; j++)
                {
                    if ((i * j) % 2 != 0)
                    {
                        Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                    }
                    else
                    {
                        Console.WriteLine("{0}*{1}=Not odd", i, j);
                    }

                }
            }

            MultiplicationTableof();


            Console.WriteLine(" --------------------------- EXO 2 ----------------------------- ");
            Between1and1000PRIME();

            Console.WriteLine("Fibonacci :");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(i, 3));
            }

            Console.WriteLine(Factorial(30));

            // With a number as big as 420 000, the computer would run out of power and capacitites to calculate number this big, I tried 50 I was already scared lol.
            // A recursive function is a function that call itself in that same function ( example with my Factorial function ).

            Console.WriteLine(" --------------------------- EXO 3 ----------------------------- ");


            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    int Number = PowerFunction(i);
                    Console.WriteLine(10 / Number);
                }
                catch (System.DivideByZeroException)
                {
                    System.Console.WriteLine("Il est impossible de diviser un nombre par zéro.");
                }
            }


                Console.WriteLine(" --------------------------- EXO 4 ----------------------------- ");


            Console.WriteLine("Please enter the width of the rectangle");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the lenght of the rectangle");
            int lenght = Convert.ToInt32(Console.ReadLine());
            HautetBas(width);
            for (int i = 1; i <= lenght; i++) // ici on gère la longueur du rectangle
            {

                Cotés(width);

            }
            HautetBas(width);

            Console.WriteLine(" --------------------------- EXO 5 ----------------------------- ");

            Sapin();



        }
    }
}

