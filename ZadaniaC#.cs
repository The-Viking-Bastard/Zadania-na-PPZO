using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1: Kalkulator");
            Console.WriteLine("2: Konwerter temperatur");
            Console.WriteLine("3: Średnia ocen");
            Console.WriteLine("0: Zakończ");
            Console.Write("Wybierz opcję: ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;
                case "2":
                    KonwerterTemperatur();
                    break;
                case "3":
                    SredniaOcen();
                    break;
                case "0":
                    Console.WriteLine("Zamykanie programu...");
                    return;
                default:
                    Console.WriteLine("Nieznana opcja! Wybierz 1, 2, 3 lub 0.");
                    break;
            }
        }
    }

    static void Kalkulator()
    {
        while (true)
        {
            try
            {
                Console.Write("Podaj pierwszą liczbę (lub wpisz q aby wrócić): ");
                string inputA = Console.ReadLine();
                if (inputA.ToLower() == "q") return;
                double a = double.Parse(inputA);

                Console.Write("Podaj drugą liczbę: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Wybierz operację (+, -, *, /): ");
                string op = Console.ReadLine();

                double wynik;

                if (op == "+")
                    wynik = a + b;
                else if (op == "-")
                    wynik = a - b;
                else if (op == "*")
                    wynik = a * b;
                else if (op == "/")
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                        continue;
                    }
                    wynik = a / b;
                }
                else
                {
                    Console.WriteLine("Nieznana operacja!");
                    continue;
                }

                Console.WriteLine("Wynik: " + wynik);
                break;
            }
            catch
            {
                Console.WriteLine("Błąd: Wprowadź poprawne liczby!");
            }
        }
    }

    static void KonwerterTemperatur()
{
    while (true)
    {
        Console.Write("Wybierz konwersję (C → F wpisz C, F → C wpisz F, q aby wyjść): ");
        string typ = Console.ReadLine().ToUpper();
        if (typ == "Q") return;

        if (typ != "C" && typ != "F")
        {
            Console.WriteLine("Nieznany typ konwersji! Spróbuj ponownie.");
            continue;
        }

        try
        {
            Console.Write("Podaj temperaturę: ");
            double temp = double.Parse(Console.ReadLine());

            if (typ == "C")
            {
                double wynik = temp * 1.8 + 32;
                Console.WriteLine($"{temp}°C = {wynik:F2}°F");
            }
            else if (typ == "F")
            {
                double wynik = (temp - 32) / 1.8;
                Console.WriteLine($"{temp}°F = {wynik:F2}°C");
            }

            break;
        }
        catch
        {
            Console.WriteLine("Błąd: Wprowadź poprawną temperaturę (liczbę)!");
        }
    }
}

    static void SredniaOcen()
    {
        while (true)
        {
            try
            {
                Console.Write("Ile ocen chcesz podać? (lub wpisz q aby wrócić): ");
                string inputN = Console.ReadLine();
                if (inputN.ToLower() == "q") return;
                int n = int.Parse(inputN);

                if (n <= 0)
                {
                    Console.WriteLine("Błąd: Liczba ocen musi być większa od 0!");
                    continue;
                }

                double suma = 0;
                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Podaj ocenę {i + 1}: ");
                            double ocena = double.Parse(Console.ReadLine());

                            if (ocena < 1 || ocena > 6)
                            {
                                Console.WriteLine("Błąd: Ocena musi być w przedziale 1–6");
                                continue;
                            }

                            suma += ocena;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Błąd: Wprowadź liczbę!");
                        }
                    }
                }

                double srednia = suma / n;
                Console.WriteLine($"Średnia: {srednia:F2}");

                if (srednia >= 3.0)
                    Console.WriteLine("Uczeń zdał.");
                else
                    Console.WriteLine("Uczeń nie zdał.");
                break;
            }
            catch
            {
                Console.WriteLine("Błąd: Wprowadź poprawne dane!");
            }
        }
    }
}
