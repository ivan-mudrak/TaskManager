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

        private void layoutPanel_DragDrop(object sender, DragEventArgs e)
        {
           
            TaskCard panel = e.Data.GetData(typeof(TaskCard)) as TaskCard;
            if (sender is Panel)
            {             
                (sender as Panel).Controls.Add(panel);
            }        
        }

        private void layoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskCard)))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void buttonNewTask_OnClick(object sender, EventArgs e)
        {          
            flowLayoutBackLog.Controls.Add(new TaskCard());                        
        }
    }
}
