using System;

namespace ConsoleApp22
{
	class Program
	{
		// Aufgabe 1:
		static double Eingabe() // mit rückgabe Wert / ohne Parameter
		{
			double Eingabe;
			Console.Write("Welche Zahl möchten Sie Quadrieren?\nGeben Sie eine Zahl ein: ");
			Eingabe = Convert.ToDouble(Console.ReadLine());
			return Eingabe;
		}

		static double Quadrat(double Zahl) // mit rückgabe Wert / mit Parameter
		{
			double Ergebnis;
			Ergebnis = Math.Pow(Zahl, 2); // Zahl^2 = Potenzwert;
			return Ergebnis;
		}

		static void Ausgabe(double Ergebnis) // ohne rückgabe Wert / mit Parameter
		{
			Console.WriteLine("Die Quadratzahl ist: {0}", Ergebnis);
		}

		// Aufagabe 2:
		/*
		ohne Erweiterung Aufgabe 2
		static void Zeichne(){

		Console.WriteLine(); 
		for(int i = 0; i <= 80; i++)
		Console.Write("_");
		}
		*/

		//mit Erweiterung Aufgabe 2
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
			int Width = Console.WindowWidth;

			if (Grösse < 1)
			{
				Console.Write(zeichen);
			}
			if (Grösse > Width)
			{
				for (int i = 0; i < Width; i++)
					Console.Write(zeichen);
			}
			else
			{
				for (int i = 0; i < Grösse; i++)
					Console.Write(zeichen);
			}
		}

		static void Main(string[] args)
		{
			double Zahl;
			double Ergebnis;
		
			try
			{
				Zahl = Eingabe();
				Ergebnis = Quadrat(Zahl);
				// Die Ausgabe und das Zeichnen
				Ausgabe(Ergebnis);
				Zeichne();
			}
			// Ausgabe vom Fehler und den Grund
			catch (Exception f)
			{
				Console.WriteLine("Fehler weil:" + f);
			}

			Console.ReadKey();
		}
	}
}