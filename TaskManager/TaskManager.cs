using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        private User _currentUser;
        SqlConnection sqlConnection;

        public TaskManager()
        {
            InitializeComponent();                     
        }

        private void layoutPanel_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(TaskCard)))
            {
                if (sender is Panel)
                {
                    (sender as Panel).Controls.Add(e.Data.GetData(typeof(TaskCard)) as TaskCard);
                }
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
            TaskDialog dialog = new TaskDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TaskBuilder taskBuilder = new TaskBuilder();
                taskBuilder.SetTitle(() => dialog.Title);
                taskBuilder.SetDescription(() => dialog.Description);
                Task task = taskBuilder.GetTask();


                using(var dbContainer = new DataModelContainer())
                {
                    Teams team = new Teams();
                    team.Name = "BOI-FI-IT-D";
                    dbContainer.Database.Connection.Open();
                    dbContainer.TeamsSet.Add(team);
                    dbContainer.SaveChanges();
                    dbContainer.Database.Connection.Close();
                }
     
                                         
                flowLayoutBackLog.Controls.Add(task.GetView());
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

        }

      
    }
}
