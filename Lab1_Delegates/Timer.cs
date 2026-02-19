using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Delegates
{
    public delegate void TimerAction();
    internal class Timer
    {
        private int t;
        private TimerAction action;

        public Timer(TimerAction action, int interval)
        {
            t = interval; 
            this.action = action;     
        }

        public async void Start() { await Task.Run(RunTimerLoop);}

        private async Task RunTimerLoop()
        {
            while (true)
            {
                await Task.Delay(t * 1000);
                action();
            }
        }
    }
}

