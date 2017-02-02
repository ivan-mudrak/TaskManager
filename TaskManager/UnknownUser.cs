using System;

namespace TaskManager
{
    class UnknownUser : User
    {
        public override UsersEntity UserEntity
        {
            get { throw new NotImplementedException(); }
            protected set { throw new NotImplementedException(); }
        }
   
     
        public UnknownUser(UsersEntity userEntity = null)
            : base(userEntity)
        {
                 
        }

        public override HeaderPanel BuildHeaderPanel(Action<UsersEntity> userChanegdAction)
        {
            return new HeaderPanelLogIn(userChanegdAction);
        }
        public override BodyPanel BuildBodyPanel()
        {
            return new BodyPanelEmpty();
        }
    }
}
