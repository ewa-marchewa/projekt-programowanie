using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public static class Strzał
    {


        private static Random _generator = new Random();

        public static int strzal(int min, int max)
        {
            return _generator.Next(min, max);
        }
    }
}

