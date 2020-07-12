using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp10
{
    public class Statek
    {
        public int Kolumna_startowa { get; set; }
        public int Wiersz_startowy { get; set; }

        

    // public int Dlugosc_statku
    //  {
    //     get => Dlugosc_statku; set { if (Dlugosc_statku > 2 && Dlugosc_statku < 0) { throw new ArgumentException("Zły wymiar statku"); } }
    // }

    public Statek(int kolumna_startowa, int wiersz_startowy)//, int dlugosc_statku)
        {
            Kolumna_startowa = kolumna_startowa;
            Wiersz_startowy = wiersz_startowy;
            //Dlugosc_statku = dlugosc_statku;
        }
        public override string ToString()
        {
            return "kolumna " + Kolumna_startowa + " wierszu: " + Wiersz_startowy + " punktów życia";
        }

    }

}
