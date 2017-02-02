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

        public Collection<UsersEntity> UserCollection { get { return _usersCollection; } }
        private readonly Collection<UsersEntity> _usersCollection;
        public Collection<TasksEntity> TasksCollection { get { return _tasksCollection; } }
        private readonly Collection<TasksEntity> _tasksCollection;


        public Team(string name)
        {
            Name = name;
            _tasksCollection = new Collection<TasksEntity>();
            FetchTasksDB(_tasksCollection);

        }

        private async void FetchTasksDB(Collection<TasksEntity> tasksCollection)
        {
            using (var dbContainer = new DataModelContainer1())
            {
                await dbContainer.Database.Connection.OpenAsync();
                IQueryable<TasksEntity> tasks = from task in dbContainer.TasksEntitySet
                                          from user in task.UsersEntity
                                          where user.TeamsEntityTeamId.Equals(Name)
                                          select task;

                dbContainer.Database.Connection.Close();
                
            }
        }

        public void AddTask(TasksEntity task)
        {
            _tasksCollection.Add(task);
            // db update
        }

        public void CompleteTask(TasksEntity task)
        {
            // db update
        }

        public void DeleteTask(TasksEntity task)
        {
            //db update
        }

        private void RemoveTask(TasksEntity task)
        {
            _tasksCollection.Remove(task);
            //db update
        }

    }
}
