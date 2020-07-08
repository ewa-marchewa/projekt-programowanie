using System;
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {  
            int[,] gracz1 = new int[4, 4];
            int[,] gracz2 = new int[4, 4];
            int licznik1 = 0;
            int licznik2 = 0;




            do


            {
                Console.WriteLine("podaj numer kolumny w której chcesz ułożyć okręt");

                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("podaj numer wiersza w którym chcesz ustawić okręt");

                int b = int.Parse(Console.ReadLine());




                if (gracz1[a, b] == 0)

                {
                    gracz1[a, b] = 1;

                    Console.WriteLine("okręt ustawiony");
                    licznik1++;
                }

                else

                {
                    Console.WriteLine("to pole jest już wypełnione, podaj nową kolumnę którą chcesz wypełnić");

                }

            } while (licznik1 != 3);


            Random pozycja = new Random();
            
            do
            { 
            int c = pozycja.Next(0, 4);
            int d = pozycja.Next(0, 4);

                if (gracz2[c, d] == 0)

                {
                    gracz2[c, d] = 1;
                    licznik2++;
                }

                
            } while (licznik2 != 3);


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", i, j, gracz1[i, j]);
                    
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("a[{0}, {1}] = {2}", i, j, gracz2[i, j]);
                }
            }

        }
    }
}