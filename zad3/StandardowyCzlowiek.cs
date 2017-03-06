using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class StandardowyCzlowiek
    {
        string imie;
        int wiek;
        public static int iloscKosciSzkieletowych = 206;
        string miejscePochodzenia;
        public static int iloscChromosomow = 46;

        public StandardowyCzlowiek(string imie, int wiek, string miejscePochodzenia)
        {
            this.imie = imie;
            this.wiek = wiek;
            this.miejscePochodzenia = miejscePochodzenia;
        }

        public void sredniaWieku()
        {
            double srednia = 0;
            for (int i = 0; i < Program.lista.Count; i++)
            {
                srednia += Program.lista[i].wiek;
            }
            srednia = srednia / Program.lista.Count;
            Console.WriteLine("Średnia wieku to: " + srednia + "\n");
        }

        public void wypisywanieImion()
        {
            for (int i = 0; i < Program.lista.Count; i++)
            {
                Console.WriteLine("Imię {0} osoby to: {1}", i + 1, Program.lista[i].imie);
            }
        }
        public void standardInfo()
        {
            Console.WriteLine("\nStandardowy człowiek posiada {0} kości szkieletowych oraz {1} chromosomów\n", iloscKosciSzkieletowych, iloscChromosomow);
        }

        public void najczestszeMiasto()
        {
            string[] tabZawiera = new string[Program.lista.Count];
            int ilPowtorzen = 0;
            string szukane;
            for (int i = 0; i < Program.lista.Count; i++)
            {
                if (!tabZawiera.Contains(Program.lista[i].miejscePochodzenia))
                {
                    szukane = Program.lista[i].miejscePochodzenia;
                    for (int j = 0; j < Program.lista.Count; j++)
                    {
                        if (Program.lista[j].miejscePochodzenia == szukane)
                        {
                            ilPowtorzen++;
                        }
                    }
                    tabZawiera[i] = szukane;
                    if (ilPowtorzen == 1)
                    {
                        Console.WriteLine(szukane + " powtórzyło się " + ilPowtorzen + " raz.");
                    }
                    else
                    {
                        Console.WriteLine(szukane + " powtórzyło się " + ilPowtorzen + " razy.");
                    }
                    ilPowtorzen = 0;
                }
            }
        }


    }
}
