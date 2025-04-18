using System;

class Program
{
    static void Kalkulator()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        string op = Console.ReadLine();

        double wynik;

        switch (op)
        {
            case "+":
                wynik = a + b;
                Console.WriteLine("Wynik: " + wynik);
                break;
            case "-":
                wynik = a - b;
                Console.WriteLine("Wynik: " + wynik);
                break;
            case "*":
                wynik = a * b;
                Console.WriteLine("Wynik: " + wynik);
                break;
            case "/":
                if (b != 0)
                {
                    wynik = a / b;
                    Console.WriteLine("Wynik: " + wynik);
                }
                else
                {
                    Console.WriteLine("Błąd: Dzielenie przez zero!");
                }
                break;
            default:
                Console.WriteLine("Nieznana operacja");
                break;
        }
    }

    static void KonwerterTemperatur()
    {
        Console.Write("Wybierz kierunek konwersji (C/F): ");
        string kierunek = Console.ReadLine().ToUpper();

        Console.Write("Podaj temperaturę: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (kierunek == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {wynik:F2}°F");
        }
        else if (kierunek == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {wynik:F2}°C");
        }
        else
        {
            Console.WriteLine("Nieznany kierunek konwersji");
        }
    }

    static void SredniaOcen()
    {
        Console.Write("Podaj liczbę ocen: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double suma = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Podaj ocenę {i + 1}: ");
            double ocena = Convert.ToDouble(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / n;
        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");
    }

    static void Main()
    {
        Console.WriteLine("Wybierz zadanie:");
        Console.WriteLine("1 - Kalkulator");
        Console.WriteLine("2 - Konwerter temperatur");
        Console.WriteLine("3 - Średnia ocen");
        Console.Write("Wpisz numer zadania: ");
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
            default:
                Console.WriteLine("Nieprawidłowy wybór");
                break;
        }
    }
}