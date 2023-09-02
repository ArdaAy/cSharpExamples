using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Stopwatch
{
    class Stopwatch
    {
        private DateTime _start;
        private DateTime _end;
        private TimeSpan _timeSpan;
        private bool _timeStarted;
        private bool _timeEnded;
        

        public Stopwatch()
        {
            ResetTime(0);
        }

        public void Start()
        {
            if(!_timeStarted)
            {
                ResetTime(0);
                StartTime();
                Console.WriteLine("New time is started");
            }
            else
                Console.WriteLine("Timer is started already. You need to reset to start new timer again.");
            
        }

        public void End()
        {
            if (!_timeEnded && _timeStarted)
            {
                EndTime();
                _timeSpan = _end - _start;
                Console.WriteLine("Time is stopped succesfully. You can take timespan value now.");
            }
            else if(!_timeStarted)
                Console.WriteLine("Timer is not started, you need to start it first.");
            else if(_timeEnded)
                Console.WriteLine("Timer is ended, You need to reset to start and stop new timer again");
        }

        public void GetTimespan()
        {
            if(_timeStarted && _timeEnded)
            {
                Console.WriteLine("Start Time: {0}\nEnd Time: {1}", _start, _end);
                Console.WriteLine("Total duration is {0}:{1}", _timeSpan.Minutes,_timeSpan.Seconds);
                Console.WriteLine("You can reset the system if you want to start and stop new timer.");
            }
            else if(!_timeStarted)
                Console.WriteLine("Timer is not started. You need to start it first.");
            else if(!_timeEnded)
                Console.WriteLine("Timer is not ended. You need to end it first");
        }

        public void ResetTime(int state)
        {
            _start = new DateTime();
            _end = new DateTime();
            _timeSpan = new TimeSpan();
            _timeStarted = false;
            _timeEnded = false;
            if(state == 1)
                Console.WriteLine("Time is reset.");
        }

        private void StartTime()
        {
            _start = DateTime.Now;
            _timeStarted = true;
        }

        private void EndTime()
        {
            _end = DateTime.Now;
            _timeEnded = true;
            //_timeStarted = false;
        }

        


    }
}
