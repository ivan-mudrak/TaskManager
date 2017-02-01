using System;
using System.Windows.Forms;

namespace TaskManager
{
    public abstract class HeaderPanel : TableLayoutPanel
    {
        protected HeaderPanel(Action<Users> userChangedAction, Users user) { }
    }
}
