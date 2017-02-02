using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace TaskManager
{

    public class Developer : User
    {
        public override UsersEntity UserEntity { get; protected set; }

        public Developer([NotNull]UsersEntity userEntity) : base(userEntity)
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
