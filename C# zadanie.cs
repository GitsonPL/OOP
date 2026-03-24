using System;

namespace PodstawyProgramowania
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dziala = true;
            
            while (dziala)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine("MENU GŁÓWNE");
                Console.WriteLine("1. Kalkulator dwóch liczb");
                Console.WriteLine("2. Konwerter temperatur");
                Console.WriteLine("3. Średnia ocen ucznia");
                Console.WriteLine("0. Wyjście z programu");
                Console.WriteLine("==============================");
                Console.Write("Wybierz numer zadania: ");
                
                string wybor = Console.ReadLine();
                
                switch (wybor)
                {
                    case "1":
                        Zadanie1();
                        break;
                    case "2":
                        Zadanie2();
                        break;
                    case "3":
                        Zadanie3();
                        break;
                    case "0":
                        Console.WriteLine("Koniec programu. Do widzenia!");
                        dziala = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            }
        }

        static void Zadanie1()
        {
            Console.WriteLine("\n--- Zadanie 1: Kalkulator ---");
            Console.Write("Podaj pierwszą liczbę: ");
            if (!double.TryParse(Console.ReadLine(), out double num1)) return;

            Console.Write("Podaj drugą liczbę: ");
            if (!double.TryParse(Console.ReadLine(), out double num2)) return;

            Console.Write("Wybierz operację (+, -, *, /): ");
            string op = Console.ReadLine();

            if (op == "+") Console.WriteLine($"Wynik: {num1 + num2}");
            else if (op == "-") Console.WriteLine($"Wynik: {num1 - num2}");
            else if (op == "*") Console.WriteLine($"Wynik: {num1 * num2}");
            else if (op == "/")
            {
                if (num2 != 0) Console.WriteLine($"Wynik: {num1 / num2}");
                else Console.WriteLine("Błąd: Dzielenie przez zero!");
            }
            else Console.WriteLine("Nieznana operacja.");
        }

        static void Zadanie2()
        {
            Console.WriteLine("\n--- Zadanie 2: Konwerter temperatur ---");
            Console.Write("Wybierz konwersję (C - z Celsjusza na Fahrenheita, F - odwrotnie): ");
            string kierunek = Console.ReadLine()?.ToUpper();

            if (kierunek == "C")
            {
                Console.Write("Podaj temperaturę w °C: ");
                if (double.TryParse(Console.ReadLine(), out double c))
                {
                    double f = c * 1.8 + 32;
                    Console.WriteLine($"{c}°C = {f:F2}°F");
                }
            }
            else if (kierunek == "F")
            {
                Console.Write("Podaj temperaturę w °F: ");
                if (double.TryParse(Console.ReadLine(), out double f))
                {
                    double c = (f - 32) / 1.8;
                    Console.WriteLine($"{f}°F = {c:F2}°C");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór.");
            }
        }

        static void Zadanie3()
        {
            Console.WriteLine("\n--- Zadanie 3: Średnia ocen ---");
            Console.Write("Podaj liczbę ocen: ");
            
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double suma = 0;
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Podaj ocenę {i + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out double ocena))
                    {
                        suma += ocena;
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy format. Zapisuję jako 0.");
                    }
                }

                double srednia = suma / n;
                Console.WriteLine($"\nŚrednia: {srednia:F2}");
                
                if (srednia >= 3.0) Console.WriteLine("Uczeń zdał.");
                else Console.WriteLine("Uczeń nie zdał.");
            }
            else
            {
                Console.WriteLine("Błąd: Wprowadzono nieprawidłową liczbę ocen.");
            }
        }
    }
}