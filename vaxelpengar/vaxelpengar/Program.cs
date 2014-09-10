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
            int betalat;
            int attbetala;
            int växel;
            double avrundning;
            //Läs in värden och antera felinmatning
            while (true)
            {
               try
               {
                Console.Write("Ange totalsumman:");
                summa = double.Parse(Console.ReadLine());
                attbetala = Convert.ToInt32(Math.Round(summa));
                if( summa < 0.5)
                {
                    throw new OverflowException();
                }
               
                break;

               }             
               catch (FormatException)
               {
                   Console.WriteLine("Fel format, använd siffror");
               }
               catch (OverflowException)
               {
                   Console.WriteLine("För stort eller för litet tal");

               }

            }

            


            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp:");
                    betalat = int.Parse(Console.ReadLine());
                    if(attbetala > betalat)
                    {
                        throw new OverflowException();
                    }
                    break;
                }
              
                catch (FormatException)
                {
                    Console.WriteLine("Fel format");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Du måste ange ett tal större än totalsumman");
                }

            }

            //Räkna ut differensen och skriv ut pengar att ge tillbaka

            växel = betalat - attbetala;
            avrundning = summa - attbetala;

            
            //Skriv ut Kvitto

            Console.WriteLine("");
            Console.WriteLine("KVITTO");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Totalt           : {0} kr", summa);
            Console.WriteLine("Öresavrundning   : {0:f2} kr", avrundning);
            Console.WriteLine("Att betala       : {0} kr", attbetala);
            Console.WriteLine("Kontant          : {0} kr", betalat);
            Console.WriteLine("Tillbaka         : {0} kr", växel);
            Console.WriteLine("----------------------------");
            

            //Räkna ut antalet av 500kr 100kr 20kr 10kr 5kr 1kr som ska ges tillbaka

            //Skriv ut antalet av olika sedlar/mynt


































        }
    }
}
