def kalkulator():
    try:
        a = float(input("Podaj pierwszą liczbę: "))
        b = float(input("Podaj drugą liczbę: "))
        op = input("Wybierz operację (+, -, *, /): ")

        if op == "+":
            print("Wynik:", a + b)
        elif op == "-":
            print("Wynik:", a - b)
        elif op == "*":
            print("Wynik:", a * b)
        elif op == "/":
            if b == 0:
                print("Błąd: Nie można dzielić przez zero!")
            else:
                print("Wynik:", a / b)
        else:
            print("Nieznana operacja!")
    except ValueError:
        print("Błąd: Wprowadź poprawne liczby!")

def konwerter_temperatur():
    try:
        typ = input("Wybierz konwersję (Celsjusz → Fahrenheit wpisz C, Fahrenheit → Celsjusz wpisz F): ").upper()
        temp = float(input("Podaj temperaturę: "))
        if typ == "C":
            print(f"{temp}°C = {temp * 1.8 + 32:.2f}°F")
        elif typ == "F":
            print(f"{temp}°F = {(temp - 32) / 1.8:.2f}°C")
        else:
            print("Nieznany typ konwersji!")
    except ValueError:
        print("Błąd: Wprowadź poprawną temperaturę!")

def srednia_ocen():
    try:
        n = int(input("Ile ocen chcesz podać? "))
        if n <= 0:
            print("Błąd: liczba ocen musi być większa od 0")
            return
        suma = 0
        for i in range(n):
            ocena = float(input(f"Podaj ocenę {i+1}: "))
            if ocena < 1 or ocena > 6:
                print("Błąd: Ocena musi być w przedziale 1–6")
                return
            suma += ocena
        srednia = suma / n
        print(f"Średnia: {srednia:.2f}")
        if srednia >= 3.0:
            print("Uczeń zdał.")
        else:
            print("Uczeń nie zdał.")
    except ValueError:
        print("Błąd: Wprowadź poprawne liczby!")

# Główna pętla menu
while True:
    print("\n--- MENU ---")
    print("1: Kalkulator")
    print("2: Konwerter temperatur")
    print("3: Średnia Ocen")
    print("0: Zakończ Program")

    wybor = input("Wybierz opcję: ")
    if wybor == "1":
        kalkulator()
    elif wybor == "2":
        konwerter_temperatur()
    elif wybor == "3":
        srednia_ocen()
    elif wybor == "0":
        print("Zamykanie programu...")
        break
    else:
        print("Nieznana opcja! Wybierz 1, 2, 3 lub 0.")