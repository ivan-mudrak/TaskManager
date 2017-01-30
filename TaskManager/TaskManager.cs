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
      //      String connectionString = @"metadata=res://*/DatabaseModel.csdl|res://*/DatabaseModel.ssdl|res://*/DatabaseModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\TaskManagerDatabase.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework&quot;";
       //     sqlConnection = new SqlConnection(connectionString);                
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

                using (var dbContainer = new DatabaseModelContainer())
                {

                    Teams team = new Teams();
                    team.Name = "IT";
                    dbContainer.TeamsSet.Add(team);
                    dbContainer.SaveChanges();
                }

            
             
                

                flowLayoutBackLog.Controls.Add(task.GetView());
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

        }

      
    }
}
