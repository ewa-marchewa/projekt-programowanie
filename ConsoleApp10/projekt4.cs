using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Plansza gracz1 = new Plansza(new int[4, 4]);
            Plansza gracz2 = new Plansza(new int[4, 4]);


            int licznik1 = 0;
            int licznik2 = 0;

            List<Statek> statki = new List<Statek>();

            /* GRA W STATKI. Gracz i komputer ustawiają okrtęty na planszy 4 x 4. Okręty moga być wyłącznie jednomasztowe.
             gracz ustawia okręty na wybranych przez siebie pozycjach, komputer robi to losowo.
            Na początku gracz wybioera numer kolumny i wiersza w których chce ustwić swoje jednomasztowe okręty. 
            komputer ustaw3ia to automatycznie. Następnie następuje faza strzałów, w której naprzemiennie komputer i gracz wybierają pola w które chcą strzelić.
            Wygrywa ten kto pierwszy zestrzeli wszsytkie trzy przewidziane przez zasady gry statki.
            */
            

            do
            {     
                    //  for (int s = 0; s < 3; s++) {
                    Console.WriteLine("podaj numer kolumny w której chcesz ułożyć okręt");

                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("podaj numer wiersza w którym chcesz ustawić okręt");

                    int b = int.Parse(Console.ReadLine());

                   // statki.Add(new Statek(a, b));
                   //if (s >0)
                   // {
                   //    if (statki[s-1].Equals(statki[s]) )
                   //     { Console.WriteLine("Już postawiłeś tu statek"); }
                   // }
                   // }
                   // Console.WriteLine(statki[0].ToString());
                   // Console.WriteLine(statki[1].ToString());
                   // Console.WriteLine(statki[2].ToString()); 
                   //   }
                     if (gracz1.Gracz[a, b] == 0)

                     {
                         gracz1.Gracz[a, b] = 1;

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

                        if (gracz2.Gracz[c, d] == 0)

                        {
                            gracz2.Gracz[c, d] = 1;
                            licznik2++;
                        }


                    } while (licznik2 != 3);


                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("a[{0}, {1}] = {2}", i, j, gracz1.Gracz[i, j]);

                        }
                    }
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("a[{0}, {1}] = {2}", i, j, gracz2.Gracz[i, j]);
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

                        if (gracz2.Gracz[x, y] == 0)
                        {
                            Console.WriteLine("Nie trafiłeś");
                        }

                        else
                        {
                            Console.WriteLine("Trafiłeś");
                            gracz2.Gracz[x, y] = 0;
                            punkty_gracza++;
                            Console.WriteLine($"Twoje punkty {punkty_gracza}, punkty przecwnika {punkty_przeciwnika}");
                        }

                        int q = pozycja.Next(0, 4);
                        int z = pozycja.Next(0, 4);

                        if (gracz1.Gracz[q, z] == 0)
                        {
                            Console.WriteLine("Przeciwnik nie trafił");
                        }

                        else
                        {
                            Console.WriteLine("Przeciwnik trafił");
                            gracz1.Gracz[q, z] = 0;
                            punkty_przeciwnika++;
                            Console.WriteLine($"Twoje punkty {punkty_gracza}, punkty przecwnika {punkty_przeciwnika}");
                        }
                    } while (punkty_gracza != 3 && punkty_przeciwnika != 3);

            if (punkty_gracza == 3)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Wygrałeś"); }
            else { Console.WriteLine("Przegrałeś"); }
                }

            }
        }
    
