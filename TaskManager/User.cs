using System;

namespace TaskManager
{
    public enum Roles
    {
        Admin,       
        ScrumMaster,
        ProductOwner,
        Developer,
        Tester
    }

    public enum Seniorities
    {
        Junior,
        Middle,
        Senior
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
