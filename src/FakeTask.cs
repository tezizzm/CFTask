using System;
using Steeltoe.Common.Tasks;

namespace task
{
    public class FakeTask : IApplicationTask
    {
        private static int _invocations;

        public void Run()
        {
            _invocations++;
            Console.WriteLine($"The task has been invoked {_invocations} times");
        }

        public string Name => "FakeTask";
    }
}
