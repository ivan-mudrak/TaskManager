using System;
using JetBrains.Annotations;

namespace TaskManager
{
    class TaskBuilder : ITaskBuilder
    {
        [NotNull] private readonly Task _task;

        public TaskBuilder()
        {
            _task = new Task();
        }

        public void SetTitle(Func<string> titleFunc)
        {
            _task.Title = titleFunc();
        }

        public void SetDescription(Func<string> descriptionFunc)
        {
            _task.Description = descriptionFunc();
        }

        void ITaskBuilder.SetTeam(Func<Team> teamFunc)
        {
            _task.Team = teamFunc();
        }

        void ITaskBuilder.SetDeveloper(Func<Developer> developerFunc)
        {
            _task.Developer = developerFunc();
        }

        void ITaskBuilder.SetTester(Func<Tester> testerFunc)
        {
            _task.Tester = testerFunc();
        }

        public Task GetTask()
        {
            return _task;
        }
    }
}
