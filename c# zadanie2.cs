using System;
using System.Collections.Generic;

namespace CinemaReservation
{
    public class Seat
    {
        public int Row { get; }
        public int Number { get; }
        public bool IsReserved { get; set; }

        public Seat(int row, int number)
        {
            Row = row;
            Number = number;
            IsReserved = false;
        }

        public override string ToString() => $"Rząd {Row}, Miejsce {Number}";
    }

    public class Show
    {
        public string Title { get; }
        public string Time { get; }
        public List<Seat> Seats { get; } = new List<Seat>();

        public Show(string title, string time, int rows, int cols)
        {
            Title = title;
            Time = time;
            for (int r = 1; r <= rows; r++)
                for (int c = 1; c <= cols; c++)
                    Seats.Add(new Seat(r, c));
        }

        public void DisplaySeats()
        {
            Console.WriteLine($"\nSeans: {Title} | Godzina: {Time}");
            foreach (var seat in Seats)
            {
                Console.Write(seat.IsReserved ? "[X] " : "[O] ");
                if (seat.Number % 5 == 0) Console.WriteLine(); // Nowa linia co 5 miejsc
            }
        }
    }

    public class Customer
    {
        public string Name { get; }
        public Customer(string name) => Name = name;
    }

    public class Ticket
    {
        public Show Show { get; }
        public Seat Seat { get; }
        public Customer Customer { get; }

        public Ticket(Show show, Seat seat, Customer customer)
        {
            Show = show;
            Seat = seat;
            Customer = customer;
        }

        public void Print()
        {
            Console.WriteLine("\n--- WYDRUK BILETU ---");
            Console.WriteLine($"Film: {Show.Title}");
            Console.WriteLine($"Miejsce: {Seat}");
            Console.WriteLine($"Widz: {Customer.Name}");
            Console.WriteLine("---------------------\n");
        }
    }

    class Program
    {
        static void Main()
        {
            Show seans = new Show("Pulp Fiction", "20:00", 5, 5);
            Customer klient = new Customer("Jan Kowalski");

            seans.DisplaySeats();

            var targetSeat = seans.Seats[0];
            targetSeat.IsReserved = true;

            Ticket bilet = new Ticket(seans, targetSeat, klient);
            bilet.Print();

            seans.DisplaySeats();
        }
    }
}