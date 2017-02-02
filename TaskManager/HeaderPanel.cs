using System;
using System.Windows.Forms;

namespace TaskManager
{
    public abstract class HeaderPanel : TableLayoutPanel
    {
        protected HeaderPanel(Action<UsersEntity> userChangedAction, UsersEntity userEntity) { }
    }
}
