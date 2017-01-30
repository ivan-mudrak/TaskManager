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
        public string Name { get; private set; }

        public Collection<User> UserCollection { get { return _userCollection; } }
        private readonly Collection<User> _userCollection;

        public Team(string name)
        {
            Name = name;
            _userCollection = new Collection<User>();
        }

        public void AddUser(User user)
        {
            _userCollection.Add(user);
        }

        public void RemoveUser(User user)
        {
            _userCollection.Remove(user);
        }
    }
}
