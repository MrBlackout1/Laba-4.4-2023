using Laba_4._4_2023;
using System;

namespace EventDrivenWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();
            workflow.ActionStarted += (sender, e) => Console.WriteLine($"Action '{e.Action.Name}' started.");
            workflow.ActionCompleted += (sender, e) => Console.WriteLine($"Action '{e.Action.Name}' completed.");

            workflow.Start();
        }
    }
}



