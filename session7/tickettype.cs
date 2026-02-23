using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session7
{
    internal enum tickettype
    {
        standard,
        vip,
        imax,
    }
    struct seat
    {
        public int row;
        public int number;
        public seat(int row, int number)
        {
            this.row = row;
            this.number = number;
        }
        
    }
    class ticket
    {
        public string movie;
        public tickettype type;
        public seat seat;
        private double price;
        public ticket(string movie, tickettype type, seat seat, double price)
        {
            this.movie = movie;
            this.type = type;
            this.seat = seat;
            this.price = price;
        }  
        public ticket(string movie): this(movie, tickettype.standard, new seat('a', 1), 50)
        {
        }
        public double CalcTotal(double taxPercent)
        {
            return price + (price* taxPercent / 100);
        }
        public void Display()
        {
            Console.WriteLine($"Movie: {movie}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Seat: Row {seat.row}, Number {seat.number}");
            Console.WriteLine($"Price: {price}");


        }
    }
     
        }
    
