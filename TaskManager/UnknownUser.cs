using System;

namespace TaskManager
{
    class UnknownUser : User
    {
        public override Users Users
        {
            get { throw new NotImplementedException(); }
            protected set { throw new NotImplementedException(); }
        }
   
     
        public UnknownUser(Users users = null)
            : base(users)
        {
                 
        }

        public override HeaderPanel BuildHeaderPanel(Action<Users> userChanegdAction)
        {
            return new HeaderPanelLogIn(userChanegdAction);
        }
        public override BodyPanel BuildBodyPanel()
        {
            return new BodyPanelEmpty();
        }
    }
}
