using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        public static List<StandardowyCzlowiek> lista = new List<StandardowyCzlowiek>();

        static void Main(string[] args)
        {
            StandardowyCzlowiek czlowiek1 = new StandardowyCzlowiek("Kamil", 23, "Zabrze");
            StandardowyCzlowiek czlowiek2 = new StandardowyCzlowiek("Wojciech", 2, "Działdowo");
            StandardowyCzlowiek czlowiek3 = new StandardowyCzlowiek("Maria", 23, "Iława");
            StandardowyCzlowiek czlowiek4 = new StandardowyCzlowiek("Joanna", 18, "Iława");
            StandardowyCzlowiek czlowiek5 = new StandardowyCzlowiek("Maria", 10, "Nowe Miasto Lubawskie");

            lista.Add(czlowiek1);
            lista.Add(czlowiek2);
            lista.Add(czlowiek3);
            lista.Add(czlowiek4);
            lista.Add(czlowiek5);
            
            czlowiek1.sredniaWieku();
            czlowiek1.wypisywanieImion();
            czlowiek1.standardInfo();
            czlowiek1.najczestszeMiasto();
            Console.ReadLine();
        }
    }
}
