def kalkulator():
    while True:
        try:
            a = float(input("Podaj pierwszą liczbę: "))
            b = float(input("Podaj drugą liczbę: "))
            operacja = input("Wybierz operację (+, -, *, /): ")
            
            if operacja == "+":
                wynik = a + b
            elif operacja == "-":
                wynik = a - b
            elif operacja == "*":
                wynik = a * b
            elif operacja == "/":
                if b == 0:
                    print("Nie można dzielić przez zero!")
                    continue
                wynik = a / b
            else:
                print("Nieznana operacja!")
                continue

            print(f"Wynik: {wynik}")
            break
        except ValueError:
            print("Błąd: Podaj poprawne liczby!")


def konwerter_temperatur():
    while True:
        typ = input("Wybierz konwersję (Celsjusz → Fahrenheit wpisz C, Fahrenheit → Celsjusz wpisz F, q aby wyjść): ").upper()
        if typ == "Q":
            return

        if typ != "C" and typ != "F":
            print("Nieznany typ konwersji! Spróbuj ponownie.")
            continue

        try:
            temp = float(input("Podaj temperaturę: "))
            if typ == "C":
                wynik = temp * 1.8 + 32
                print(f"{temp}°C = {wynik:.2f}°F")
            elif typ == "F":
                wynik = (temp - 32) / 1.8
                print(f"{temp}°F = {wynik:.2f}°C")
            break
        except ValueError:
            print("Błąd: Podaj poprawną temperaturę!")


def srednia_ocen():
    while True:
        try:
            liczba = int(input("Ile ocen chcesz wprowadzić? "))
            if liczba <= 0:
                print("Podaj liczbę większą od zera!")
                continue

            oceny = []
            for i in range(liczba):
                while True:
                    try:
                        ocena = float(input(f"Podaj ocenę {i + 1} (1-6): "))
                        if 1 <= ocena <= 6:
                            oceny.append(ocena)
                            break
                        else:
                            print("Ocena musi być w przedziale 1-6!")
                    except ValueError:
                        print("Podaj poprawną ocenę (liczbę)!")

            srednia = sum(oceny) / liczba
            print(f"Średnia: {srednia:.2f}")
            if srednia >= 3.0:
                print("Uczeń zdał.")
            else:
                print("Uczeń nie zdał.")
            break
        except ValueError:
            print("Błąd: Podaj poprawną liczbę ocen!")


def menu():
    while True:
        print("\nWybierz zadanie:")
        print("1. Kalkulator")
        print("2. Konwerter temperatur (Celsjusz ↔ Fahrenheit)")
        print("3. Średnia ocen ucznia")
        print("q. Wyjście")

        wybor = input("Twój wybór: ")

        if wybor == "1":
            kalkulator()
        elif wybor == "2":
            konwerter_temperatur()
        elif wybor == "3":
            srednia_ocen()
        elif wybor.lower() == "q":
            print("Do zobaczenia!")
            break
        else:
            print("Nieprawidłowy wybór, spróbuj ponownie!")


if __name__ == "__main__":
    menu()
