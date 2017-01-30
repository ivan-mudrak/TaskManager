using System;
using JetBrains.Annotations;

namespace TaskManager
{
    interface ITaskBuilder
    {
        void SetTitle(Func<string> titleFunc);
        void SetDescription(Func<string> descriptionFunc);
        void SetTeam(Func<Team> teamFunc);
        void SetDeveloper(Func<Developer> developerFunc);
        void SetTester(Func<Tester> testerFunc);
        Task GetTask();
    }
}
