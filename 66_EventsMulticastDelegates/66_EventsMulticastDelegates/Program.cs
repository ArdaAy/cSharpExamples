using System;

namespace _66_EventsMulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an audio system
            AudioSystem audioSystem = new AudioSystem();
            // create a rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();

            // create two players and give them Id's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("Dolmaji");

            // start the audio system and the rendering engine
            // spawn the players
            GameEventManager.TriggerGameStart();
            

            Console.WriteLine("Game is running.... Press any key to end the game.");

            // pause
            Console.Read();

            // shut down the rendering engine and the audio system
            // remove the players

            GameEventManager.TriggerGameOver();
            


        }
    }
}
