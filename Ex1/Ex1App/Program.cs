using System;

namespace Ex1App
{
    class Program
    {
        static void Main(string[] args)
        {
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

            var year = 2000;

            // wynik dla tego przykładu: "Dwudziesty"
            TellCentury(year);

            // wynik dla tego przykładu: 1
            HowManyYearsToCentury(1999, 20);

            // Aby sprawdzić jakiś wynik - wypisz go na ekranie, o tak
            var result = "Dwudziesty";
            Console.WriteLine(result);

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        private static int HowManyYearsToCentury(int year, int century)
        {
            return 1;
        }

        private static string TellCentury(int year)
        {
            return "foo";
        }
    }
}
