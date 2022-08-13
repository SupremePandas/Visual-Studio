using System;

namespace MinMaxausgeschrieben
{
    class Program
    {
        static void Main(string[] args)
        {
            int Arraylength = 20; // Größe des arrays
            double[] Aktienkurs = new double[Arraylength];
            Random random = new Random();


            for (int i = 0; i < Aktienkurs.Length; i++)
                Aktienkurs[i] = 45.7 + Math.Sin(i) + (random.Next(10) * 0.5);

            double max = Aktienkurs[0];
            double min = Aktienkurs[0];
            double summe = 0;

            for (int i = 0; i < Arraylength; i++)
            {
				if (Aktienkurs[i] > max)
                {
                    max = Aktienkurs[i];
                }

				if (Aktienkurs[i] < min)
				{
					min = Aktienkurs[i];
				}

                summe += Aktienkurs[i];

            }
            // Ausgabe
            Console.WriteLine("min ist {0}\nmax ist {1}\nmitellwert ist {2}", min, max, (summe / Arraylength));

            Console.ReadKey();
        }
    }
}
