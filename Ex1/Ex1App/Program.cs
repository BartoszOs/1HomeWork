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
            Console.Write("Wprowadź rok :");
            int year;
            bool result = int.TryParse(Console.ReadLine(), out year);
            // wynik dla tego przykładu: "Dwudziesty"
            Console.WriteLine(TellCentury(year));

            // wynik dla tego przykładu: 1
            Console.Write("By sprawdzić ile lat do końca danego wieku wprowadź wiek :");
            int century;
            bool result2 = int.TryParse(Console.ReadLine(), out century);
            Console.WriteLine(HowManyYearsToCentury(year, century));

            // Aby sprawdzić jakiś wynik - wypisz go na ekranie, o tak
            //var result = "Dwudziesty";
            //Console.WriteLine(result);

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        private static int HowManyYearsToCentury(int year, int century)
        {
            return ((century * 100) - (year ));
        }

        private static string TellCentury(int year)
        {
            if ((year <= 2100) & (year > 2000))
                return ("dwudziesty pierwszy");
            if ((year <= 2000) & (year > 1900))
                return ("dwudziesty");
            if ((year <= 1900) & (year > 1800))
                return ("dziewietnaty");
            if ((year <= 1800) & (year > 1700))
                return ("osiemnasty");
            if ((year <= 1700) & (year > 1600))
                return ("siedemnasty");
            if ((year <= 1600) & (year > 1500))
                return ("szesnasty");
           else
                return "Błąd! Podany rok nie jest obsługiwany";
        }
    }
}
