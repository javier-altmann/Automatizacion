using System;

namespace GodRej.Runners
{
    interface IActionRunner
    {
        event EventHandler<EventArgs> RunAction;

        ActionRunner AddAction(System.Action action, int timeout);
        void Run();
    }
}