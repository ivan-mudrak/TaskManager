using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        private Users _currentUser;
        private HeaderPanel _headerPanel;
        private BodyPanel _bodyPanel;
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
            _bodyPanel = new BodyPanelEmpty();
            tableLayoutMain.Controls.Add(_headerPanel, 0, 0);
            tableLayoutMain.Controls.Add(_bodyPanel, 0, 1);         
        }

        private void tableLayoutMain_UserChanged()
        {
            tableLayoutMain.Controls.Remove(_headerPanel);
            tableLayoutMain.Controls.Remove(_bodyPanel); 
            if (_currentUser != null)
            {
                _headerPanel = new HeaderPanelUser(_userChangedAction, _currentUser);
                _bodyPanel = new BodyPanelUser(_currentUser);
            }
            else
            {
                _headerPanel = new HeaderPanelLogIn(_userChangedAction, _currentUser);
                _bodyPanel = new BodyPanelEmpty();
            }
            tableLayoutMain.Controls.Add(_headerPanel, 0, 0);
            tableLayoutMain.Controls.Add(_bodyPanel, 0, 1); 
        }
    }
}
