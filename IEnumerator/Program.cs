using System;

namespace IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket1 = new Ticket(10);
            Ticket ticket2 = new Ticket(10);
            Ticket ticket3 = new Ticket(20);

            Console.WriteLine(ticket1.Equals(ticket2));
            Console.WriteLine(ticket2.Equals(ticket3));
        }
    }
}
