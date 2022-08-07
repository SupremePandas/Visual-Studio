using System;

namespace ConsoleApp22
{
	class Program
	{
		// Aufgabe 1:
		static double Eingabe() // mit rückgabe Wert / ohne Parameter
		{
			double Eingabe;
			Console.WriteLine("Welche Zahl möchten Sie Quadrieren?\nGeben Sie eine Zahl ein: ");
			Eingabe = Convert.ToDouble(Console.ReadLine());
			return Eingabe;
		}

		static double Quadrat(double Zahl) // mit rückgabe Wert / mit Parameter
		{
			double Ergebnis; 
			Ergebnis = Zahl * Zahl;
			return Ergebnis;
		}

		static void Ausgabe(double Ergebnis) // ohne rückgabe Wert / mit Parameter
		{
			Console.WriteLine("Die Quadratzahl ist: {0}" ,Ergebnis);
		}

		// Aufagabe 2:
		/*
		 * ohne Erweiterung Aufgabe 2
			   static void Zeichne(int Grösse)
			   {

				   for(int i = 0; i <= Grösse; i++)
				   Console.Write("_");
			   }
		*/

		static void Zeichne() // ohne rückgabe Wert / ohne Parameter
		{
			// Erweiterung 1
			int Grösse;
			Console.WriteLine("Wie groß soll die linie sein");
			Grösse = Convert.ToInt32(Console.ReadLine());


			// Erweiterung 2
			string zeichen;
			Console.WriteLine("Welches Zeichen?");
			zeichen = Convert.ToString(Console.ReadLine());

			// erzeugt Zeilenumbruch 
			Console.WriteLine();

			// Erweiterung 1 Methoden bedingungen
			int x = Console.WindowWidth;

			if (Grösse < 1) {
				while (true)
				{
					Console.Write(zeichen);
				}	
			}
			if (Grösse > x) { 
				for(int i = 0; i < x; i++)
					Console.Write(zeichen);
			}
			else
			{
				for(int i = 0; i < Grösse; i++)
					Console.Write(zeichen);
			}
		}

		static void Main(string[] args)
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(i);
			}
			
			Console.ReadKey();
		}
	}
}
