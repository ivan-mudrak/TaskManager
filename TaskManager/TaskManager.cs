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

        public TaskManager()
        {
            InitializeComponent();         
        }

        private void buttonTask_MouseDown(object sender, MouseEventArgs e)
        {
            ((Control)sender).DoDragDrop(sender, DragDropEffects.All);
        }

        private void layoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            Panel layoutPanel = sender as Panel;
            TaskButton taskButton = e.Data.GetData(typeof(TaskButton)) as TaskButton;
            layoutPanel.Controls.Add(taskButton);     
        }

        private void layoutPanel_DragEnter(object sender, DragEventArgs e)
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
            flowLayoutBackLog.Controls.Add(taskButton);                        
        }
    }
}
