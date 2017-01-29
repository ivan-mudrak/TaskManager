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
            BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Popup;
            Location = new Point(0, 0);
            Name = "buttonTask"; // TODO: name genartor
            Size = new Size(228, 80);
            Text = String.Format("Task {0}", taskNumber++);
        }
    }
}
