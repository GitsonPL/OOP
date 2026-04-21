class Seat:
    def __init__(self, row, number):
        self.row = row
        self.number = number
        self.is_reserved = False

    def __str__(self):
        return f"Rząd {self.row}, Miejsce {self.number}"

class Show:
    def __init__(self, title, time, rows, cols):
        self.title = title
        self.time = time
        # Tworzymy macierz miejsc
        self.seats = [[Seat(r, c) for c in range(1, cols + 1)] for r in range(1, rows + 1)]

    def display_seats(self):
        print(f"\nUkład miejsc dla: {self.title} ({self.time})")
        for row in self.seats:
            row_str = " ".join(["[X]" if s.is_reserved else "[O]" for s in row])
            print(row_str)
        print("[O] - Wolne, [X] - Zajęte\n")

class Ticket:
    def __init__(self, show, seat, customer):
        self.show = show
        self.seat = seat
        self.customer = customer

    def print_ticket(self):
        print("-" * 30)
        print(f"BILET: {self.show.title}")
        print(f"DATA: {self.show.time}")
        print(f"MIEJSCE: {self.seat}")
        print(f"KLIENT: {self.customer.name}")
        print("-" * 30)

class Customer:
    def __init__(self, name, email):
        self.name = name
        self.email = email

movie = Show("Pulp Fiction", "20:00", 5, 5)
user = Customer("Jan Kowalski", "jan@example.com")

movie.display_seats()

selected_seat = movie.seats[1][2]
if not selected_seat.is_reserved:
    selected_seat.is_reserved = True
    ticket = Ticket(movie, selected_seat, user)
    ticket.print_ticket()

movie.display_seats()