using System;
using JetBrains.Annotations;

namespace TaskManager
{
    public class Tester : User
    {
        public override UsersEntity UserEntity { get; protected set; }

        public Tester([NotNull]UsersEntity userEntity) : base(userEntity)
        {
            UserEntity = userEntity;
        }

        public override HeaderPanel BuildHeaderPanel(Action<UsersEntity> userChangedAction)
        {
            return new HeaderPanelUser(userChangedAction, UserEntity);
        }

        public override BodyPanel BuildBodyPanel()
        {
            return new BodyPanelUser(UserEntity);
        }
    }
}
