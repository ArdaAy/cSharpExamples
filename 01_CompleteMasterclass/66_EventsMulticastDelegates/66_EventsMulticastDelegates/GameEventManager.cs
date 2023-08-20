using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_EventsMulticastDelegates
{
    class GameEventManager
    {
        // Event are focused to behave like a list
        //  += / -= OK
        //  =   cannot be used

        // Delegates allows a direct assignment
        //  myDelegate = myMethod

        // Event can't be triggered from outside the class that defines them.

        // a new delegate type called GameEvent
        public delegate void GameEvent();

        // crate two delegated variables called OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            // Check if the OnGameStart event is not empty
            // meaning that other methods alreadt subscribed to it
            if(OnGameStart != null)
            {
                //print a simple message
                Console.WriteLine("The game has started....");
                // call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            // Check if the OnGameOver event is not empty
            // meaning that other methods alreadt subscribed to it
            if (OnGameOver != null)
            {
                //print a simple message
                Console.WriteLine("The game is ended....");
                // call the OnGameOver that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }

    }
}
