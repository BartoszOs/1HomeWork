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

            Console.WriteLine(" Witaj. Wybierz jedną z opcji : ");
            Console.WriteLine();
            Console.WriteLine(" 1 - Tell Century ");
            Console.WriteLine(" 2 - Tell How Many Years To Century ");
            Console.WriteLine();

            ConsoleKeyInfo choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case '1':
                    Console.WriteLine(" You have chosen option 1 : Tell Century");
                    Console.WriteLine();
                    Console.WriteLine(" Enter year from range : 1500 - 2100");
                    Console.WriteLine();

                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(TellCentury(year));
                    Console.ReadKey();
                    break;
                case '2':
                    Console.WriteLine(" You have chosen option 2 : Tell How Many Years To Century");
                    Console.WriteLine();
                    Console.WriteLine(" Enter a year and then century to calculate how many years are still left to full century");
                    int givenYear = int.Parse(Console.ReadLine());
                    int givenCentury = int.Parse(Console.ReadLine());
                    var result = TellHowManyYearsToCentury(givenYear, givenCentury);
                    Console.WriteLine($"It is still {result} years left till given {givenCentury} century");

                    TellHowManyYearsToCentury(1999, 20);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine(" Choice is out of range. Exiting ...");
                    Console.ReadKey();
                    break;
            }

        }

        //     * 1. Metoda TellCentury powinna zwracać słownie w którym wieku znajduje się rok podany w parametrze `year`.
        //     *    Użyj instrukcji if/else oraz operatorów porównania(<, >, <=, >=).
        //     *    Obsłuż zakres lat 1500 - 2100
        //     *    Jeśli podany rok będzie poza tym zakresem - zwróć "Błąd! Podany rok nie jest obsługiwany"

        private static string TellCentury(int year)
        {
            string result = "";

            if ((year >= 1500) && (year <= 2100))
            {
                if (year == 1500)
                {
                    result = "Piętnasty";
                }

                else if ((year > 1500) && (year <= 1600))
                {
                    result = "Szesnasty";
                }

                else if ((year > 1600) && (year <= 1700))
                {
                    result = "Siedemnasty";
                }

                else if ((year > 1700) && (year <= 1800))
                {
                    result = "Osiemnasty";
                }

                else if ((year > 1800) && (year <= 1900))
                {
                    result = "Dziewiętnasty";
                }

                else if ((year > 1900) && (year <= 2000))
                {
                    result = "Dzwudziesty";
                }

                else
                {
                    result = "Dzwudziesty pierwszy";
                }
            }
            else
            {
                result = "Błąd! Podany rok nie jest obsługiwany";
            }

            return result;
        }

        /* 2. Metoda TellHowManyYearsToCentury powinna zwracać liczbę lat do osiągnięcia pełnego wieku od wskazanego roku.
         *    Pierwszy parametr to rok, 2gi to wiek.
         */

        private static int TellHowManyYearsToCentury(int year, int century)
        {
            string centuryAsString = century.ToString();
            centuryAsString += "00";
            int centToYears = int.Parse(centuryAsString);
            return centToYears - year;
        }
    }
}
