using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    sealed class TaskButton : Button
    {
        private Task _task;
        private static int taskNumber = 0;

        public TaskButton()
        {
            AutoSize = false;         
            BackColor = Color.White;    
            Location = new Point(0, 0);
            Name = "buttonTask"; // TODO: name genartor
            Size = new Size(200, 40);
            Text = String.Format("Task {0}", taskNumber++);         
        } 
    }
}
