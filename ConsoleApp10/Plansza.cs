using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp10
{
    public class Plansza
    {
        public int[,] Gracz  {get; set;}

        public Plansza(int[,] gracz)
        {
            Gracz = gracz  ;
        }
    }
}
