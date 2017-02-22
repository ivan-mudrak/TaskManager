using System;
using System.ComponentModel;

namespace TaskManager
{
    public enum Roles
    {
        [Description("(none)")]
        None = -1,
        [Description("Administrator")]
        Admin = 0,       
        [Description("Scrum Master")]
        ScrumMaster = 1,
        [Description("Product Owner")]
        ProductOwner = 2,
        [Description("Developer")]
        Developer = 3,
        [Description("Tester")]
        Tester = 4
    }

    public enum Seniorities
    {
        [Description("(none)")]
        None = -1,
        [Description("Junior")]
        Junior = 0,
        [Description("Middle")]
        Middle = 1,
        [Description("Senior")]
        Senior = 2
    }

    public abstract class User
    {
        public abstract UsersEntity UserEntity { get; protected set; }

        protected User(UsersEntity userEntity) { }

        public virtual HeaderPanel BuildHeaderPanel(Action<UsersEntity> userChangedAction)
        {
            return null;
        }
        public virtual BodyPanel BuildBodyPanel()
        {
            return null;
        }
    }
}
