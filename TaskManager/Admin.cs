using System;

namespace TaskManager
{
    class Admin : User
    {
        public override UsersEntity UserEntity { get; protected set; }

        public Admin(UsersEntity userEntity) : base(userEntity)
        {
            UserEntity = userEntity;
        }

        public override HeaderPanel BuildHeaderPanel(Action<UsersEntity> userChangedAction)
        {
            return new HeaderPanelUser(userChangedAction, UserEntity);
        }

        public override BodyPanel BuildBodyPanel()
        {
            return new BodyPanelAdmin();
        }

    }
}
