using System;

namespace _44_InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Cengiz");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Cengiz",
                "https://images.com/shoes", true);

            VideoPost videoPost1 = new VideoPost("FailVideo", "Denis Panjuta",
                "https://video.com/failvideo", true, 10);

            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();
        }
    }
}
