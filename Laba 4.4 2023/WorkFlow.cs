using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4._4_2023
{
    class Workflow
    {
        private readonly Action[] _actions;
        public event EventHandler<ActionEventArgs> ActionStarted;
        public event EventHandler<ActionEventArgs> ActionCompleted;
        public Workflow()
        {
            _actions = new Action[]
            {
                new Action("Action 1"),
                new Action("Action 2"),
                new Action("Action 3")
            };
        }

        public void Start()
        {
            foreach (var action in _actions)
            {
                OnActionStarted(action);
                Console.WriteLine($"Performing action '{action.Name}'...");
                OnActionCompleted(action);
            }
        }
        protected virtual void OnActionStarted(Action action)
        {
            ActionStarted?.Invoke(this, new ActionEventArgs(action));
        }
        protected virtual void OnActionCompleted(Action action)
        {
            ActionCompleted?.Invoke(this, new ActionEventArgs(action));
        }
    }

    class Action
    {
        public string Name { get; }
        public Action(string name)
        {
            Name = name;
        }
    }
    class ActionEventArgs : EventArgs
    {
        public Action Action { get; }
        public ActionEventArgs(Action action)
        {
            Action = action;
        }
    }
}
