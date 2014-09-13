using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabler

            double summa;
            double avrundning;
            uint betalat;
            uint attbetala;
            uint växel;


            uint antalfemhundringar;
            uint antalhundringar;
            uint antalfemtiolappar;
            uint antaltjugor;
            uint antaltior;
            uint antalfemor;
            uint antalenkronor;

            //Läs in värden och hantera felinmatning
            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumman:");
                    summa = double.Parse(Console.ReadLine());
                    attbetala = (uint)Math.Round(summa);
                    if (summa < 0.5)
                    {
                        throw new OverflowException();
                    }

                    break;

                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel format, använd siffror");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("För stort eller för litet tal");
                    Console.ResetColor();
                    return;
                }

            }


            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp:");
                    betalat = uint.Parse(Console.ReadLine());
                    if (attbetala > betalat)
                    {
                        throw new OverflowException();
                    }
                    break;
                }

                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel format, använd siffror. Man kan bara betala med hela kronor");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste ange ett tal större än totalsumman");
                    Console.ResetColor();
                    return;
                }


            }

            //Räkna ut växel och öresavrundning

            växel = betalat - attbetala;
            avrundning = summa - attbetala;


            //Skriv ut Kvitto

            Console.WriteLine("");
            Console.WriteLine("KVITTO");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Totalt           : {0,15:c} ", summa);
            Console.WriteLine("Öresavrundning   : {0,15:c} ", avrundning);
            Console.WriteLine("Att betala       : {0,15:c} ", attbetala);
            Console.WriteLine("Kontant          : {0,15:c} ", betalat);
            Console.WriteLine("Tillbaka         : {0,15:c} ", växel);
            Console.WriteLine("---------------------------------");


            //Räkna ut antalet av varje sedel/mynt som ska ges tillbaka

            antalfemhundringar = växel / 500;
            växel %= 500;

            antalhundringar = växel / 100;
            växel %= 100;

            antalfemtiolappar = växel / 50;
            växel %= 50;

            antaltjugor = växel / 20;
            växel %= 20;

            antaltior = växel / 10;
            växel %= 10;

            antalfemor = växel / 5;
            växel %= 5;

            antalenkronor = växel;

            //Skriv ut antalet av sedlar/mynt


            Console.WriteLine();
            if (antalfemhundringar > 0)
            {
                Console.WriteLine("500-lappar   : {0}", antalfemhundringar);
            }
            if (antalhundringar > 0)
            {
                Console.WriteLine("100-lappar   : {0}", antalhundringar);
            }
            if (antalfemtiolappar > 0)
            {
                Console.WriteLine("50-lappar    : {0}", antalfemtiolappar);
            }
            if (antaltjugor > 0)
            {
                Console.WriteLine("20-lappar    : {0}", antaltjugor);
            }
            if (antaltior > 0)
            {
                Console.WriteLine("10-kronor    : {0}", antaltior);
            }
            if (antalfemor > 0)
            {
                Console.WriteLine("5-kronor     : {0}", antalfemor);
            }
            if (antalenkronor > 0)
            {
                Console.WriteLine("1-kronor     : {0}", antalenkronor);
            }
            


        }
    }
}
