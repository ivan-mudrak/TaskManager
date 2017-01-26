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

        public TaskButton()
        {
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            Dock = DockStyle.Bottom;
            Location = new Point(0, 0);
            Name = "buttonTask";
            Size = new Size(192, 100);
            TabIndex = 0;
            Text = "New Task";
            UseVisualStyleBackColor = false;
        } 
    }
}
