using System;
using System.Threading;

namespace GodRej.Runners
{
    class Action
    {
        private readonly System.Action action;
        private int timeout;

        public Action(System.Action action) : this(action, 0) { }

        public Action(System.Action action, int timeout)
        {
            this.action = action;
            Timeout = timeout;
        }

        public int Timeout
        {
            get
            {
                return timeout;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("timeout", "timeout can't be negative.");
                }

                timeout = value;
            }
        }

        public void Run()
        {
            action();
            Thread.Sleep(Timeout);
        }
    }
}
