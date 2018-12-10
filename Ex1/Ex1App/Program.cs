using System;

namespace Ex1App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rozwiazania sa
            /*
             * Zad 1. Uzupełnij kod tak aby działał wg poniższych wskazówek:
             * Punkty: 3
             * 1. Metoda TellCentury powinna zwracać słownie w którym wieku znajduje się rok podany w parametrze `year`.
             *    Użyj instrukcji if/else oraz operatorów porównania (<, >, <=, >=). 
             *    Obsłuż zakres lat 1500 - 2100
             *    Jeśli podany rok będzie poza tym zakresem - zwróć "Błąd! Podany rok nie jest obsługiwany"
             *
             * Punkty: 2
             * 2. Metoda TellHowManyYearsToCentury powinna zwracać liczbę lat do osiągnięcia pełnego wieku od wskazanego roku.
             *    Pierwszy parametr to rok, 2gi to wiek.
             */
            string tellCenturyResult = "";
            int howManyYearsToCenturyResult = 0;
            int year = 2000;

            tellCenturyResult = TellCentury(year);
            howManyYearsToCenturyResult = HowManyYearsToCentury(1999, 20);

            Console.WriteLine("Jestesmy w wieku: " + tellCenturyResult);
            Console.WriteLine("Tyle pozostalo lat do kolejnego wieku: " + howManyYearsToCenturyResult);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        private static int HowManyYearsToCentury(int year, int century)
        {
            int yearFromCentury = century * 100;
            int valueToReturn = 0;

            valueToReturn = yearFromCentury - year;

            return valueToReturn;
        }

        private static string TellCentury(int year)
        {
            if (year > 2000 && year <= 2100)
            {
                return "Dwudziesty pierwszy";
            }
            else if (year <= 2000 && year > 1900)
            {
                return "Dwudziesty";
            }
            else if (year <= 1900 && year > 1800)
            {
                return "Dziewietnasty";
            }
            else if (year <= 1800 && year > 1700)
            {
                return "Osiemnasty";
            }
            else if (year <= 1700 && year > 1600)
            {
                return "Siedemnasty";
            }
            else if (year <= 1600 && year > 1500)
            {
                return "Szesnasty";
            }
            else
            {
                return "Błąd! Podany rok nie jest obsługiwany";
            }
        }
    }
}
