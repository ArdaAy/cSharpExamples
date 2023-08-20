using System;

namespace _26_OOPExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human arda = new Human("Arda", "Ay", "brown", 28);
            arda.IntroduceMyself();

            Human julide = new Human("Jülide", "Ay", "blue");
            julide.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human cengiz = new Human("Cengiz");
            cengiz.IntroduceMyself();

            Human michael = new Human("Michael", "Jackson");
            michael.IntroduceMyself();

            Human franco = new Human("Franco", "Lorenz", 25);
            franco.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
