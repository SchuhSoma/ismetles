using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ismetles
{
    class Program
    {
        static Random rnd = new Random();
        static int[] SzamTomb = new int[60];
        static void Main(string[] args)
        {
            Feladat1(); Console.WriteLine("\n----------------------------\n");
            Feladat2(); Console.WriteLine("\n----------------------------\n");
            Feladat3(); Console.WriteLine("\n----------------------------\n");
            Feladat4(); Console.WriteLine("\n----------------------------\n");
            Feladat5(); Console.WriteLine("\n----------------------------\n");
            Feladat6(); Console.WriteLine("\n----------------------------\n");
            Feladat7(); Console.WriteLine("\n----------------------------\n");
            Feladat8(); Console.WriteLine("\n----------------------------\n");
            Console.ReadKey();
        }

        private static void Feladat8()
        {
            Console.WriteLine("Feladat 8: minimum, maximum kiválasztási tétel");
            int Min = int.MaxValue;
            int MinHely = 0;
            int Max = int.MinValue;
            int MaxHely = 0;
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                if(SzamTomb[i]<Min)
                {
                    Min = SzamTomb[i];
                    MinHely = i + 1;
                }
                if (SzamTomb[i] > Max)
                {
                    Max = SzamTomb[i];
                    MaxHely = i + 1;
                }
            }
            Console.WriteLine("A tömb legnagyobb értéke: {0}",Max);
            Console.WriteLine("A tömb beni helye:{0}", MaxHely);
            Console.WriteLine("A tömb legkisebb értéke: {0}", Min);
            Console.WriteLine("A tömb beni helye:{0}", MinHely);
        }

        private static void Feladat7()
        {
            Console.WriteLine("Feladat 7: logiai változó használata, eldöntési tétel");
            bool VanNincs = false;
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                if(SzamTomb[i]==42)
                {
                    VanNincs = true;
                }
            }
            if(VanNincs==true)
            { Console.WriteLine("\tA 42 eleme a tömbnek"); }
            else
            { Console.WriteLine("\tNem eleme a 42 a tömbnek"); }
        }

        private static void Feladat6()
        {
            Console.WriteLine("Feladat 6: File-ba való kiíratás");
            var sw = new StreamWriter(@"Tombelemei.txt", false, Encoding.UTF8);
            for (int j = 0; j < SzamTomb.Length; j++)
            {

                if (j % 10 == 0)
                {
                    Console.Write("\n");
                    sw.Write("\n");
                }
                Console.Write("\t{0,-3} , ", SzamTomb[j]);
                sw.Write("\t{0,-3} , ", SzamTomb[j]);
            }
            sw.Close();
        }

        private static void Feladat5()
        {
            Console.WriteLine("Feladat 5: leszámlálási tétel, páros-páratlan aránya");
            int ParosDB = 0;
            int ParatlanDB = 0;
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                if(SzamTomb[i]%2==0)
                { ParosDB++; }
                /*else
                { ParatlanDB++; }*/
            }
            ParatlanDB = SzamTomb.Length - ParosDB;
            Console.WriteLine("A páros elemek száma: {0}",ParosDB);
            Console.WriteLine("A páratlan elemek száma: {0}", ParatlanDB);
        }

        private static void Feladat4()
        {
            Console.WriteLine("Feladat 4: rendezési tétel növekvő sorrendbe");
            int CsereElem = 0;
            for (int i = 0; i < SzamTomb.Length-1; i++)
            {
                for (int k = 0; k < SzamTomb.Length-1; k++)
                {
                    if(SzamTomb[k]>SzamTomb[k+1])
                    {
                        CsereElem = SzamTomb[k];
                        SzamTomb[k] = SzamTomb[k + 1];
                        SzamTomb[k + 1] = CsereElem;
                    }
                }
            }
            for (int j = 0; j < SzamTomb.Length; j++)
            {
                
                if (j % 10 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write("\t{0,-3} , ", SzamTomb[j]);
            }
        }

        private static void Feladat3()
        {
            Console.WriteLine("Feladat 3.é bekérés és keresés");
            Console.Write("Kérem adjn meg egy számot: ");
            int Keresendo = int.Parse(Console.ReadLine());
            int Szamlalo = 0;
            while(Szamlalo<SzamTomb.Length && Keresendo!=SzamTomb[Szamlalo])
            { Szamlalo++; }
            if(Szamlalo==SzamTomb.Length)
            { Console.WriteLine("\tA keresett szám nincs benne a tömbben"); }
            else
            { Console.WriteLine("\tKeresett szám benne van a tömbben, mégpedig eze a helyen: {0}", Szamlalo+1); }
        }

        private static void Feladat2()
        {
            Console.WriteLine("Feladat 2: Össszegzés átlagolás tétele");
            double Osszeg = 0;
            double Atlag = 0;
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                Osszeg += (double)SzamTomb[i];
                //Osszeg = Osszeg + SzamTomb[i];
            }
            Atlag = Osszeg / SzamTomb.Length;
            Console.WriteLine("\tTömb eleminek átlaga: {0:0.00}",Atlag);
            Console.WriteLine("\tTömb eleminek összege: {0}", Osszeg);
        }

        private static void Feladat1()
        {
            Console.WriteLine("Feladat 1: tömb feltöltése");
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                SzamTomb[i] = rnd.Next(-30, 61);
                if(i%10==0)
                {
                    Console.Write("\n");
                }
                Console.Write("\t{0,-3} , ",SzamTomb[i]);
            }

        }
    }
}
