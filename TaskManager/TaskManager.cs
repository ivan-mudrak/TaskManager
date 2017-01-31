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
using Microsoft.SqlServer.Server;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        private Users _currentUser;
        private HeaderPanel _headerPanel;
        private readonly Action<Users> _userChangedAction;


        public TaskManager()
        {
            InitializeComponent();
            _userChangedAction = user =>
             {
                 _currentUser = user;
                 tableLayoutMain_UserChanged();

             };
            _headerPanel = new HeaderPanelLogIn(_userChangedAction);
            tableLayoutMain.Controls.Add(_headerPanel, 0, 0);         
        }

        private void tableLayoutMain_UserChanged()
        {
            tableLayoutMain.Controls.Remove(_headerPanel);
            if (_currentUser != null)
            {
                _headerPanel = new HeaderPanelUser(_userChangedAction, _currentUser);
            }
            else
            {
                _headerPanel = new HeaderPanelLogIn(_userChangedAction, _currentUser);
            }
            tableLayoutMain.Controls.Add(_headerPanel, 0, 0);
        }

        private void layoutPanel_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(typeof(TaskCard)))
            {
                if (sender is Panel)
                {
                    ((Panel)sender).Controls.Add(e.Data.GetData(typeof(TaskCard)) as TaskCard);
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


                using (var dbContainer = new DataModelContainer())
                {
                    // commit do DB
                }

                flowLayoutBackLog.Controls.Add(task.GetView());
            }
        } 
    }
}
