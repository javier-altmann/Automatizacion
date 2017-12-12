using System;
using System.Collections.Generic;
using System.Linq;


namespace GodRej.Runners
{
    class ActionRunner : IActionRunner
    {
        private ICollection<Action> actions;

        private ActionRunner()
        {
            actions = new List<Action>();
        }

        public event EventHandler<EventArgs> RunAction;

        public static ActionRunner Create()
        {
            return new ActionRunner();
        }

        public ActionRunner AddAction(System.Action action, int timeout = 0)
        {
            actions.Add(new Action(action, timeout));
            return this;
        }

        public ActionRunner Delay(int timeout = 0)
        {            
            var action = actions.LastOrDefault();

            if(action == null)
            {
                throw new Exception("There are no actions.");
            }

            action.Timeout = timeout;
            return this;
        }

        public void Run()
        {
            foreach (var action in actions)
            {
                action.Run();
                OnRunAction();
            }            
        }

        private void OnRunAction()
        {
            RunAction?.Invoke(this, EventArgs.Empty);
        }
    }
}
