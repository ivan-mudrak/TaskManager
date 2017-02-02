using System;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        private User _currentUser;
        private HeaderPanel _headerPanel;
        private BodyPanel _bodyPanel;
        private readonly Action<UsersEntity> _userChangedAction;


        public TaskManager()
        {
            InitializeComponent();
            _userChangedAction = users =>
             {
                 _currentUser = CreateUserFromUsersT(users);
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
                _headerPanel = _currentUser.BuildHeaderPanel(_userChangedAction);
                _bodyPanel = _currentUser.BuildBodyPanel();
            }
            else
            {
                _headerPanel = new HeaderPanelLogIn(_userChangedAction);
                _bodyPanel = new BodyPanelEmpty();
            }
            tableLayoutMain.Controls.Add(_headerPanel, 0, 0);
            tableLayoutMain.Controls.Add(_bodyPanel, 0, 1); 
        }

        private User CreateUserFromUsersT(UsersEntity userEntity)
        {
            User user;
            if (userEntity != null)
            {
                switch (userEntity.Role)
                {
                    case (short) Roles.Admin:
                        user = new Admin(userEntity);
                        break;
                    case (short) Roles.ScrumMaster:
                        user = new ScrumMaster(userEntity);
                        break;
                    case (short) Roles.ProductOwner:
                        user = new ProductOwner(userEntity);
                        break;
                    case (short) Roles.Developer:
                        user = new Developer(userEntity);
                        break;
                    case (short) Roles.Tester:
                        user = new Tester(userEntity);
                        break;
                    default:
                        throw new UnknownUserRole();
                }
            }
            else
            {
                user = new UnknownUser();
            }
            return user;
        }
    }

    internal class UnknownUserRole : Exception
    {

    }
}
