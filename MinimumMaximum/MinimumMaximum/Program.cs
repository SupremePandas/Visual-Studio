using System;
using System.Linq; // für .max .min .sum usw


namespace MinimumMaximum
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


			double Maximum = Math.Round(Aktienkurs.Max(), 2); // es wird das maximum gesucht
			double Minimum = Math.Round(Aktienkurs.Min(), 2); // es wird das minimum gesucht
			double Mittelwert = Math.Round(Aktienkurs.Sum() / Arraylength, 2); // der Mittelwert wird bestimmt, mit der Summe / die länge vom array also die Anzahl 

			Console.WriteLine("Maximum Wert ist {0}\nMinimum Wert ist {1}\nDurchschnitt ist {2}", Maximum, Minimum, Mittelwert);

			_ = Console.ReadKey();
		}


	}
}
