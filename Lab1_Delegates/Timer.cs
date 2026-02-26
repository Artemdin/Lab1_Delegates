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

        public Task Start(CancellationToken cts) { return Task.Run(()=>(RunTimerLoop(cts)));}

        private async Task RunTimerLoop(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    await Task.Delay(t * 1000, token); // зупиняємося
                    action();
                }
            }
            catch (TaskCanceledException) { }
          

        }
    }
}

