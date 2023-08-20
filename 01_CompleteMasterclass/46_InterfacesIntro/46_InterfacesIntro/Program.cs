using System;

namespace _46_InterfacesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            Console.WriteLine(t2.Equals(t1));
        }
    }
}