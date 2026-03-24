def zadanie1_kalkulator():
    print("\n--- Zadanie 1: Kalkulator ---")
    try:
        num1 = float(input("Podaj pierwszą liczbę: "))
        num2 = float(input("Podaj drugą liczbę: "))
        op = input("Wybierz operację (+, -, *, /): ")
        
        if op == '+':
            print(f"Wynik: {num1 + num2}")
        elif op == '-':
            print(f"Wynik: {num1 - num2}")
        elif op == '*':
            print(f"Wynik: {num1 * num2}")
        elif op == '/':
            if num2 != 0:
                print(f"Wynik: {num1 / num2}")
            else:
                print("Błąd: Nie można dzielić przez zero!")
        else:
            print("Nieznana operacja.")
    except ValueError:
        print("Błąd: Wprowadzono nieprawidłowe dane!")

def zadanie2_konwerter():
    print("\n--- Zadanie 2: Konwerter temperatur ---")
    kierunek = input("Wybierz konwersję (C - z Celsjusza na Fahrenheita, F - odwrotnie): ").strip().upper()
    
    try:
        if kierunek == 'C':
            c = float(input("Podaj temperaturę w °C: "))
            f = c * 1.8 + 32
            print(f"{c}°C = {f:.2f}°F")
        elif kierunek == 'F':
            f = float(input("Podaj temperaturę w °F: "))
            c = (f - 32) / 1.8
            print(f"{f}°F = {c:.2f}°C")
        else:
            print("Nieprawidłowy wybór.")
    except ValueError:
        print("Błąd: Wprowadzono nieprawidłowe dane!")

def zadanie3_srednia():
    print("\n--- Zadanie 3: Średnia ocen ---")
    try:
        n = int(input("Podaj liczbę ocen: "))
        if n <= 0:
            print("Liczba ocen musi być większa niż 0.")
            return

        suma_ocen = 0
        for i in range(n):
            ocena = float(input(f"Podaj ocenę {i+1}: "))
            suma_ocen += ocena
            
        srednia = suma_ocen / n
        print(f"Średnia: {srednia:.2f}")
        
        if srednia >= 3.0:
            print("Uczeń zdał.")
        else:
            print("Uczeń nie zdał.")
    except ValueError:
        print("Błąd: Wprowadzono nieprawidłowe dane!")

def main():
    while True:
        print("\n" + "="*30)
        print("MENU GŁÓWNE")
        print("1. Kalkulator dwóch liczb")
        print("2. Konwerter temperatur")
        print("3. Średnia ocen ucznia")
        print("0. Wyjście z programu")
        print("="*30)
        
        wybor = input("Wybierz numer zadania: ")
        
        if wybor == '1':
            zadanie1_kalkulator()
        elif wybor == '2':
            zadanie2_konwerter()
        elif wybor == '3':
            zadanie3_srednia()
        elif wybor == '0':
            print("Koniec programu. Do widzenia!")
            break
        else:
            print("Nieprawidłowy wybór. Spróbuj ponownie.")

if __name__ == "__main__":
    main()