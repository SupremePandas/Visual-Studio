using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration
            double[] Aktienkurs = new double[300];


            Random random = new Random();
            int zahl = random.Next(10);

            double max = Aktienkurs[0];
            double min = Aktienkurs[0];
            double summe = 0;

            // Schleifen und Anweisungen
            for (int i = 0; i < 300; i++)
            {
                Aktienkurs[i] = 45.7 + Math.Sin(i) + (zahl * 0.5);

            }


            for (int i = 0; i < 300; i++)
            {
                if (max > Aktienkurs[i])
                {
                    max = Aktienkurs[i];
                }
                if (min < Aktienkurs[i])
                {
                    min = Aktienkurs[i];

                }

                summe = summe + Aktienkurs[i];

            }
            // Ausgabe
            Console.WriteLine("min ist {0}\n max ist {1} \n mitell {2}", min, max, summe / 300);

            Console.ReadKey();
        }
    }
}
