using System;

namespace _25_OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Human dolma = new Human(28, "Dolma", "Molma", "green");
            Human cengo = new Human(1, "Cengo", "Mengo", "blue");
            Human ciguli = new Human(45, "Ciguli", "blue");
            dolma.IntroduceOnceself();
            cengo.IntroduceOnceself();
            ciguli.IntroduceOnceself();
            Console.Read();
        }
    }
}
