using System;
using System.IO;


namespace AktProjekt_PasswortGenerator_
{

    class Program
    {

        private readonly static Random Zahl = new Random();
        private readonly static StreamWriter DateiSchreiben = new StreamWriter("test.txt"); // hir kann man den Pfad zur txt datei ändern

        #region Passwortgenerator
        private static string PasswortGenerator(int PasswordLänge, int Befehl)
        {
            string Zeichen = "";
            if (Befehl == 1) Zeichen = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            if (Befehl == 2) Zeichen = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#$%&'()*+,-./";

            string RandomPasswort = "";

            for (int i = 0; i < PasswordLänge; i++)
            {
                int Randomnummer = Zahl.Next(0, Zeichen.Length);
                RandomPasswort += Zeichen[Randomnummer];
            }

            return RandomPasswort;
        }

        private static int Zifferzähler(string Passwort)
        {
            string Ziffern = "0123456789";
            int Zähler = 0;
            for (int i = 0; i < Passwort.Length; i++)
            {
                for (int x = 0; x < Ziffern.Length; x++)
                {
                    if (Passwort[i] == Ziffern[x])
                    {
                        Zähler++;
                    }
                }
            }
            return Zähler;
        }

        private static string ÜberPrüfungvonPasswortundRückgabe(int PasswordLänge, int Befehl)
        {
            string Passwort = PasswortGenerator(PasswordLänge, Befehl);
            int Zähler = Zifferzähler(Passwort);

            if (Passwort.Length < 6)
            {
                while (Zähler != 2)
                {
                    Passwort = PasswortGenerator(PasswordLänge, Befehl);
                    Zähler = Zifferzähler(Passwort);
                }
            }
            else if (Passwort.Length < 10)
            {
                while (Zähler != 3)
                {
                    Passwort = PasswortGenerator(PasswordLänge, Befehl);
                    Zähler = Zifferzähler(Passwort);
                }
            }
            else if (Passwort.Length > 10)
            {
                while (Zähler != 4)
                {
                    Passwort = PasswortGenerator(PasswordLänge, Befehl);
                    Zähler = Zifferzähler(Passwort);
                }
            }
            return Passwort;
        }
        #endregion

        #region User-Interface
        private static void Interface()
        {
            Console.WriteLine("Bitte treffen Sie eine Auswahl: \n   1. Passwörter aus Alphabet und Ziffern\n   2. Passwörter aus Alphabet, Ziffern und Sonderzeichen\nAuswahl: ");
            int Auswahl = Convert.ToInt32(Console.ReadLine());
            if (Auswahl == 1 || Auswahl == 2)
            {
                Console.WriteLine("Zeichenlänge der Passwörter: ");
                int Passwortlänge = Convert.ToInt32(Console.ReadLine());
                if (Passwortlänge >= 4 || Passwortlänge <= 16)
                {
                    Console.WriteLine("Anzahl der Passwörter: ");
                    int AnzahlPasswörter = Convert.ToInt32(Console.ReadLine());
                    if (AnzahlPasswörter >= 1)
                    {
                        Console.WriteLine("Dateiausgabe? (J/n): ");
                        string Dateiausgabe = Convert.ToString(Console.ReadLine());
                        if (Dateiausgabe == "n")
                        {

                            for (int i = 0; i < AnzahlPasswörter; i++)
                            {
                                string Passwort = ÜberPrüfungvonPasswortundRückgabe(Passwortlänge, Auswahl);
                                Console.WriteLine(Passwort);
                            }
                        } 
                        else if (Dateiausgabe == "J")
                        {
                            for (int i = 0; i < AnzahlPasswörter; i++)
                            {
                                string Passwort = ÜberPrüfungvonPasswortundRückgabe(Passwortlänge, Auswahl);
                                DateiSchreiben.WriteLine(Passwort);
                            }
                            DateiSchreiben.Close();
                            Console.WriteLine("Fertig");
                        }
                        else Console.WriteLine("Fehler");
                    }
                    else Console.WriteLine("Fehler");
                }
                else Console.WriteLine("Fehler");
            }
            else Console.WriteLine("Fehler");
        }

        #endregion


        static void Main(string[] args)
        {
            Interface();
            Console.ReadKey();
        }
    }
}
