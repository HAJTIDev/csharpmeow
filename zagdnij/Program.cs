using System;

namespace zagdnij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int los = random.Next(1, 100);
            int proba = 0;
            int liczbauzytkownika = 0;

            Console.WriteLine("Zgadnij liczbę (od 1 do 99)");

            while (liczbauzytkownika != los)
            {
                Console.WriteLine("Podaj swoją liczbę: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out liczbauzytkownika))
                {
                    Console.WriteLine("TO NIE JEST POPRAWNE");
                    continue;
                }

                proba++;

                if (liczbauzytkownika < los)
                {
                    Console.WriteLine("Za mało");
                }
                else if (liczbauzytkownika > los)
                {
                    Console.WriteLine("Za dużo");
                }
                else
                {
                    Console.WriteLine($"Zgadłeś! Liczba prób: {proba}");
                }
            }
        }
    }
}
