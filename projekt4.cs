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

            int punkty_gracza = 0;
            int punkty_przeciwnika = 0;


            do

            {

                Console.WriteLine("Podaj kolumnę w którą chcesz strzelić");

                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj wiersz w który chcesz strzelić");

                int y = int.Parse(Console.ReadLine());

                if (gracz2[x, y] == 0)
                {
                    Console.WriteLine("Nie trafiłeś");
                }

                else
                {
                    Console.WriteLine("Trafiłeś");
                    gracz2[x, y] = 0;
                    punkty_gracza++;
                    Console.WriteLine($"Twoje punkty {punkty_gracza}, punkty przecwnika {punkty_przeciwnika}");
                }

                int q = pozycja.Next(0, 4);
                int z = pozycja.Next(0, 4);

                if (gracz1[q, z] == 0)
                {
                    Console.WriteLine("Przeciwnik nie trafił");
                }

                else
                {
                    Console.WriteLine("Przeciwnik trafił");
                    gracz1[q, z] = 0;
                    punkty_przeciwnika++;
                    Console.WriteLine($"Twoje punkty {punkty_gracza}, punkty przecwnika {punkty_przeciwnika}");
                }
            } while (punkty_gracza != 3 || punkty_przeciwnika != 3);
        }
    }
}