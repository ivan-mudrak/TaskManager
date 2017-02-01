using System;

namespace TaskManager
{
    public enum Roles
    {
        Admin,
        Manager,
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
        public abstract Users Users { get; protected set; }
                
        protected User(Users users) { }

        public virtual HeaderPanel BuildHeaderPanel(Action<Users> userChangedAction)
        {
            return null;
        }
        public virtual BodyPanel BuildBodyPanel()
        {
            return null;
        }
    }
}
