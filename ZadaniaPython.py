def kalkulator():
    a = float(input("Podaj pierwszą liczbę: "))
    b = float(input("Podaj drugą liczbę: "))
    op = input("Wybierz operację (+, -, *, /): ")

    if op == "+":
        wynik = a + b
    elif op == "-":
        wynik = a - b
    elif op == "*":
        wynik = a * b
    elif op == "/":
        if b != 0:
            wynik = a / b
        else:
            wynik = "Błąd: Dzielenie przez zero!"
    else:
        wynik = "Nieznana operacja"

    print("Wynik:", wynik)


def konwerter_temperatur():
    kierunek = input("Wybierz kierunek konwersji (C/F): ").upper()
    temp = float(input("Podaj temperaturę: "))

    if kierunek == "C":
        wynik = temp * 1.8 + 32
        print(f"{temp}°C = {wynik:.2f}°F")
    elif kierunek == "F":
        wynik = (temp - 32) / 1.8
        print(f"{temp}°F = {wynik:.2f}°C")
    else:
        print("Nieznany kierunek konwersji")


def srednia_ocen():
    n = int(input("Podaj liczbę ocen: "))
    suma = 0

    for i in range(n):
        ocena = float(input(f"Podaj ocenę {i+1}: "))
        suma += ocena

    srednia = suma / n
    print(f"Średnia: {srednia:.2f}")
    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")


def menu():
    print("Wybierz zadanie:")
    print("1 - Kalkulator")
    print("2 - Konwerter temperatur")
    print("3 - Średnia ocen")
    wybor = input("Wpisz numer zadania: ")

    if wybor == "1":
        kalkulator()
    elif wybor == "2":
        konwerter_temperatur()
    elif wybor == "3":
        srednia_ocen()
    else:
        print("Nieprawidłowy wybór")


# Uruchomienie menu
if __name__ == "__main__":
    menu()