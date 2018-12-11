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
             *Done
             * Punkty: 2
             * 2. Metoda TellHowManyYearsToCentury powinna zwracać liczbę lat do osiągnięcia pełnego wieku od wskazanego roku.
             *    Pierwszy parametr to rok, 2gi to wiek.
             */
            Console.WriteLine("Wpisz datę między rokiem 1500-2100");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(TellCentury(year));

            Console.WriteLine();
            Console.WriteLine("Podaj rok a następnie wiek, aby obliczyć ile lat musi upłynąć do osiągnięcia pełnego wieku.");
            int yearAsArgToSubMethod = int.Parse(Console.ReadLine());
            int centuryAsInputFromUser = int.Parse(Console.ReadLine());
            var result = HowManyYearsToCentury(yearAsArgToSubMethod, centuryAsInputFromUser);
            Console.WriteLine($"Do osiągnięcia pełnego {centuryAsInputFromUser} wieku, musi upłynąć {result} lat.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static int HowManyYearsToCentury(int year, int century)
        {
            string cent = century.ToString();
            cent += "00";
            int centToYears = int.Parse(cent);
            return centToYears - year;
        }
        private static string TellCentury(int year)
        {
            string result = string.Empty;

            if (year >= 1500 && year <= 2100)
            {
                if (year == 1500)
                {
                    result = "XV wiek";
                }
                else if (year > 1500 && year <= 1600)
                {
                    result = "XVI wiek";
                }
                else if (year > 1600 && year <= 1700)
                {
                    result = "XVII wiek";
                }
                else if (year > 1700 && year <= 1800)
                {
                    result = "XVIII wiek";
                }
                else if (year > 1800 && year <= 1900)
                {
                    result = "XIX wiek";
                }
                else if (year > 1900 && year <= 2000)
                {
                    result = "XX wiek";
                }
                else if (year > 2000 && year <= 2100)
                {
                    result = "XXI wiek";
                }
                Console.Write("Wskazany rok to: ");
            }
            else
            {
                result = "Błąd! Podany rok nie jest obsługiwany";
            }
            return result;
        }
    }
}
