using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] elementy = new int[3, 3];

            Console.WriteLine("podaj numer kolumny w którą chcesz wpisać x");

          int a = int.Parse(Console.ReadLine());

            Console.WriteLine("podaj numer wiersza w który chcesz wpisać x");

           int b = int.Parse(Console.ReadLine());

            if (elementy[a, b] == 0) 
            {
                elementy[a, b] = 1;
            }
            else
            {
                Console.WriteLine("to pole jest już wypełnione, podaj nową kolumnę którą chcesz wypełnić");

                a = int.Parse(Console.ReadLine());

                Console.WriteLine("podaj numer wiersza w który chcesz wpisać x");

                b = int.Parse(Console.ReadLine());
            }


        }
    }
}
