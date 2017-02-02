using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class ProductOwner : User
    {
        public override UsersEntity UserEntity { get; protected set; }

        public ProductOwner(UsersEntity userEntity) : base(userEntity)
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
