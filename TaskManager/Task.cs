using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Task
    {
        private TaskCard _taskCard;

        public string Title { get; set; }
        public string Description { get; set; }
        public Team Team { get; set; }
        public Developer Developer { get; set; }
        public Tester Tester { get; set; }

        public TaskCard GetView()
        {
            return _taskCard ?? (_taskCard = new TaskCard(Title, Description, null, null));
        }
    }
}
