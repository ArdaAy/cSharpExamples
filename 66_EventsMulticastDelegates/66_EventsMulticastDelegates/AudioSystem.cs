using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_EventsMulticastDelegates
{
    class AudioSystem
    {
        // simple constructor
        public AudioSystem()
        {
            //subscribe to the OnGameStart and ObGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine("Audio System Started...");
            Console.WriteLine("Playing Audio....");
        }

        // when the game is over, we want to stop our rendering engine
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped");
        }
    }
}
