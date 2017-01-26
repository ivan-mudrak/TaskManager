using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        private readonly Collection<TaskButton> taskButtonCollection;
        private TaskButton taskButton1, taskButton2;
        private TableLayoutPanel taskCurrentLayoutPanel;

        public TaskManager()
        {
            InitializeComponent();

            taskButton1 = new TaskButton();    
            taskButton1.MouseDown += new MouseEventHandler(this.buttonTask_MouseDown);
            this.tableLayoutInProgress.Controls.Add(this.taskButton1, 0, 0);

            taskButton2 = new TaskButton();
            taskButton2.MouseDown += new MouseEventHandler(this.buttonTask_MouseDown);

            this.tableLayoutInProgress.Controls.Add(this.taskButton2, 0, 0);

        }

        private void buttonTask_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);
        }

        private void tableLayoutBody_DragDrop(object sender, DragEventArgs e)
        {
            TableLayoutPanel layoutPanel = sender as TableLayoutPanel;
            TaskButton taskButton = e.Data.GetData(typeof(TaskButton)) as TaskButton;
            layoutPanel.Controls.Add(taskButton, 0, layoutPanel.RowCount);     
        }

        private void tableLayoutBody_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskButton)))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void buttonNewTask_OnClick(object sender, EventArgs e)
        {
            TaskButton taskButton = new TaskButton();
            taskButton.MouseDown += new MouseEventHandler(this.buttonTask_MouseDown);
            tableLayoutBacklog.Controls.Add(taskButton, 0, 0);
        }
    }
}
