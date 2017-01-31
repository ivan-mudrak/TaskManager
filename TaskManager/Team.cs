using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Team
    {
        private int _teamID;
        public string Name { get; private set; }

        public Collection<Users> UserCollection { get { return _usersCollection; } }
        private readonly Collection<Users> _usersCollection;
        public Collection<Tasks> TasksCollection { get { return _tasksCollection; } }
        private readonly Collection<Tasks> _tasksCollection;


        public Team(string name)
        {
            Name = name;
            _tasksCollection = new Collection<Tasks>();
            FetchTasksDB(_tasksCollection);

        }

        private async void FetchTasksDB(Collection<Tasks> tasksCollection)
        {
            using (var dbContainer = new DataModelContainer())
            {
                await dbContainer.Database.Connection.OpenAsync();
                IQueryable<Tasks> tasks = from task in dbContainer.TasksSet
                                          from user in task.Users
                                          where user.TeamsTeamId.Equals(Name)
                                          select task;

                dbContainer.Database.Connection.Close();
                
            }
        }

        public void AddTask(Tasks task)
        {
            _tasksCollection.Add(task);
            // db update
        }

        public void CompleteTask(Tasks task)
        {
            // db update
        }

        public void DeleteTask(Tasks task)
        {
            //db update
        }

        private void RemoveTask(Tasks task)
        {
            _tasksCollection.Remove(task);
            //db update
        }

    }
}
