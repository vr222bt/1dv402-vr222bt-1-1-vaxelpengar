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
                break;
               }
                catch(System.ArgumentNullException)
               {
                   Console.WriteLine("Ett oväntat fel inträffade");
               }

               catch (System.FormatException)
               {
                   Console.WriteLine("Fel format, använd siffror");
               }
               catch (System.OverflowException)
               {
                   Console.WriteLine("För stort tal");

               }
            }

            attbetala = Convert.ToInt32(Math.Round(summa));


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
                catch (System.ArgumentNullException)
                {
                    Console.WriteLine("Null Exception fel");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Fel format");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Inte tillräckligt stort tal för att betala ");
                }

            }



             
            
            


            //Räkna ut differensen och skriv ut pengar att ge tillbaka

            

            Console.WriteLine("Att betala: {0}", attbetala);

            växel = betalat - attbetala;

            Console.WriteLine("Pengar tillbaka: {0}", växel);

            avrundning = summa - attbetala;

            Console.WriteLine("Öresavrundning: {0:f2}", avrundning);

            //Skriv ut växel samt 

            //Räkna ut antalet av 500kr 100kr 20kr 10kr 5kr 1kr som ska ges tillbaka

            //Skriv ut antalet av olika sedlar/mynt


































        }
    }
}
